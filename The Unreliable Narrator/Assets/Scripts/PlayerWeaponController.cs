using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerMovementController))]
public class PlayerWeaponController : MonoBehaviour
{
    //References
    private MasterInputSystem Controls;
    private PlayerMovementController playerMovement;

    //Stats
    public int health = 6;
    public GameObject[] Hearts;
    int currentHeart = -1;

    //Combat
    public BoxCollider2D meleeWeapon;
    public List<EnemyScript> meleeWeaponHitList;
    public GameObject bulletPrefab;
    public bool canAttack = true;

    private int weaponValue = 0;
    private bool isCharging;
    public float charge = 0;

    //Melee Weapon
    private float lastHit;
    private float hitChargeTime = 0.05f;

    //Ranged Weapon
    private float lastShot;
    private float rateOfFire = 0.05f;

    public Animator sideAnimator;

    public GameObject[] weapons;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        
        Controls.Player.Attack.performed += Context => Attack(weaponValue);
        Controls.Player.Attack.canceled += Context => Shoot();

        Controls.Player.ChangeWeapon1.performed += Context => weaponValue = 0;
        Controls.Player.ChangeWeapon2.performed += Context => weaponValue = 1;
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
        Debug.Log("Weapon " + weaponValue + " is being used!");
        BowCharge();
        //SetHitboxDir();
        if (PlayerMovementController.PMC.canMove)
        {
            if (weaponValue == 0)
            {
                weapons[0].SetActive(true);
                weapons[1].SetActive(true);
            }
            else
            {
                weapons[0].SetActive(false);
                weapons[1].SetActive(false);
            }
        }
    }

    private void Attack(int Value)
    {
        if (PlayerMovementController.PMC.canMove)
        {
            Debug.Log("Weapon " + weaponValue + " is being used!");
            if (weaponValue == 0)
            {
                MeleeOne();
            }
            else if (weaponValue == 1)
            {
                isCharging = true;
            }
        }
    }

    public void TakeDamage(int damage)
    {
        if (health > 0)
        {
            health -= damage;
            currentHeart += damage;
            Hearts[currentHeart].GetComponent<Animator>().Play("FadeOutHeart");
        }
        else
        {
            //Death();
        }
    }

    void Death()
    {
        Camera.main.GetComponent<CameraFollowScript>().enabled = false;
        Destroy(gameObject);

        SceneManager.LoadScene("PlaySceneTopDown");
    }

    private void ToggleWeapon(int i)
    {
        if (PlayerMovementController.PMC.canMove)
        {
            if (i == 0)
            {
                if (weaponValue > 0)
                {
                    weaponValue--;
                }
                else
                {
                    weaponValue = 1;
                }
            }
            if (i == 1)
            {
                if (weaponValue < 1)
                {
                    weaponValue++;
                }
                else
                {
                    weaponValue = 0;
                }
            }
        }
    }

    private void SetHitboxDir()
    {
        if (playerMovement.previousDirection.x == 1)
            meleeWeapon.transform.rotation = Quaternion.Euler(0, 0, -90);
        else if (playerMovement.previousDirection.x == -1)
            meleeWeapon.transform.rotation = Quaternion.Euler(0, 0, 90);
    }

    private void MeleeOne()
    {
        if (canAttack)
        {
            PlayerMovementController.PMC.canMove = false;
            PlayerMovementController.PMC.SetPlayerDownActive(false);
            canAttack = false;
            StartCoroutine(meleeAttack());
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

    private IEnumerator meleeAttack()
    {
        sideAnimator.SetTrigger("Attack");
        yield return new WaitForSeconds(0.75f);
        foreach (EnemyScript enemy in meleeWeaponHitList)
        {
            enemy.TakeDamage(10);
        }
        yield return new WaitForSeconds(0.75f);
        canAttack = true;
        PlayerMovementController.PMC.canMove = true;
    }
}
