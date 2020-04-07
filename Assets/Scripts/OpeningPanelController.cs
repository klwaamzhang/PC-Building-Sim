using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningPanelController : MonoBehaviour
{
    public static bool isOpeningPanelOpened = true;
    GameObject openingPanel;
    // Start is called before the first frame update
    void Start()
    {
        openingPanel = GameObject.Find("UI/Canvas/OpeningPanel");
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpeningPanelOpened && Input.GetKeyDown(KeyCode.Return))
        {
            isOpeningPanelOpened = false;
            openingPanel.SetActive(false);
        }
    }
}
