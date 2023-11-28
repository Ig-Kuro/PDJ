﻿using System;
using UnityEngine;

public class CameraRotacao : MonoBehaviour
{
     public Transform target;
     public float velo;

    public void Awake()
    {
        transform.LookAt(target);
    }

    public void Update()
    {
        transform.RotateAround(target.position, Vector3.up, velo * Time.deltaTime);
    }
}