using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetEndState : MonoBehaviour
{
    public bool EndState = false;
    public GameObject[] Assets;

    // Update is called once per frame
    void Update()
    {
        if(EndState)
        {
            Assets[0].SetActive(false);
            Assets[1].SetActive(true);
        }
    }
}
