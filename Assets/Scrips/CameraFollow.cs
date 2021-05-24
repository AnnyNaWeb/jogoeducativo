﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed;
    public Vector3 offset;
    void Start () {

    }

    void Update () {

    }
    void LateUpdate () {
        Vector3 desiredPos = target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp (transform.position, desiredPos, smoothSpeed);
        transform.position = smoothedPos;
        transform.LookAt (target);
    }
}