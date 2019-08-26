using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public LayerMask layersToHit;

    int hp = 100;
    Rigidbody2D rigid;
    PlayerMovementController player;

    public Vector2 lastKnownPos;
    bool playerFound;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        player = GameObject.Find("PlayerControllerTopDown").GetComponent<PlayerMovementController>();
    }

    // Update is called once per frame
    void Update()
    {
        FindPlayer();
        ChasePlayer();
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
            Destroy(gameObject);
    }

    void FindPlayer()
    {
        Debug.DrawRay(transform.position, player.transform.position - transform.position, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, player.transform.position - transform.position, 10000000f, layersToHit);
        Debug.Log(hit.transform.name);

        if (hit.transform.tag == "Player")
        {
            playerFound = true;
            lastKnownPos = hit.transform.position;
        }
    }

    void ChasePlayer()
    {
        if(playerFound && Vector2.Distance(transform.position, player.transform.position) > 1.6f)
          transform.position = Vector2.MoveTowards(transform.position, lastKnownPos, 0.025f);
    }
}
