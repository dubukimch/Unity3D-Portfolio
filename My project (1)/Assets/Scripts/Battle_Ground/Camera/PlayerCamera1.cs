using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCamera1 : MonoBehaviour
{
    Transform target;
    private Transform tr;




    private void Start()
    {
        tr = GetComponent<Transform>();

    }

    private void LateUpdate()
    {
        Find_Player();
        
    }


    void Find_Player()
    {
        try
        {
            target = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).transform;
            tr.position = new Vector3(target.position.x - 0.52f, target.position.y + 20.0f, target.position.z - 10.0f);
            tr.LookAt(target);
        }
        catch(NullReferenceException ex)
        {
        }

    }



}
