using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementControllerPlatform : MonoBehaviour
{
    private MasterInputSystem Controls;
    public float direction;
    private float speed = 10f;
    private float jumpSpeed = 5f;
    private float jumpForce = 7.5f;
    public bool isGrounded = true, canDoubleJump = true;
    public Rigidbody2D rb;
    public Transform feetPosition;
    public Animator animator;
    public LayerMask FloorLayermask;
    private int jumpCount = 0;

    private void Awake()
    {
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

    }

    // Update is called once per frame
    void Update()
    {
        movementFunc();
        canJump();
    }

    private void jumpFunc()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
        if (!isGrounded && canDoubleJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            canDoubleJump = false;
        }
    }

    private void movementFunc()
    {
        if (direction == 0)
        {
            //animator.SetBool("IsMoving", false);
        }
        else
        {
            //animator.SetBool("IsMoving", true);
        }
        if (isGrounded)
        {
            float Movement = direction * speed * Time.deltaTime;
            //animator.SetFloat("Horizontal", direction);
            transform.position = new Vector2(transform.position.x + Movement, transform.position.y);
        }
        else
        {
            float Movement = direction * jumpSpeed * Time.deltaTime;
            transform.position = new Vector2(transform.position.x + Movement, transform.position.y);
        }
    }

    private void canJump()
    {
        RaycastHit2D Hit = Physics2D.Raycast(feetPosition.position, Vector2.down, 0.01f, FloorLayermask);
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
}
