using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonAim : MonoBehaviour
{
    public float shootingPower = 1000f;
    public float moveSpeed = 5f;
    

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 mousePos;


    // Update is called once per frame
    void Update()
    {

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


        if (Input.GetButtonDown("Fire1"))
        {
            rb.AddForce(-transform.up * shootingPower);
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(-transform.up * shootingPower);
        }

    }

    void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}