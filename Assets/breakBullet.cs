using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            Destroy(other.gameObject);

        }
    }
}