﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionScript : MonoBehaviour
{  
    private MasterInputSystem Controls;   

    public Transform headPosition;
    private Vector3 playerPosition;
    public TextAsset thisText;
    public int startLine, endLine;

    public bool requireButtonPress;
    public bool waitForPress;
    private bool interactionPressed = false;
    private bool playerInRange = false;

    public GameObject[] tiledLevels;

    public GameObject leftFacing, DownFacing;

    private bool canDisappear = false;

    private Animator thisAnimator;

    public GameObject[] skellySprites;
    public GameObject[] deadFriendsSprites;

    public GameObject[] housesSprites;
    public GameObject[] bloodiedSprites;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        Controls.Player.Interact.performed += Context => interactionPressed = true;
        Controls.Player.Interact.canceled += Context => interactionPressed = false;
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
        thisAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (PlayerMovementController.PMC.playerGameState == 0)
        {
            startLine = 0;
            endLine = 15;
        }
        else if (PlayerMovementController.PMC.playerGameState == 1)
        {
            startLine = 17;
            endLine = 32;

        }
        else if (PlayerMovementController.PMC.playerGameState == 2)
        {
            startLine = 34;
            endLine = 50;
        }
        else if (PlayerMovementController.PMC.playerGameState == 3)
        {
            startLine = 52;
            endLine = 67;
        }
        if (requireButtonPress && interactionPressed && !TextBubbleManager.TBM.textBubbleActive && playerInRange && PlayerMovementController.PMC.isGrounded)
        {
            if(PlayerMovementController.PMC.playerGameState == 0)
            {
                tiledLevels[0].SetActive(true);
            }
            else if (PlayerMovementController.PMC.playerGameState == 1)
            {
                tiledLevels[0].SetActive(false);
                tiledLevels[1].SetActive(true);
            }
            else if (PlayerMovementController.PMC.playerGameState == 2)
            {
                tiledLevels[1].SetActive(false);
                tiledLevels[2].SetActive(true);
            }
            else if (PlayerMovementController.PMC.playerGameState == 3)
            {
                tiledLevels[2].SetActive(false);
            }
            TextBubbleManager.TBM.ReloadScript(thisText);
            TextBubbleManager.TBM.currentLine = startLine;
            TextBubbleManager.TBM.lastLine = endLine;
            CameraFollowScript.CFS.InteractedTargetPosition = gameObject;
            CameraFollowScript.CFS.isInteracted = true;
            if (playerPosition.x < headPosition.position.x)
            {
                RectTransform rt = TextBubbleManager.TBM.TextBubble.GetComponent<RectTransform>();
                rt.localScale = new Vector3(1, 1, 1);
                rt = TextBubbleManager.TBM.TextBubbleText.GetComponent<RectTransform>();
                rt.localScale = new Vector3(1, 1, 1);
                transform.localScale = new Vector3(0.2f, transform.localScale.y, transform.localScale.z);
                TextBubbleManager.TBM.TextBubble.transform.position = new Vector3(-1.5f, headPosition.position.y, headPosition.position.z);
                CameraFollowScript.CFS.isLeft = true;
            }
            else if (playerPosition.x > headPosition.position.x)
            {
                RectTransform rt = TextBubbleManager.TBM.TextBubble.GetComponent<RectTransform>();
                rt.localScale = new Vector3(-1, 1, 1);
                rt = TextBubbleManager.TBM.TextBubbleText.GetComponent<RectTransform>();
                rt.localScale = new Vector3(-1, 1, 1);
                transform.localScale = new Vector3(-0.2f, transform.localScale.y, transform.localScale.z);
                TextBubbleManager.TBM.TextBubble.transform.position = new Vector3(1.5f, headPosition.position.y, headPosition.position.z);
                CameraFollowScript.CFS.isLeft = false;
            }
            leftFacing.SetActive(true);
            DownFacing.SetActive(false);
            TextBubbleManager.TBM.EnableTextBox();
            if (PlayerMovementController.PMC.playerGameState == 3)
            {
                canDisappear = true;
            }
        }
        interactionPressed = false;
        if (!TextBubbleManager.TBM.textBubbleActive)
        {

            leftFacing.SetActive(false);
            DownFacing.SetActive(true);
            if (canDisappear)
            {
                StartCoroutine(destroyWhenFinished());
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerInRange = true;
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
            if (PlayerMovementController.PMC.isGrounded && !TextBubbleManager.TBM.textBubbleActive)
            {
                TextBubbleManager.TBM.Popup.SetActive(true);
            }
            else
            {
                TextBubbleManager.TBM.Popup.SetActive(false);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playerInRange = false;
            TextBubbleManager.TBM.Popup.SetActive(false);
            waitForPress = false;
        }
    }

    private IEnumerator destroyWhenFinished()
    {
        thisAnimator.Play("DemonFadeAway");
        foreach (GameObject skelly in skellySprites)
        {
            skelly.SetActive(false);
        }
        foreach (GameObject friend in deadFriendsSprites)
        {
            friend.SetActive(true);
        }
        foreach (GameObject house in housesSprites)
        {
            house.SetActive(false);
        }
        foreach (GameObject house in bloodiedSprites)
        {
            house.SetActive(true);
        }
        yield return new WaitForSecondsRealtime(0.5f);
        Destroy(gameObject);
    }
}
