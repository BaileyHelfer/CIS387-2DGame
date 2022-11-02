using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinDestroy : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            source.PlayOneShot(clip);
             Destroy(other.gameObject);
        }
    }
}


