using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 startPos;

    private void Awake()
    {
        startPos = transform.position;
    }
    // Use this for initialization
    void Start()
    {
        startPos = this.transform.position;
    }
    private void Update()
    {
        if (Input.GetKey("r"))
        {
            transform.position = startPos;
            print("Position resetted");
        }
    }
}

