using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstLoadsSceneManager : MonoBehaviour
{
    private MasterInputSystem Controls;
    private AsyncOperation asyncLoad;
    public bool activated = false, showButton = false;
    [SerializeField]
    private GameObject buttonToSkip;

    private void Awake()
    {
        Controls = new MasterInputSystem();
        Controls.Player.Interact.performed += Context => activatedButtonPressed();
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
        StartCoroutine(loadSceneAsync());
        StartCoroutine(textLoadIsFinished());
    }

    // Update is called once per frame
    void Update()
    {
        if (asyncLoad.progress == 0.9f && showButton)
        {
            buttonToSkip.SetActive(true);
        }
    }

    private IEnumerator loadSceneAsync()
    {
        asyncLoad = SceneManager.LoadSceneAsync(2);
        asyncLoad.allowSceneActivation = false;
       while(!activated)
        {
            yield return null;
            Debug.Log("nor finished and not activated");
        }
        asyncLoad.allowSceneActivation = true;
        Debug.Log("should be switching scene now");
        yield return asyncLoad;
    }

    public void activatedButtonPressed()
    {
        if (buttonToSkip.activeSelf)
        {
            activated = true;
        }   
    }

    private IEnumerator textLoadIsFinished()
    {
        yield return new WaitForSeconds(5f);
        showButton = true;
    }
}
