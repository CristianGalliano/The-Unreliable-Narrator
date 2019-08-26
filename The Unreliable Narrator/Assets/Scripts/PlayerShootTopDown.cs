using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootTopDown : MonoBehaviour
{
    private MasterInputSystem Controls;
    private Vector3 mousePosition;
    private PlayerMovementController playerMovementController;
    public GameObject BulletPrefab;
    private float bulletSpeed = 25f;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        Controls.Player.Attack.performed += Context => shoot();
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
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        //Debug.Log(mousePosition);
    }

    private void shoot()
    {
        Vector2 shootDirection = ((Vector2)mousePosition - (Vector2)transform.position).normalized;
        GameObject Bullet = Instantiate(BulletPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(Bullet, 5f);
        float rot_z = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;
        Bullet.transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        Bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletSpeed;
        Debug.Log("bullet firing in direction " + shootDirection);
    }
}
