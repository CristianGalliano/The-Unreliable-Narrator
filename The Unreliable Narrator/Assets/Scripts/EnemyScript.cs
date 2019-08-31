using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //Stats
    private int HP = 20;

    //Physics
    private float speed = 0.1f;
    private float detectRange = 10f;
    private float jumpForce = 7.5f;
    private bool isGrounded = true;
    private bool isJumping = false;
    public BoxCollider2D collider;

    //Visuals
    public GameObject SkeletonDown, SkeletonSide;
    Vector3 originalScale;
    public Animator DownAnimator, SideAnimator;
    public bool Dead = false;

    //Raycast
    public LayerMask layersToHit;
    private Rigidbody2D rigid;
    RaycastHit2D left, right, down, leftDown, rightDown;
    public Transform feetPosition;

    //Pathfinding
    private PlayerMovementController player;
    private PlayerWeaponController pWeapon;
    float disToPlayer;
    private bool playerFound;
    private bool chasing = false;
    private int playerDir;
    private Vector2 playerLastPos = new Vector2(-12345, -12345);
    private Vector2 v2null = new Vector2(-12345, -12345);

    //Pathfinding - Attack
    private float knockBackForce = 100f;
    private float lastHit;
    private float attackSpeed = 1.5f;
    private float attackRange = 1.5f;

    public bool MoveType = true;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = PlayerMovementController.PMC;
        pWeapon = PlayerMovementController.PMC.gameObject.GetComponent<PlayerWeaponController>();
        originalScale = SkeletonSide.transform.localScale;

        DownAnimator = SkeletonDown.GetComponent<Animator>();
        SideAnimator = SkeletonSide.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!Dead)
        {
            FindPlayer();
            ChasePlayer();
            AttackPlayer();
            SetVisuals();
        }

        disToPlayer = Vector2.Distance(transform.position, player.centrePos);

        Debug.Log(chasing);
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("ur mom gey");
        HP -= damage;
        KnockBack();

        if (HP <= 0)
        {
            StartCoroutine(Die());
        }
    }

    IEnumerator Die()
    {
        Dead = true;
        SkeletonDown.SetActive(false);
        SkeletonSide.SetActive(true);
        SideAnimator.Play("SkeletonDeath");
        yield return new WaitForSeconds(2f);
        collider.enabled = false;
        rigid.gravityScale = 0;
    }

    void AttackPlayer()
    {
        if(disToPlayer < 1.5f && Time.time > lastHit + attackSpeed)
        {
            SideAnimator.Play("SkeletonAttack");
            StartCoroutine(Attack());
            lastHit = Time.time;
        }
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(0.75f);

        if(disToPlayer < attackRange)
        {
            pWeapon.TakeDamage(1);
            if (player.isGrounded)
                PlayerKnockBack();
        }
    }

    void KnockBack()
    {
        if (playerDir == 1)
            rigid.AddForce(new Vector2(-knockBackForce, knockBackForce));
        else if(playerDir == -1)
            rigid.AddForce(new Vector2(knockBackForce, knockBackForce));
    }

    void PlayerKnockBack()
    {
        if (playerDir == 1)
            player.rb.AddForce(new Vector2(knockBackForce, knockBackForce));
        else if (playerDir == -1)
            player.rb.AddForce(new Vector2(-knockBackForce, knockBackForce));
    }

    void SetVisuals()
    {
        if(chasing)
        {
            SkeletonDown.SetActive(false);
            SkeletonSide.SetActive(true);

            if (playerDir == 1)
            {
                SkeletonSide.transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.x);
            }
            else if (playerDir == -1)
            {
                SkeletonSide.transform.localScale = new Vector3(originalScale.x, originalScale.y, originalScale.x);
            }
        }
        else if(!chasing)
        {
            SkeletonDown.SetActive(true);
            SkeletonSide.SetActive(false);
        }
    }

    #region Pathfinding
    void FindPlayer()
    {
        if (transform.position.x < player.centrePos.x)
            playerDir = 1;
        if(transform.position.x > player.centrePos.x)
            playerDir = -1;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, player.centrePos - (Vector2)transform.position, 1000000000f, layersToHit);
        playerFound = (hit && hit.transform.tag == player.transform.tag && disToPlayer <= detectRange);

        Debug.DrawRay(transform.position, player.centrePos - (Vector2)transform.position, Color.red);
         
        if (playerFound)
            playerLastPos = player.centrePos;
    }

    void ChasePlayer()
    {
        if (Vector2.Distance(transform.position, playerLastPos) > 1f)
        {
            Move();
            JumpCheck();
        }

        chasing = playerLastPos != v2null && Vector2.Distance(transform.position, playerLastPos) >= 1f;

    }

    void Move()
    {
        if (disToPlayer > 1f && playerLastPos != v2null && Time.time > lastHit + attackSpeed)
        {
            SideAnimator.Play("SkeletonWalking");
            transform.position = new Vector2(Vector2.MoveTowards(transform.position, playerLastPos, speed).x, transform.position.y);
            //transform.position = new Vector2(Vector2.MoveTowards(transform.position, playerLastPos, jumpSpeed).x, transform.position.y);
        }
    }

    void Jump()
    {
        if(isGrounded)
        {
            rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void JumpCheck()
    {
        GroundedCheck();

        right = Physics2D.Raycast(transform.position, transform.right, 1, layersToHit);
        left = Physics2D.Raycast(transform.position, -transform.right, 1, layersToHit);
        rightDown = Physics2D.Raycast(new Vector2(transform.position.x + 1f, transform.position.y), -transform.up, 100, layersToHit);
        leftDown = Physics2D.Raycast(new Vector2(transform.position.x - 1f, transform.position.y), -transform.up, 100, layersToHit);
        
        if (isGrounded && ((right && right.transform.tag != player.transform.tag) || (left && left.transform.tag != player.transform.tag)))
        {
            Jump();
        }
        else if (isGrounded && playerDir == -1f && leftDown.collider == null)
        {
            Jump();
        }
        else if (isGrounded && playerDir == 1f && rightDown.collider == null)
        {
            Jump();
        }
    }

    void GroundedCheck()
    {
        down = Physics2D.Raycast(feetPosition.position, Vector2.down, 0.05f, player.FloorLayermask);
        isGrounded = rigid.velocity.y == 0;
    }

    #endregion
}
