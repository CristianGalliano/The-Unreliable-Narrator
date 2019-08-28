using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBubbleManager : MonoBehaviour
{
    public static TextBubbleManager TBM;

    private MasterInputSystem Controls;
    public TextAsset dialogue;
    public string[] Text;
    public GameObject TextBubble, Popup;
    public Text TextBubbleText;
    public int currentLine, lastLine;
    public bool textBubbleActive = false;
    private bool interactionPressed = false;
    public bool isTyping = false;
    public bool interuptedTyping = false;
    private float textSpeed = 0.005f;

    private void Awake()
    {
        if (TBM == null)
        {
            TBM = this;
        }
        else if (TBM != this)
        {
            Destroy(this);
        }

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

    private void Start()
    {
        if (dialogue != null)
        {
            Text = (dialogue.text.Split('\n'));
        }

        if (lastLine == 0)
        {
            lastLine = Text.Length - 1;
        }

        if (textBubbleActive)
        {
            EnableTextBox();
        }
        else
        {
            DisableTextBox();
        }
    }

    private void Update()
    {
        if (!textBubbleActive)
        {
            return;
        }


        //TextBubbleText.text = Text[currentLine];

        if (interactionPressed)
        {
            if (!isTyping)
            {
                currentLine += 1;
                if (currentLine > lastLine)
                {
                    DisableTextBox();
                    Popup.SetActive(true);
                }
                else
                {
                    StartCoroutine(textScroll(Text[currentLine]));
                }
            }
            else if(isTyping && !interuptedTyping)
            {
                interuptedTyping = true;
            }
            interactionPressed = false;
        }
    }

    public void EnableTextBox()
    {
        TextBubble.SetActive(true);
        textBubbleActive = true;
        Popup.SetActive(false);
        PlayerMovementController.PMC.canMove = false;
        StartCoroutine(textScroll(Text[currentLine]));
    }

    public void DisableTextBox()
    {
        TextBubble.SetActive(false);
        textBubbleActive = false;
        PlayerMovementController.PMC.canMove = true;
    }

    public void ReloadScript(TextAsset newText)
    {
        if (newText != null)
        {
            Text = new string[1];
            Text = (newText.text.Split('\n'));
        }
    }

    private IEnumerator textScroll(string Text)
    {
        int letter = 0;
        TextBubbleText.text = "";
        isTyping = true;
        interuptedTyping = false;
        while (isTyping && !interuptedTyping && (letter < Text.Length - 1))
        {
            TextBubbleText.text += Text[letter];
            letter +=1;
            Debug.Log(Text[letter]);
            yield return new WaitForSecondsRealtime(textSpeed);
        }
        TextBubbleText.text = Text;
        isTyping = false;
        interuptedTyping = false;
    }
}
