using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementControllerISO : MonoBehaviour
{
    private MasterInputSystem Controls;
    public Vector2 direction;
    private float speed = 0.1f;
    public Animator animator;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        Controls.PlayerIsometric.Movement.performed += Context => direction = Context.ReadValue<Vector2>();
        Controls.PlayerIsometric.Movement.canceled += Context => direction = Vector2.zero;        
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
        Vector2 Movement = direction * speed * Time.deltaTime;
        animator.SetFloat("Horizontal", Movement.x);
        animator.SetFloat("Vertical", Movement.y);
        transform.Translate(Movement);
        if (direction == Vector2.zero)
        {
            animator.SetBool("IsMoving", false);
        }
        else
        {
            animator.SetBool("IsMoving", true);
        }
    }
}
