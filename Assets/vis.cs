using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public float smoothTime = 0.3f; 
    public Vector3 offset; 

    private Vector3 velocity = Vector3.zero;
    void Start()
    {
       
        target = GameObject.Find("player").transform;
    }
    void Update()
    {

        Vector3 targetPosition = target.TransformPoint(offset);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
