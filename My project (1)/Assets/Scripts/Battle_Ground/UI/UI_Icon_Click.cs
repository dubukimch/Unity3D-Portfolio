using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Icon_Click : MonoBehaviour
{

    
    public void Skill_OnClick()
    {
        for (int i = 1; i < 5; i++)
        {
                if ((gameObject.name == "Player_Skill(" + i + ")")&&( Enemy_Player_UI_Manager.Instance.Our_Player_Coin_Value >= Player_Status.Instance.Player_Status_Cost_Values[i-1]))
                {
                if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_UnityChan(Clone)")
                {
                    Enemy_Player_UI_Manager.Instance.Our_UnityChan_Coin_Value = Enemy_Player_UI_Manager.Instance.Our_UnityChan_Coin_Value - Player_Status.Instance.Player_Status_Cost_Values[i - 1];
                }

                else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_PBRCharacter(Clone)")
                {
                    Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Coin_Value = Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Coin_Value - Player_Status.Instance.Player_Status_Cost_Values[i - 1];

                }
                else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Satomi(Clone)")
                {
                    Enemy_Player_UI_Manager.Instance.Our_Satomi_Coin_Value = Enemy_Player_UI_Manager.Instance.Our_Satomi_Coin_Value - Player_Status.Instance.Player_Status_Cost_Values[i - 1];

                }
                else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Arisa(Clone)")
                {
                   
                    Enemy_Player_UI_Manager.Instance.Our_Arisa_Coin_Value = Enemy_Player_UI_Manager.Instance.Our_Arisa_Coin_Value - Player_Status.Instance.Player_Status_Cost_Values[i - 1];
                }
                else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_RobotKyle(Clone)")
                {
                    Enemy_Player_UI_Manager.Instance.Our_RobotKyle_Coin_Value = Enemy_Player_UI_Manager.Instance.Our_RobotKyle_Coin_Value - Player_Status.Instance.Player_Status_Cost_Values[i - 1];

                }

                 Color color = gameObject.GetComponent<Image>().color;
                color.a= 1f;
                gameObject.GetComponent<Image>().color = color;

                }
        }
   
    }

   

}
