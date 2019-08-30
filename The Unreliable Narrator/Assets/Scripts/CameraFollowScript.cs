using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public static CameraFollowScript CFS;

    public Transform Target;
    public float SmoothSpeed = 0.125f;
    private Vector3 PlayerOffset= new Vector3(0,2,-2);
    private Vector3 InteractedOffset = new Vector3(0, 0, -2);
    public bool isInteracted = false;
    public GameObject InteractedTargetPosition;
    public bool isLeft = false;

    private void Awake()
    {
        if (CFS == null)
        {
            CFS = this;
        }
        else if (CFS != this)
        {
            Destroy(this);
        }
    }

    private void LateUpdate()
    {
        if (!isInteracted)
        {
            transform.position = Vector3.Lerp(transform.position, (Target.position + PlayerOffset), SmoothSpeed);
        }
        else if (isInteracted)
        {          
            transform.position = Vector3.Lerp(transform.position, (new Vector3(InteractedTargetPosition.transform.position.x, InteractedTargetPosition.transform.position.y + 5, InteractedTargetPosition.transform.position.z) + InteractedOffset), SmoothSpeed/2);
            if (!isLeft)
            {
                Vector3 targetPos = InteractedTargetPosition.gameObject.GetComponent<InteractionScript>().headPosition.position;
                TextBubbleManager.TBM.TextBubble.transform.position = new Vector3(targetPos.x + 1.5f, targetPos.y, targetPos.z);
            }
            else if (isLeft)
            {
                Vector3 targetPos = InteractedTargetPosition.gameObject.GetComponent<InteractionScript>().headPosition.position;
                TextBubbleManager.TBM.TextBubble.transform.position = new Vector3(targetPos.x - 1.5f, targetPos.y, targetPos.z);
            }
        }
    }
}
