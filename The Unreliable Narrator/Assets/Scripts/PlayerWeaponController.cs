﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovementController))]
public class PlayerWeaponController : MonoBehaviour
{
    private MasterInputSystem Controls;
    private PlayerMovementController playerMovement;
    public BoxCollider2D meleeWeapon1;
    public CircleCollider2D meleeWeapon2;
    public GameObject bulletPrefab;
    private int weaponValue = 0;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        Controls.Player.Attack.performed += Context => Attack(weaponValue);
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

    }

    private void Attack(int Value)
    {
        Debug.Log("Weapon " + weaponValue + " is being used!");
        if (weaponValue == 0)
        {

        }
        else if (weaponValue == 1)
        {

        }
        else if (weaponValue == 2)
        {
            Shoot();
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

    private void MeleeOne()
    {
        float rot_z = Mathf.Atan2(playerMovement.previousDirection.y, playerMovement.previousDirection.x) * Mathf.Rad2Deg;
        Bullet.transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }

    private void Meleetwo()
    {

    }

    private void Shoot()
    {
        GameObject Bullet = Instantiate(bulletPrefab, gameObject.transform.position, Quaternion.identity);
        Destroy(Bullet, 2.5f);
        float rot_z = Mathf.Atan2(playerMovement.previousDirection.y, playerMovement.previousDirection.x) * Mathf.Rad2Deg;
        Bullet.transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
        Bullet.GetComponent<Rigidbody2D>().velocity = playerMovement.previousDirection * 25f;
    }
}