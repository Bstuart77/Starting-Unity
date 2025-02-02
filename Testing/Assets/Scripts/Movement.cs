﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public int points = 0;
    public float moveSpeed;

    // Use this for initialization
    void Start()
    {
        moveSpeed = 15f;
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 200), "Score: " + points);
    }
}
