using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Text healthAmountText;
    private int healthAmount = 80;
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
        if (this.healthAmount < 100)
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
    }
}
