using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController GC;

    public GameObject playerPrefab;
    public Transform spawnPosition;

    private void Awake()
    {
        if (GC == null)
        {
            GC = this;
        }
        else if (GC != this)
        {
            Destroy(this);
        }
    }

    void Start()
    {
        spawnPlayer();
    }

    public void spawnPlayer()
    {
        Instantiate(playerPrefab, spawnPosition.position, Quaternion.identity);
        CameraFollowScript.CFS.enabled = true;
    }
}
