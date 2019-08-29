using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    //Stats
    public int HP = 100;

    //Physics
    private float speed = 0.05f;
    private float detectRange = 9f;
    private float jumpSpeed;
    private float jumpForce = 6f;
    private bool isGrounded = true;

    //Raycast
    public LayerMask layersToHit;
    private Rigidbody2D rigid;
    RaycastHit2D left, right, down;
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
        jumpSpeed = speed / 2;
        playerLastPos = v2null;
    }

    // Update is called once per frame
    void Update()
    {
        FindPlayer();
        ChasePlayer();
        AttackPlayer();

        disToPlayer = Vector2.Distance(transform.position, player.transform.position);
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
        if(disToPlayer < 1f && Time.time > lastHit + attackSpeed)
        {
            pWeapon.TakeDamage(1);
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
        if (transform.position.x < player.transform.position.x)
            playerDir = 1;
        if(transform.position.x > player.transform.position.x)
            playerDir = -1;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, player.transform.position - transform.position, 1000000000f, layersToHit);
        playerFound = (hit.transform.tag == player.transform.tag && disToPlayer <= detectRange);

        if (playerFound)
            playerLastPos = player.transform.position;
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
            if(isGrounded)
                transform.position = new Vector2(Vector2.MoveTowards(transform.position, playerLastPos, speed).x, transform.position.y);
            else
                transform.position = new Vector2(Vector2.MoveTowards(transform.position, playerLastPos, jumpSpeed).x, transform.position.y);
        }
    }

    void JumpCheck()
    {
        GroundedCheck();

        right = Physics2D.Raycast(transform.position, transform.right, 1, layersToHit);
        left = Physics2D.Raycast(transform.position, -transform.right, 1, layersToHit);

        if (isGrounded && ((right && right.transform.tag != player.transform.tag) || (left && left.transform.tag != player.transform.tag)))
        {
            rigid.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void GroundedCheck()
    {
        down = Physics2D.Raycast(feetPosition.position, Vector2.down, 0.05f, player.FloorLayermask);
        isGrounded = down.collider != null;
    }

    #endregion
}
