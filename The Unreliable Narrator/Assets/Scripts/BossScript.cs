using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    //Stats
    public int HP = 150;

    //Physics
    private float speed = 10f;
    private float detectRange = 10f;
    private float knockBackForce = 250f;
    public BoxCollider2D collider;

    //Visuals
    Vector3 originalScale;
    public Animator anims;
    public bool Dead = false;

    //Raycast
    public LayerMask layersToHit;
    private Rigidbody2D rigid;

    //Pathfinding
    private PlayerMovementController player;
    private PlayerWeaponController pWeapon;
    float disToPlayer;
    float disToLastPos;
    private bool playerFound;
    private bool charging = false;
    private bool canMove = true;
    private bool isMoving = false;
    private int playerDir;
    private Vector2 playerLastPos = new Vector2(-12345, -12345);
    private Vector2 v2null = new Vector2(-12345, -12345);

    //Pathfinding - Attack
    private float lastHit;
    private float attackSpeed = 1.5f;
    private float attackRange = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = PlayerMovementController.PMC;
        pWeapon = PlayerMovementController.PMC.gameObject.GetComponent<PlayerWeaponController>();

        originalScale = new Vector3(1.25f, 1.25f, 1.25f);
    }

    // Update is called once per frame
    void Update()
    {
        FindPlayer();
        ChasePlayer();
        SetVisuals();

        disToPlayer = Vector2.Distance(transform.position, player.centrePos);
        disToLastPos = Vector2.Distance(transform.position, playerLastPos);
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;

        if (HP <= 0)
        {
            StartCoroutine(Die());
        }
    }

    IEnumerator Die()
    {
        Dead = true;
        //Die Animation
        yield return new WaitForSeconds(2f);
        collider.enabled = false;
        rigid.gravityScale = 0;
    }

    void AttackPlayer()
    {
        if(isMoving)
        {
            pWeapon.TakeDamage();
            PlayerKnockBack();
        }
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
        if (isMoving)
        {
            anims.Play("MonsterCharge");

            if (playerDir == 1)
            {
                transform.localScale = new Vector3(-originalScale.x, originalScale.y, originalScale.x);
            }
            else if (playerDir == -1)
            {
                transform.localScale = new Vector3(originalScale.x, originalScale.y, originalScale.x);
            }
        }
        else if (!isMoving)
        {
            anims.Play("MonsterIdle");
        }
    }

    #region Pathfinding
    void FindPlayer()
    {
        if(!charging)
        {
            charging = true;

            if (transform.position.x < player.centrePos.x)
                playerDir = 1;
            if (transform.position.x > player.centrePos.x)
                playerDir = -1;
        }
    }

    void ChasePlayer()
    {
        if(charging && canMove)
        {
            transform.Translate(new Vector2(playerDir, 0) * speed * Time.deltaTime);
            isMoving = true;
        }
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.transform.tag != "Floor")
        {
            if (hit.transform.tag == "Player")
            {
                AttackPlayer();
                StartCoroutine(EndCharge(1.5f));
            }
            else
            {
                TakeDamage(20);
                StartCoroutine(EndCharge(5f));
            }
        }
    }

    IEnumerator EndCharge(float time)
    {
        canMove = false;
        isMoving = false;
        yield return new WaitForSeconds(time);
        charging = false;
        canMove = true;
    }
    #endregion
}
