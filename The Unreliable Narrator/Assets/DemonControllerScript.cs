using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonControllerScript : MonoBehaviour
{
    [SerializeField]
    private InteractionScript thisInteractScript;
    [SerializeField]
    private Animator thisAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (thisInteractScript.DownFacing.activeSelf)
        {
            thisAnimator.SetBool("isFacingDown", true);
        }
        else if (thisInteractScript.leftFacing.activeSelf)
        {
            thisAnimator.SetBool("isFacingDown", false);
        }
    }
}
