using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectileScript : MonoBehaviour
{
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
        if (hit.tag != "Player")
        {
            Destroy(gameObject, 0.01f);
        }

        if(hit.tag == "Enemy")
        {
            hit.GetComponent<EnemyScript>().TakeDamage(100);
            Destroy(gameObject, 0.01f);
        }
    }
}
