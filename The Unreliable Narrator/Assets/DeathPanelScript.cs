﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPanelScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartLevel()
    {
        gameObject.SetActive(false);
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
