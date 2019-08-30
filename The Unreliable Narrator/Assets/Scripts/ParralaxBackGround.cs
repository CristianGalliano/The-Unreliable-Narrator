using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParralaxBackGround : MonoBehaviour
{
    private float ImageWidth, StartPosition;
    public float ParrallaxAmount;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position.x;
        ImageWidth = 40.95f;           
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (CameraFollowScript.CFS.gameObject.transform.position.x * (1 - ParrallaxAmount));
        float distance = (CameraFollowScript.CFS.gameObject.transform.position.x * ParrallaxAmount);
        transform.position = new Vector3(StartPosition + distance, transform.position.y, transform.position.z);
        if (temp > StartPosition + ImageWidth)
        {
            StartPosition += ImageWidth;
        }
        else if (temp < StartPosition - ImageWidth)
        {
            StartPosition -= ImageWidth;
        }
    }

    private void Update()
    {

    }
}
