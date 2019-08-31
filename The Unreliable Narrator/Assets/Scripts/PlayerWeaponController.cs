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

    }

    private void Attack()
    {
        if (PlayerMovementController.PMC.canMove && PlayerMovementController.PMC.isGrounded)
        {
            MeleeOne();
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
        yield return new WaitForSeconds(0.75f);
        canAttack = true;
        PlayerMovementController.PMC.canMove = true;
    }
}

