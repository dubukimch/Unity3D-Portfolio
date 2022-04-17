using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack_Button : MonoBehaviour
{
   public void Basic_Attack_Button()
    {
        Player_Status.Instance.Basic_Attack_Value = true;
    }
    public void Skill_Attack1_Button()
    {
        Player_Status.Instance.Skill_Attack1_Value = true;

    }
    public void Skill_Attack2_Button()
    {
        Player_Status.Instance.Skill_Attack2_Value = true;

    }
    public void Skill_Attack3_Button()
    {
        Player_Status.Instance.Skill_Attack3_Value = true;

    }

}
