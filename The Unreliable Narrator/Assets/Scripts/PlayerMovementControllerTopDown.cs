using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementControllerTopDown : MonoBehaviour
{
    private MasterInputSystem Controls;
    public Vector2 direction, mousePosition;
    public Animator animator;
    private float speed = 5f;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        Controls.PlayerTopDown.Movement.performed += Context => direction = Context.ReadValue<Vector2>();
        Controls.PlayerTopDown.Movement.canceled += Context => direction = Vector2.zero;
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
        direction = new Vector2(Mathf.RoundToInt(direction.x), Mathf.RoundToInt(direction.y));
        Vector2 Movement = direction * speed * Time.deltaTime;
        //animator.SetFloat("Horizontal", Movement.x);
        //animator.SetFloat("Vertical", Movement.y);
        transform.Translate(Movement);
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
