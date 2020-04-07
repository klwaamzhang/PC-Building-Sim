using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Sprite pcItemSprite;

    private static int itemCount = 0;
    Image slotImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        itemCount++;
        slotImage = GameObject.Find("InventoryUI/Canvas/Slots/Slot" + itemCount).GetComponent<Image>();
        slotImage.sprite = pcItemSprite;
        Color slotImageColor = slotImage.color;
        slotImageColor.a = 255f;
        slotImage.color = slotImageColor;
        gameObject.SetActive(false);
    }

}
