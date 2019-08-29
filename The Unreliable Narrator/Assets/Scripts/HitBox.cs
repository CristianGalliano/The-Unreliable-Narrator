using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public PlayerWeaponController PWC;

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.tag == "Enemy")
        {
            if(name == "MeleeWeapon1")
            {
                PWC.mw1HitList.Add(hit.GetComponent<EnemyScript>());
                Debug.Log("added");
            }
            if (name == "MeleeWeapon2")
                PWC.mw2HitList.Add(hit.GetComponent<EnemyScript>());
        }
    }

    void OnTriggerExit2D(Collider2D hit)
    {
        if (hit.tag == "Enemy")
        {
            if (name == "MeleeWeapon1")
                PWC.mw1HitList.Remove(hit.GetComponent<EnemyScript>());
            if (name == "MeleeWeapon2")
                PWC.mw2HitList.Remove(hit.GetComponent<EnemyScript>());
        }
    }
}
