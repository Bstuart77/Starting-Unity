using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{ 
    public bool onGround;
    private Rigidbody rb;

    void start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (onGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 400);

                onGround = false;
            }
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.CompareTag("Ground");
        onGround = true;
    }
}
