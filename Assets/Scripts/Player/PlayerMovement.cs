using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    bool isgrounded = true;
    public float movementSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

    }

    //make sure u replace "floor" with your gameobject name.on which player is standing
    void OnCollisionEnter(Collision theCollision)
    {
        Debug.Log(theCollision.gameObject.name);
        if (theCollision.gameObject.name == "floor")
        {
            isgrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnCollisionExit(Collision theCollision)
    {
        Debug.Log(theCollision.gameObject.name);
        if (theCollision.gameObject.name == "floor")
        {
            isgrounded = false;
        }
    }
}
