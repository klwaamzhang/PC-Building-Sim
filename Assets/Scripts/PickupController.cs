using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupController : MonoBehaviour
{
    public static int itemCount = 0;

    Sprite pcItemSprite;
    Sprite pcItemIntroSprite;
    Text pcItemIntroContent;
    string introNameText;

    // Start is called before the first frame update
    void Start()
    {
        itemCount = 0;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse is down");

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "PCItem")
                {
                    Debug.Log("It's working!");
                    // get all info from the item the player hit
                    introNameText = hitInfo.transform.gameObject.name;
                    pcItemSprite = hitInfo.transform.gameObject.GetComponent<ItemManager>().pcItemSprite;
                    pcItemIntroSprite = hitInfo.transform.gameObject.GetComponent<ItemManager>().pcItemIntroSprite;
                    pcItemIntroContent = hitInfo.transform.gameObject.GetComponent<ItemManager>().pcItemIntroContent;
                    // Show IntroPanel
                    GameObject gameUI = GameObject.Find("UI");
                    gameUI.GetComponent<IntroPanelController>().ShowIntroPanel(true, pcItemIntroSprite, introNameText, pcItemIntroContent);
                    hitInfo.transform.gameObject.SetActive(false);
                    // Set Item to Slot
                    SetPCItemToSlot();
                }
                else
                {
                    Debug.Log("nopz");
                }
            }
            else
            {
                Debug.Log("No hit");
            }
        }
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
