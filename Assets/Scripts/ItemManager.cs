using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Sprite pcItemSprite;
    public Sprite pcItemIntroSprite;
    public Text pcItemIntroContent;

    private static int itemCount = 0;
    string introNameText;

    // Start is called before the first frame update
    void Start()
    {
        introNameText = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        SetPCItemToSlot();
        GameObject gameUI = GameObject.Find("UI");
        gameUI.GetComponent<IntroPanelController>().ShowIntroPanel(true, pcItemIntroSprite, introNameText, pcItemIntroContent);
    }

    private void SetPCItemToSlot()
    {
        itemCount++;
        // Set slot image
        Image slotImage = GameObject.Find("UI/Canvas/Slots/Slot" + itemCount).GetComponent<Image>();
        slotImage.sprite = pcItemSprite;
        // set slot image alpha to 255
        Color slotImageColor = slotImage.color;
        slotImageColor.a = 255f;
        slotImage.color = slotImageColor;
    }
}
