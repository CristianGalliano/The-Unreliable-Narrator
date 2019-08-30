using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //Stats
    public int HP = 100;

    //Physics
    private float speed = 0.1f;
    private float detectRange = 10f;
    private float jumpForce = 7.5f;
    private bool isGrounded = true;
    private bool isJumping = false;

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
    private int playerDir;
    private Vector2 playerLastPos;
    private Vector2 v2null = new Vector2(-12345, -12345);

    //Pathfinding - Attack
    private float knockBackForce = 100f;
    private float lastHit;
    private float attackSpeed = 0.5f;

    public bool MoveType = true;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = PlayerMovementController.PMC;
        pWeapon = PlayerMovementController.PMC.gameObject.GetComponent<PlayerWeaponController>();
        playerLastPos = v2null;
    }

    // Update is called once per frame
    void Update()
    {
        FindPlayer();
        ChasePlayer();
        AttackPlayer();

        Debug.Log(disToPlayer);

        disToPlayer = Vector2.Distance(transform.position, player.centrePos);
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        KnockBack();

        if (HP <= 0)
        {
            pWeapon.meleeWeaponHitList.Remove(this);
            Destroy(gameObject);
        }
    }

    void AttackPlayer()
    {
        if(disToPlayer < 1.5f && Time.time > lastHit + attackSpeed)
        {
            pWeapon.TakeDamage(1);

            if(player.isGrounded)
                PlayerKnockBack();

            lastHit = Time.time;

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
        Debug.Log(hit.transform.name);
         
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
    }

    void Move()
    {
        if (disToPlayer > 1f && playerLastPos != v2null && Time.time > lastHit + attackSpeed)
        {
            transform.position = new Vector2(Vector2.MoveTowards(transform.position, playerLastPos, speed).x, transform.position.y);
            //transform.position = new Vector2(Vector2.MoveTowards(transform.position, playerLastPos, jumpSpeed).x, transform.position.y);
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
            rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            isJumping = true;
        }

        if (isGrounded && !isJumping && playerDir == -1f && leftDown.collider == null)
        {
            rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            isJumping = true;
        }

        if (isGrounded && !isJumping && playerDir == 1f && rightDown.collider == null)
        {
            rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            isJumping = true;
        }
    }

    void GroundedCheck()
    {
        down = Physics2D.Raycast(feetPosition.position, Vector2.down, 0.05f, player.FloorLayermask);
        isGrounded = down.collider != null;
        isJumping = !isGrounded;
    }

    #endregion
}
