using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int health = 3;
    public GameObject Player;
    public GameObject Camera;

    public GameObject[] Hearts;

    int currentHeart = -1;

    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        Camera = GameObject.Find("Main Camera");
    }

    void Update()
    {
        
    }

    
    public void OnDamage(int damage)
    {
        if (health > 0)
        {
            health -= damage;
            currentHeart += damage;
            Hearts[currentHeart].SetActive(false);
        }

    }



    void OnDeath()
    {
        Camera.GetComponent<CameraFollowScript>().enabled = false;
        Destroy(Player.gameObject);
    }
}
