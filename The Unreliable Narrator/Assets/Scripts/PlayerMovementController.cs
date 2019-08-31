using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovementController : MonoBehaviour
{
    public static PlayerMovementController PMC;
    public Vector2 previousDirection = Vector2.right;
    public bool canMove = true;
    public int playerGameState = 0;
    private MasterInputSystem Controls;
    public float direction;
    private float speed = 10f;
    private float jumpSpeed = 5f;
    private float jumpForce = 8.5f;
    public bool isGrounded = true, canDoubleJump = true;
    public Rigidbody2D rb;
    public Transform feetPosition;
    public Animator animator;
    public LayerMask FloorLayermask;
    private int jumpCount = 0;
    public PlayerWeaponController thisPWC;

    public Vector2 centrePos;

    [Header("PlayerSprites")]
    public GameObject PlayerSide;
    public GameObject PlayerDown;


    private void Awake()
    {
        if (PMC == null)
        {
            PMC = this;
        }
        else if (PMC != this)
        {
            Destroy(this);
        }
        Controls = new MasterInputSystem();
        Controls.Player.Movement.performed += Context => direction = Context.ReadValue<float>();
        Controls.Player.Movement.canceled += Context => direction = 0;
        Controls.Player.Jump.performed += Context => jumpFunc();
    }

    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerSide.SetActive(false);
        PlayerDown.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            movementFunc();
            canJump();
        }
        else if (!canMove && thisPWC.canAttack)
        {
            SetPlayerDownActive(true);
        }

        centrePos = new Vector2(transform.position.x, transform.position.y + 1.5f);
    }

    private void jumpFunc()
    {
        if (canMove)
        {
            if (isGrounded)
            {
                SetPlayerDownActive(false);
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                StartCoroutine(SetJump());
                isGrounded = false;
                
            }
            if (!isGrounded && canDoubleJump) {
                rb.velocity = new Vector2(rb.velocity.x, 0);
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                canDoubleJump = false;
            }
        }
    }

    public void SetPlayerDownActive(bool toggle) {
        PlayerDown.SetActive(toggle);
        PlayerSide.SetActive(!toggle);
    }

    private void movementFunc()
    {
        if (direction == 0 && isGrounded)
        {
            animator.SetBool("IsMoving", false);
            SetPlayerDownActive(true);
        }
        else if(direction < 0) { 
            transform.localScale = new Vector3(-0.75f, transform.localScale.y, transform.localScale.z);
            direction = -1;
        }
        else if(direction > 0)
        {
            transform.localScale = new Vector3(0.75f, transform.localScale.y, transform.localScale.z);
            direction = 1;
        }

        if(direction != 0)
        {
            SetPlayerDownActive(false);
            animator.SetBool("IsMoving", true);
            previousDirection = new Vector2(direction, 0);
        }

        if (isGrounded)
        {
            animator.SetBool("isFalling", false);
            float Movement = direction * speed * Time.deltaTime;
            //animator.SetFloat("Horizontal", direction);
            transform.position = new Vector2(transform.position.x + Movement, transform.position.y);
        }
        else
        {
            //animator.SetBool("isFalling", true);
            SetPlayerDownActive(false);
            float Movement = direction * jumpSpeed * Time.deltaTime;
            transform.position = new Vector2(transform.position.x + Movement, transform.position.y);
        }
    }

    private void canJump()
    {
        RaycastHit2D Hit = Physics2D.Raycast(feetPosition.position, Vector2.down, 0.1f, FloorLayermask);
        Debug.DrawRay(feetPosition.position, Vector2.down, Color.red);
        if (Hit.collider != null)
        {
            canDoubleJump = true;
            isGrounded = true;
            jumpCount = 0;
            //animator.SetBool("IsJumping", false);
        }
        else
        {
            isGrounded = false;
            //animator.SetBool("IsJumping", true);
        }
    }
    IEnumerator SetJump() {
        yield return new WaitForSeconds(0.05f);
        animator.SetTrigger("Jump");
        animator.SetBool("isFalling", true);
    }
}
