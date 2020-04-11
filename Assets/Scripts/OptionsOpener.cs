using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsOpener : MonoBehaviour
{
    public GameObject optionsPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O)) // O for Options!
{
            optionsPanel.SetActive(!optionsPanel.active);
            Debug.Log("anything?");
        }
    }
}
