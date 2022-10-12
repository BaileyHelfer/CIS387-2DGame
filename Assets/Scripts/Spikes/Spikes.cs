using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{  
    int coinLoss = -3;
   
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            ScoreManager.instance.ChangeScore(coinLoss);
        }
    }
    
    
}
