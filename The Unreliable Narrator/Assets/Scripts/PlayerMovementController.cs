using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementController : MonoBehaviour
{
    private MasterInputSystem Controls;
    private Vector2 Direction;
    private float speed = 0.1f;
    public Animator animator;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        Controls.Player.Movement.performed += Context => Direction = Context.ReadValue<Vector2>();
        Controls.Player.Movement.canceled += Context => Direction = Vector2.zero;        
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
    private void Update()
    {
        Vector2 Movement = Direction * speed;
        animator.SetFloat("Horizontal", Movement.x);
        animator.SetFloat("Vertical", Movement.y);
        transform.Translate(Movement);
        if (Direction == Vector2.zero)
        {
            animator.SetBool("IsMoving", false);
        }
        else
        {
            animator.SetBool("IsMoving", true);
        }
    }
}
