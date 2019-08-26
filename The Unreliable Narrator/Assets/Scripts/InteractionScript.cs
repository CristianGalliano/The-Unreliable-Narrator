using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScript : MonoBehaviour
{
    private MasterInputSystem Controls;

    public Image TextBubble,Popup;
    public Text TextBubbleText;
    public Transform HeadPosition, playerHeadPosition;
    public string[] Text;
    private int textNumber = 0;
    private bool popupFollow = false, textBubbleActive = false;

    private bool interactionPressed = false;

    private void Awake()
    {
        Physics2D.IgnoreLayerCollision(10, 11);
        Controls = new MasterInputSystem();
        Controls.Player.Interact.performed += Context => interactionPressed = true;
    }

    private void OnEnable()
    {
        Controls.Enable();
    }

    private void OnDisable()
    {
        Controls.Disable();
    }



    // Update is called once per frame
    void Update()
    {
        if (popupFollow == true)
        {
            if (textBubbleActive == false)
            {
                //Popup.transform.position = Vector2.Lerp(Popup.transform.position, playerHeadPosition.transform.position, Time.deltaTime);
                Popup.gameObject.SetActive(true);
            }
            if (interactionPressed && textBubbleActive == false)
            {
                Popup.gameObject.SetActive(false);
                textBubbleActive = true;
                TextBubble.gameObject.SetActive(true);
                TextBubble.transform.position = HeadPosition.transform.position;
                TextBubbleText.text = Text[textNumber];
                interactionPressed = false;
            }
            else if (interactionPressed && textBubbleActive == true && textNumber < Text.Length - 1)
            {
                textNumber++;
                TextBubbleText.text = Text[textNumber];
                interactionPressed = false;
            }
            else if(interactionPressed && textNumber +1 == Text.Length)
            {
                Popup.gameObject.SetActive(true);
                textBubbleActive = false;
                TextBubble.gameObject.SetActive(false);
                textNumber = 0;
                interactionPressed = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            popupFollow = true;          
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            interactionPressed = false;
            textBubbleActive = false;
            TextBubble.gameObject.SetActive(false);
            Popup.gameObject.SetActive(false);
            popupFollow = false;
            textNumber = 0;
        }
    }
}
