using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapKB : MonoBehaviour
{
    public Rigidbody2D rb;
    public float knockBack = 5f;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Traps"))
        {

            rb.velocity = new Vector3(0, 10, 0);
        }
    }
}

