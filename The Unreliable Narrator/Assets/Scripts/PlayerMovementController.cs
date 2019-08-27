using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerWeaponController))]
public class PlayerMovementController : MonoBehaviour
{
    public static PlayerMovementController PMC;

    private MasterInputSystem Controls;
    public Vector2 direction, previousDirection = Vector2.up;
    public Animator animator;
    private float speed = 5f;

    public bool canMove = true;

    public int playerGameState = 0;


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
        Physics2D.IgnoreLayerCollision(10, 11);

        Controls = new MasterInputSystem();
        Controls.Player.Movement.performed += Context => direction = Context.ReadValue<Vector2>();
        Controls.Player.Movement.canceled += Context => direction = Vector2.zero;
    }

    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
        {
            return;
        }

        direction = new Vector2(Mathf.RoundToInt(direction.x), Mathf.RoundToInt(direction.y));
        Vector2 Movement = direction * speed * Time.deltaTime;
        transform.Translate(Movement);

        if (direction != Vector2.zero && direction != null)
        {
            previousDirection = direction;
        }

        //animator.SetFloat("Horizontal", Movement.x);
        //animator.SetFloat("Vertical", Movement.y);
        //if (direction == Vector2.zero)
        //{
        //    animator.SetBool("IsMoving", false);
        //}
        //else
        //{
        //    animator.SetBool("IsMoving", true);
        //}
    }
}
