using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_movement : MonoBehaviour
{

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(1, 0, 0, ForceMode.Impulse);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-1, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, -1, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, 1, ForceMode.Impulse);

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(0, 0, 1, ForceMode.Impulse);

            }
        }
    }


    void OnCollisionEnter(Collision collisionreport) {
        Debug.Log("collision at " + collisionreport.transform.position);
        Destroy(collisionreport.gameObject);

    }

}