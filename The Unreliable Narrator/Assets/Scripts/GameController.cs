using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float Score = 0;
    public float Multiplier = 1;
    private float lastPointTime, lastDecayTime;

    void Start()
    {

    }

    void Update()
    {
        MultiplierDecay();
    }

    public void AddScore(int points)
    {
        Score += points * (int)Multiplier;
        Multiplier += 0.05f;
        lastPointTime = Time.time;
    }

    void MultiplierDecay()
    {
        if (Time.time > lastPointTime + 5f)
        {
            if (Time.time > lastDecayTime + 1f && Multiplier >= 1)
            {
                lastDecayTime = Time.time;
                Multiplier--;
            }
        }
    }
}
