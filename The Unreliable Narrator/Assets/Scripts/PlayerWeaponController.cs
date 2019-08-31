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
    public Transform spawnpoint;

    //Stats
    public int health = 5;
    public GameObject[] Hearts;
    int currentHeart = -1;

    //Combat
    public BoxCollider2D meleeWeapon;
    public List<EnemyScript> meleeWeaponHitList;
    public BossScript boss;
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
    public GameObject DeathScreen;

    public Animator sideAnimator;

    public GameObject[] weapons;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        Controls.Player.Attack.performed += Context => Attack();
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
        if (health == 0)
        {
            Death();
        }
    }

    private void Attack()
    {
        if (PlayerMovementController.PMC.canMove && PlayerMovementController.PMC.isGrounded)
        {
            MeleeOne();
        }
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
            health -= 1;
            currentHeart += 1;
            Hearts[currentHeart].GetComponent<Animator>().Play("FadeOutHeart");
        }
    }

    private void Reset()
    {
        health = 5;
        foreach (GameObject heart in Hearts)
        {
            heart.SetActive(true);
            heart.GetComponent<Animator>().Play("FadeInHeart");
            currentHeart = -1;
        }
    }

    void Death()
    {
        DeathScreen.SetActive(true);
        Reset();
        transform.position = spawnpoint.position;
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

    private IEnumerator meleeAttack()
    {
        sideAnimator.SetTrigger("Attack");
        yield return new WaitForSeconds(0.75f);
        foreach (EnemyScript enemy in meleeWeaponHitList)
        {
            enemy.TakeDamage(10);
        }
        if (boss)
            boss.TakeDamage(10);

        yield return new WaitForSeconds(0.75f);
        canAttack = true;
        PlayerMovementController.PMC.canMove = true;
    }
}

