using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovementController))]
public class PlayerWeaponController : MonoBehaviour
{
    private MasterInputSystem Controls;
    private PlayerMovementController playerMovement;
    public BoxCollider2D meleeWeapon1;
    public CircleCollider2D meleeWeapon2;
    public List<EnemyScript> mw1HitList, mw2HitList;
    public GameObject bulletPrefab;
    private int weaponValue = 0;

    private bool isCharging;
    public float charge = 0;
    private float lastShot;
    private float rateOfFire = 0.05f;

    private float lastHit;
    private float hitChargeTime = 0.05f;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        
        Controls.Player.Attack.performed += Context => Attack(weaponValue);
        Controls.Player.Attack.canceled += Context => Shoot();

        Controls.Player.ChangeWeapon1.performed += Context => weaponValue = 0;
        Controls.Player.ChangeWeapon2.performed += Context => weaponValue = 1;
        Controls.Player.ChangeWeapon3.performed += Context => weaponValue = 2;
        Controls.Player.ChangeWeaponNext.performed += Context => ToggleWeapon(1);
        Controls.Player.ChangeWeaponPrevious.performed += Context => ToggleWeapon(0);
    }

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovementController>();
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
        BowCharge();
        SetHitboxDir();
    }

    private void Attack(int Value)
    {
        Debug.Log("Weapon " + weaponValue + " is being used!");
        if (weaponValue == 0)
        {
            MeleeOne();
        }
        else if (weaponValue == 1)
        {
            Meleetwo();
        }
        else if (weaponValue == 2)
        {
            isCharging = true;
        }
    }

    private void ToggleWeapon(int i)
    {
        if (i == 0)
        {
            if (weaponValue > 0)
            {
                weaponValue--;
            }
            else
            {
                weaponValue = 2;
            }
        }
        if (i == 1)
        {
            if (weaponValue < 2)
            {
                weaponValue++;
            }
            else
            {
                weaponValue = 0;
            }
        }
    }

    private void SetHitboxDir()
    {
        if (playerMovement.previousDirection.x == 1)
            meleeWeapon1.transform.rotation = Quaternion.Euler(0, 0, -90);
        else if (playerMovement.previousDirection.x == -1)
            meleeWeapon1.transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    private void MeleeOne()
    {
        /*
        float rot_z = Mathf.Atan2(playerMovement.previousDirection.y, playerMovement.previousDirection.x) * Mathf.Rad2Deg;
        meleeWeapon1.transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
        */

        foreach(EnemyScript enemy in mw1HitList)
        {
            enemy.TakeDamage(10);
        }
    }

    private void Meleetwo()
    {
        if (Time.time > lastHit + hitChargeTime)
        {

            lastHit = Time.time;
        }

        foreach (EnemyScript enemy in mw2HitList)
        {
            enemy.TakeDamage(10);
        }

    }

    private void Shoot()
    {
        if(charge >= 100f && Time.time > lastShot + rateOfFire)
        {
            GameObject Bullet = Instantiate(bulletPrefab, gameObject.transform.position, Quaternion.identity);
            Bullet.GetComponent<Rigidbody2D>().velocity = playerMovement.previousDirection * 25f;

            float rot_z = Mathf.Atan2(playerMovement.previousDirection.y, playerMovement.previousDirection.x) * Mathf.Rad2Deg;
            Bullet.transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
            Destroy(Bullet, 2.5f);

            lastShot = Time.time;
        }

        isCharging = false;
        charge = 0;

    }

    void BowCharge()
    {
        if (isCharging && charge < 100f)
            charge += 2f;
    }
}
