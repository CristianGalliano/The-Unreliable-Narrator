using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] private Text scoreText, multiplierText;
    [SerializeField] private GameController Game;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            Game.AddScore(1);
        }

        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = Game.Score.ToString();
        multiplierText.text = "x" + ((int)Game.Multiplier).ToString();
    }

}
