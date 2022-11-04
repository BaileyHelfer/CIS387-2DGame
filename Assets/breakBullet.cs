using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakBullet : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    private void OnTriggerEnter2D(Collider2D other)
    {
        source.PlayOneShot(clip);
        if (other.gameObject.CompareTag("bullet"))
        {
            Destroy(other.gameObject);
           
        }
    }
}
