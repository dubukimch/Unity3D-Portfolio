using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Top_Player_UI : MonoBehaviour
{

    Transform target;
    private Transform tr;
    private Camera cameraToLookAt;

    void Start()
    {
        tr = GetComponent<Transform>();
        cameraToLookAt = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    void Update()
    {
        Find_Player();
    }
    void Find_Player()
    {
        try
        {
            target = GameObject.FindWithTag("Enemy_Top").transform;
            transform.LookAt(transform.position + cameraToLookAt.transform.rotation * Vector3.back,
            cameraToLookAt.transform.rotation * Vector3.down);
        }
        catch (NullReferenceException ex)
        {
        }

    }



}
