using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0, -5);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0, 5);
        }


        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(new Vector3(0, 0, 0.1f));
        }

    }
}
