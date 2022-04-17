using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Level_Button : MonoBehaviour
{
   public void Skill_Level_Button_Click()
    {
        if(gameObject.name == "Skill_Attack1_Level_Button")
        {
            for(int i=0;i<3;i++)
                Player_Status.Instance.Player_Skill_Level_Select[i].GetComponent<RectTransform>().SetAsFirstSibling();
            Player_Status.Instance.Player_Skill1_Level_Value +=1;
        }
        else if (gameObject.name == "Skill_Attack2_Level_Button")
        {
            for (int i = 0; i < 3; i++)
                Player_Status.Instance.Player_Skill_Level_Select[i].GetComponent<RectTransform>().SetAsFirstSibling();
            Player_Status.Instance.Player_Skill2_Level_Value += 1;

        }
        else if (gameObject.name == "Skill_Attack3_Level_Button")
        {
            for (int i = 0; i < 3; i++)
                Player_Status.Instance.Player_Skill_Level_Select[i].GetComponent<RectTransform>().SetAsFirstSibling();
            Player_Status.Instance.Player_Skill3_Level_Value += 1;

        }
    }
}
