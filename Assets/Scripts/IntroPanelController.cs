using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroPanelController : MonoBehaviour
{
    public static bool isIntroPanelOpened = false;

    public string nextScene = "WinScene";

    GameObject introPanel;
    GameObject aimToPick;

    void Start()
    {
        introPanel = GameObject.Find("UI/Canvas/IntroPanel");
        aimToPick = GameObject.Find("UI/Canvas/AimToPick");

        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        if (isIntroPanelOpened && Input.GetKeyDown("z"))
        {
            introPanel.SetActive(false);
            // Show dot image
            Image pickImage = aimToPick.GetComponent<Image>();
            pickImage.sprite = aimToPick.GetComponent<AimImageChangeController>().yellowDot;
            pickImage.rectTransform.sizeDelta = new Vector2(5, 5);
            if(PickupController.itemCount == 4)
            {
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(nextScene);
            }
        }

        if (Input.GetKeyDown(KeyCode.O)) // O for Options!
        {
            GameObject panel = GameObject.Find("UI/Canvas/Options-Panel");
            panel.SetActive(!panel.active);
            Debug.Log("anything?");

            if (panel.active) {
                Cursor.lockState = CursorLockMode.None;
            } else {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    public void ShowIntroPanel(bool openIntroPanel, Sprite pcItemIntroSprite, string introNameText, Text pcItemIntroContent)
    {
        // Show Intro Panel
        isIntroPanelOpened = openIntroPanel;
        introPanel.SetActive(true);
        // Set intro image
        Image introImage = introPanel.transform.GetChild(0).GetComponent<Image>();
        introImage.sprite = pcItemIntroSprite;
        // Set intro heading
        Text introName = introPanel.transform.GetChild(1).GetComponent<Text>();
        introName.text = introNameText;
        // Set intro content
        Text introContent = introPanel.transform.GetChild(2).GetComponent<Text>();
        introContent.text = pcItemIntroContent.text;
    }
}
