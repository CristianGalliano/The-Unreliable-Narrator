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
            EnemyScript temp = hit.GetComponent<EnemyScript>();

            if(!temp.Dead && !PWC.meleeWeaponHitList.Contains(temp))
            {
                PWC.meleeWeaponHitList.Add(temp);
            }
        }
    }

    void OnTriggerExit2D(Collider2D hit)
    {
        if (hit.tag == "Enemy")
        {
            EnemyScript temp = hit.GetComponent<EnemyScript>();

            if (PWC.meleeWeaponHitList.Contains(temp))
            {
                PWC.meleeWeaponHitList.Remove(temp);
            }
        }
    }
}
