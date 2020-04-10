﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instruction_Scene");
    }

    public void Lvl1()
    {
        SceneManager.LoadScene("Level 1");
    }
}