using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item_Storage_Control : MonoBehaviour
{
    public Image Poshion_Hp;
    public Image Poshion_Mp;
    public Image Poshion_Exp;

    public Image Item_Content;
    void Update()
    {
        Item_Storage_Image();
    }

    void Item_Storage_Image()
    {
        Color color = Item_Content.GetComponent<Image>().color;
        if (Battle_Player_UI_Manager.Instance.Poshin_Hp_Get_Value == true)
        {
            color.a = 1f;
            Item_Content.GetComponent<Image>().sprite = Poshion_Hp.GetComponent<Image>().sprite;
            Battle_Player_UI_Manager.Instance.Poshin_Mp_Get_Value = false;
            Battle_Player_UI_Manager.Instance.Poshin_Exp_Get_Value = false;


        }
        else if (Battle_Player_UI_Manager.Instance.Item_Storage_Empty 
            == false && Battle_Player_UI_Manager.Instance.Poshin_Hp_Get_Value == false)
        {

            color.a = 0f;
            Item_Content.GetComponent<Image>().sprite = null;
        }
        if (Battle_Player_UI_Manager.Instance.Poshin_Mp_Get_Value == true)
        {

            color.a = 1f;
            Item_Content.GetComponent<Image>().sprite = Poshion_Mp.GetComponent<Image>().sprite;
            Battle_Player_UI_Manager.Instance.Poshin_Hp_Get_Value = false;

            Battle_Player_UI_Manager.Instance.Poshin_Exp_Get_Value = false;
        }
        else if (Battle_Player_UI_Manager.Instance.Item_Storage_Empty 
            == false && Battle_Player_UI_Manager.Instance.Poshin_Mp_Get_Value == false)
        {
            color.a = 0f;
            Item_Content.GetComponent<Image>().sprite = null;
        }
        if (Battle_Player_UI_Manager.Instance.Poshin_Exp_Get_Value == true)
        {

            color.a = 1f;
            Item_Content.GetComponent<Image>().sprite = Poshion_Hp.GetComponent<Image>().sprite;
            Battle_Player_UI_Manager.Instance.Poshin_Hp_Get_Value = false;
            Battle_Player_UI_Manager.Instance.Poshin_Mp_Get_Value = false;

        }
        else if (Battle_Player_UI_Manager.Instance.Item_Storage_Empty 
            == false && Battle_Player_UI_Manager.Instance.Poshin_Exp_Get_Value == false)
        {
            color.a = 0f;
            Item_Content.GetComponent<Image>().sprite = null;
        }
        Item_Content.GetComponent<Image>().color = color;

    }

    public void Item_Storage_Image_Click()
    {
        if (Battle_Player_UI_Manager.Instance.Poshin_Hp_Get_Value == true)
        {
            Battle_Player_UI_Manager.Instance.Poshin_Hp_Use_Value = true;
            Battle_Player_UI_Manager.Instance.Poshin_Hp_Get_Value = false;
        }
        else if (Battle_Player_UI_Manager.Instance.Poshin_Mp_Get_Value == true)
        {
            Battle_Player_UI_Manager.Instance.Poshin_Mp_Use_Value = true;
            Battle_Player_UI_Manager.Instance.Poshin_Mp_Get_Value = false;
        }
        else if (Battle_Player_UI_Manager.Instance.Poshin_Exp_Get_Value == true)
        {
            Battle_Player_UI_Manager.Instance.Poshin_Exp_Use_Value = true;
            Battle_Player_UI_Manager.Instance.Poshin_Exp_Get_Value = false;
        }
    }
}
