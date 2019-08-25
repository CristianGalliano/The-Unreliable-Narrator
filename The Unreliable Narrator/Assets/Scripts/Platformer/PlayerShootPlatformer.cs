using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootPlatformer : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shotSpawn;
    public int shotSpeed;
    

    private PlayerMovementControllerPlatformer player;
    private Vector2 dirToShoot;
    private float lastShot = 0;
    private float fireRate = 0.15f;

    void Start()
    {
        Physics2D.IgnoreLayerCollision(10, 11);
        Physics2D.IgnoreLayerCollision(11, 11);

        player = gameObject.GetComponent<PlayerMovementControllerPlatformer>();
    }

    // Update is called once per frame
    void Update()
    {
        GetShootDirection();
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButton(0) && Time.time > lastShot + fireRate)
        {
            GameObject bullet = Instantiate(bulletPrefab, shotSpawn.position, shotSpawn.rotation);
            bullet.GetComponent<SpriteRenderer>().flipX = dirToShoot.x == -1;
            bullet.GetComponent<Rigidbody2D>().gravityScale = 0;
            bullet.GetComponent<Rigidbody2D>().velocity = dirToShoot * shotSpeed;
            Destroy(bullet, 5f);
            lastShot = Time.time;
        }
    }

    void GetShootDirection()
    {
        if (player.direction != 0)
            dirToShoot = new Vector2(player.direction,0);

    }
}
