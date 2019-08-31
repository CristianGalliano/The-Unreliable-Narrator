using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2EnemyCounter : MonoBehaviour
{
    public EnemyScript[] skeletons;
    public bool allskellysDead = false;

    // Start is called before the first frame update
    void Start()
    {
        skeletons = gameObject.GetComponentsInChildren<EnemyScript>();
    }

    // Update is called once per frame
    void Update()
    {
        allskellysDead = true;
        foreach (EnemyScript skelly in skeletons)
        {
            if (!skelly.Dead)
            {
                allskellysDead = false;
            }
        }
        if (allskellysDead)
        {
            PlayerMovementController.PMC.playerGameState = 2;
        }
    }


}
