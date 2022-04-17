using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookAtCamera : MonoBehaviour
{

    Transform target;
    private Transform tr;
    private Camera cameraToLookAt;



    public Image Player_Hp;
    public Image Player_Mp;
    public Image Player_EXP;
    public Text Player_Level_Text;


    void Start()
    {
        tr = GetComponent<Transform>();
        cameraToLookAt = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    void Update()
    {
        Player_UI_Status();
        Find_Player();
    }
    void Find_Player()
    {
        try
        {
            target = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).transform;
            transform.LookAt(transform.position + cameraToLookAt.transform.rotation * Vector3.back,
         cameraToLookAt.transform.rotation * Vector3.down);

            tr.position = new Vector3(target.position.x - 0.52f, target.position.y + 10.0f, target.position.z - 5.0f);

        }
        catch (NullReferenceException ex)
        {
            
        }

    }

    void Player_UI_Status()
    {
        Player_Hp.fillAmount = Enemy_Player_UI_Manager.Instance.Our_Player_Hp;
        Player_Mp.fillAmount = Enemy_Player_UI_Manager.Instance.Our_Player_Mp;
        Player_EXP.fillAmount = Enemy_Player_UI_Manager.Instance.Our_Player_Exp;
        Player_Level_Text.text = "" + Enemy_Player_UI_Manager.Instance.Our_Player_Level;

    }



}
