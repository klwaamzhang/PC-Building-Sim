using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Controller : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    void Start()
    {
        
    }

    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void IncreaseScore(int addScore)
    {
            score += addScore;
            Debug.Log(addScore);
    }

}
