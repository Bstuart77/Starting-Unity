using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform playerTransform;
    private Vector3 cameraSet;


    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.5f;

    // Use this for initialization
    void Start()
    {
        cameraSet = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = playerTransform.position + cameraSet;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
    }
}
