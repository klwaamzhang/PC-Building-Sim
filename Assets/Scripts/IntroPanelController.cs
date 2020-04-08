using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroPanelController : MonoBehaviour
{
    public static bool isIntroPanelOpened = false;

    GameObject introPanel;
    
    void Start()
    {
        introPanel = GameObject.Find("UI/Canvas/IntroPanel");
    }
    
    void Update()
    {
        if (isIntroPanelOpened && Input.GetKeyDown("escape"))
        {
            introPanel.SetActive(false);
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
