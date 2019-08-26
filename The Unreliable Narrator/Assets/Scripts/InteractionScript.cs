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

    public bool isTyping = false;
    public bool interuptedTyping = false;
    private float textSpeed = 0.025f;

    private void Awake()
    {
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
                Popup.gameObject.SetActive(true);
            }
            if (interactionPressed && textBubbleActive == false)
            {
                if (!isTyping && !interuptedTyping)
                {
                    Popup.gameObject.SetActive(false);
                    textBubbleActive = true;
                    TextBubble.transform.position = HeadPosition.transform.position;
                    TextBubble.gameObject.SetActive(true);
                    StartCoroutine(textScroll(Text[textNumber]));
                    interactionPressed = false;
                    PlayerMovementController.PMC.canMove = false;
                }
                else if (isTyping && !interuptedTyping)
                {
                    interuptedTyping = true;
                }
            }
            else if (interactionPressed && textBubbleActive == true && textNumber < Text.Length - 1)
            {
                if (!isTyping && !interuptedTyping)
                {
                    textNumber++;
                    interactionPressed = false;
                    StartCoroutine(textScroll(Text[textNumber]));
                }
                else if (isTyping && !interuptedTyping)
                {
                    interuptedTyping = true;
                }
            }
            else if(interactionPressed && textNumber +1 == Text.Length)
            {
                Popup.gameObject.SetActive(true);
                textBubbleActive = false;
                TextBubble.gameObject.SetActive(false);
                textNumber = 0;
                interactionPressed = false;
                PlayerMovementController.PMC.canMove = true;
            }
        }
    }

    private IEnumerator textScroll(string Text)
    {
        int letter = 0;
        TextBubbleText.text = "";
        isTyping = true;
        interuptedTyping = false;
        while (isTyping && !interuptedTyping && letter < (Text.Length -1))
        {
            TextBubbleText.text += Text[letter];
            letter++;
            Debug.Log("returning");
            yield return new WaitForSeconds(textSpeed);
        }
        TextBubbleText.text = Text;
        isTyping = false;
        interuptedTyping = false;
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
