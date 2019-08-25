using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovementControllerTopDown))]
public class PlayerShootTopDown : MonoBehaviour
{
    private MasterInputSystem Controls;
    private Vector2 mousePosition;
    private PlayerMovementControllerTopDown playerMovementController;
    public GameObject BulletPrefab;
    private float bulletSpeed = 10f;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        Controls.PlayerTopDown.Shoot.performed += Context => shoot();
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
        updateMousePosition();
    }

    private void updateMousePosition()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void shoot()
    {
        Vector2 shootDirection = (mousePosition - new Vector2(gameObject.transform.position.x, gameObject.transform.position.y)).normalized;
        GameObject Bullet = Instantiate(BulletPrefab, gameObject.transform.position, Quaternion.identity);
        Bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletSpeed;
        Debug.Log("bullet firing in direction " + shootDirection);
    }
}
