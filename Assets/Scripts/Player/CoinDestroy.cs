using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinDestroy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
             Destroy(other.gameObject);
         
        }
    }
}


