using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Hp_Camera : MonoBehaviour
{
    private Camera cameraToLookAt;

    void Start()
    {
        cameraToLookAt = Camera.main;
    }

    void Update()
    {
        Vector3 v = cameraToLookAt.transform.position - transform.position;
        v.x = v.z = 0;
        transform.LookAt(cameraToLookAt.transform.position - v);
    }
}
