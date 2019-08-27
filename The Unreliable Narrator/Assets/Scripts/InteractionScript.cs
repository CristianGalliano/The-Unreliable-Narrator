using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScript : MonoBehaviour
{  
    private MasterInputSystem Controls;
    
    public string[] Text;
    public GameObject TextBubble, Popup;
    public Text TextBubbleText;
    public int currentLine, lastLine;

    [SerializeField]
    private Transform headPosition;
    private Vector3 playerPosition;


    public TextAsset thisText;
    public int startLine, endLine;

    public bool requireButtonPress;
    public bool waitForPress;
    private bool interactionPressed = false;

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

    private void Start()
    {
        
    }

    private void Update()
    {
        if (requireButtonPress && Input.GetKeyDown(KeyCode.L) && !TextBubbleManager.TBM.textBubbleActive)
        {
            TextBubbleManager.TBM.ReloadScript(thisText);
            TextBubbleManager.TBM.currentLine = startLine;
            TextBubbleManager.TBM.lastLine = endLine;
            if (playerPosition.x < headPosition.position.x)
            {
                RectTransform rt = TextBubbleManager.TBM.TextBubble.GetComponent<RectTransform>();
                rt.localScale = new Vector3(1, 1, 1);
                rt = TextBubbleManager.TBM.TextBubbleText.GetComponent<RectTransform>();
                rt.localScale = new Vector3(1, 1, 1);
            }
            else if (playerPosition.x > headPosition.position.x)
            {
                RectTransform rt = TextBubbleManager.TBM.TextBubble.GetComponent<RectTransform>();
                rt.localScale = new Vector3(-1, 1, 1);
                rt = TextBubbleManager.TBM.TextBubbleText.GetComponent<RectTransform>();
                rt.localScale = new Vector3(-1, 1, 1);
            }
            TextBubbleManager.TBM.TextBubble.transform.position = headPosition.position;
            TextBubbleManager.TBM.EnableTextBox();
            interactionPressed = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TextBubbleManager.TBM.Popup.SetActive(true);
            if (requireButtonPress)
            {
                waitForPress = true;
                return;
            }
            TextBubbleManager.TBM.ReloadScript(thisText);
            TextBubbleManager.TBM.currentLine = startLine;
            TextBubbleManager.TBM.lastLine = endLine;
            if (playerPosition.x < headPosition.position.x)
            {
                RectTransform rt = TextBubbleManager.TBM.TextBubble.GetComponent<RectTransform>();
                rt.anchorMax = new Vector2(1, 0);
                rt.anchorMin = new Vector2(1, 0);
                rt.pivot = new Vector2(1, 0);
            }
            else if (playerPosition.x > headPosition.position.x)
            {
                RectTransform rt = TextBubbleManager.TBM.TextBubble.GetComponent<RectTransform>();
                rt.anchorMax = new Vector2(0, 0);
                rt.anchorMin = new Vector2(0, 0);
                rt.pivot = new Vector2(0, 0);
            }
            TextBubbleManager.TBM.TextBubble.transform.position = headPosition.position;
            TextBubbleManager.TBM.EnableTextBox();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerPosition = collision.gameObject.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TextBubbleManager.TBM.Popup.SetActive(false);
            waitForPress = false;
        }
    }  
}
