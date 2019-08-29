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

            PWC.meleeWeaponHitList.Add(hit.GetComponent<EnemyScript>());
            Debug.Log("added");
        }
    }

    void OnTriggerExit2D(Collider2D hit)
    {
        if (hit.tag == "Enemy")
        {
            PWC.meleeWeaponHitList.Remove(hit.GetComponent<EnemyScript>());
        }
    }
}
