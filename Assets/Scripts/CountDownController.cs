using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDownController : MonoBehaviour
{
    public float timeLeft = 60f;

    GameObject openingPanel;
    GameObject introPanel;
    GameObject countDownNum;

    void Start()
    {
        openingPanel = GameObject.Find("UI/Canvas/OpeningPanel");
        introPanel = GameObject.Find("UI/Canvas/IntroPanel");
        countDownNum = GameObject.Find("UI/Canvas/CountDownNum");
        countDownNum.GetComponent<Text>().text = timeLeft.ToString();
    }

    void Update()
    {
        // stop the counter when the openingPanel and introPanel are opened
        if (!openingPanel.activeSelf && !introPanel.activeSelf)
        {
            timeLeft -= Time.deltaTime;
            countDownNum.GetComponent<Text>().text = Mathf.Floor(timeLeft).ToString();
            if(timeLeft <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
