using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position.x);
        if (transform.position.x <= -10)
        {
            transform.position = new Vector3(-10, transform.position.y, 0);
        }
    }
}
