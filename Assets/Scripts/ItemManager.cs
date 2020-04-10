using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Sprite pcItemSprite;
    public Sprite pcItemIntroSprite;
    public Text pcItemIntroContent;
    GameObject aimToPick;
    public GameObject score_Controller;
    public int addScore = 150;

    void Start()
    {
        aimToPick = GameObject.Find("UI/Canvas/AimToPick");
    }

    void OnMouseOver()
    {
        Debug.Log("Mouse is over GameObject.");
        // Show hand image when the mouse hover
        Image pickImage = aimToPick.GetComponent<Image>();
        pickImage.sprite = aimToPick.GetComponent<AimImageChangeController>().pickingHand;
        pickImage.rectTransform.sizeDelta = new Vector2(70, 70);
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
        // Show dot image when the mouse leave
        Image pickImage = aimToPick.GetComponent<Image>();
        pickImage.sprite = aimToPick.GetComponent<AimImageChangeController>().yellowDot;
        pickImage.rectTransform.sizeDelta = new Vector2(5, 5);
    }

    private void OnDisable()
    {
        //Add Score
        score_Controller.GetComponent<Score_Controller>().IncreaseScore(addScore);
    }

}
