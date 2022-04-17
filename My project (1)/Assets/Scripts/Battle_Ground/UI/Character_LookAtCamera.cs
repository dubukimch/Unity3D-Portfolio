using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_LookAtCamera : MonoBehaviour
{
    Transform target;
    private Transform tr;
    private Camera cameraToLookAt;

    public GameObject Character_Target;


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
            target = Character_Target.transform;
            transform.LookAt(transform.position + cameraToLookAt.transform.rotation * Vector3.back,
         cameraToLookAt.transform.rotation * Vector3.down);

            tr.position = new Vector3(target.position.x - 0.0f, target.position.y + 3.0f, target.position.z - 0.0f);

        }
        catch (NullReferenceException ex)
        {

        }

    }
}
