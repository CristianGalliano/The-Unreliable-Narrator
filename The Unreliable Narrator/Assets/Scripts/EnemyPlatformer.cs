using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlatformer : MonoBehaviour
{
    public int hp = 100;
    public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        Debug.Log("hit");
        if (hit.tag == "PlayerProjectile")
        {
            TakeDamage();
            KnockBack(hit);
            Destroy(hit.gameObject, 0.05f);
        }
    }

    void TakeDamage()
    {
        hp -= 10;
        if (hp <= 0)
            Destroy(gameObject);
    }

    void KnockBack(Collider2D player)
    {
        if (player.transform.position.x > transform.position.x)
            rigid.AddForce(new Vector2(-100,100));
        else if (player.transform.position.x < transform.position.x)
            rigid.AddForce(new Vector2(100, 100));
    }
}
