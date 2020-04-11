using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Text healthAmountText;
    public int healthAmount = 80;

    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthAmountText.text = healthAmount.ToString();
    }

    public void AddHealth(int amount)
    {
        if (healthAmount < 100)
        {
            healthAmount += amount;
            Debug.Log(amount);
        }
    }

    public void RemoveHealth(int amount)
    {
        if (healthAmount > 0)
        {
            healthAmount -= amount;
        }

        if (healthAmount == 0)
        {
            SceneManager.LoadScene("DeathScene");
        }
    }

    public void GameOver()
    {
        
    }
}
