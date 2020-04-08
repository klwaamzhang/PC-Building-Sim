using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int addAmount = 20;
    public GameObject healthController;
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
        if (other.tag == "Player") 
            healthController.GetComponent<HealthController>().AddHealth(addAmount);
        Destroy(gameObject);
    }
}
