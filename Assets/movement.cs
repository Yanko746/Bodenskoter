using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKey(KeyCode.W))
        {
            speed = 5;
        rb.velocity = speed*transform.up;
           
        }

        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(new Vector3(0, 0, 0.1f));
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(new Vector3(0, 0, -0.1f));
        }
    }
}
