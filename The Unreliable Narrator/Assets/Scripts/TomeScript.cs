using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomeScript : MonoBehaviour
{

    private MasterInputSystem Controls;
    public bool Interacted = false;
    bool inrange = false;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        Controls.Player.Interact.performed += Context => Interacted = true;
        Controls.Player.Interact.canceled += Context => Interacted = false;
    }

    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Interacted == true && inrange)
        {
            Debug.Log("youve interacted");
            PlayerMovementController.PMC.playerGameState = 1;
            TextBubbleManager.TBM.Popup.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            TextBubbleManager.TBM.Popup.SetActive(true);
            inrange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player" && TextBubbleManager.TBM.Popup.activeSelf)
        {
            TextBubbleManager.TBM.Popup.SetActive(false);
            inrange = false;
        }
    }
}
