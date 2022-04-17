using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special_Bullet_Effect : MonoBehaviour
{
    void Start()
    {
        if(gameObject.name == "Our_PBRCharacter_Skill3_Effect(Clone)" || gameObject.name == "Enemy_PBRCharacter_Skill3_Effect(Clone)")
            SoundManager.Instance.PlaySFXSound("PBRCharacter_Bullet_Fire_Sound", 10f);
        else if (gameObject.name == "Our_PBRCharacter_Skill2_Effect(Clone)" || gameObject.name == "Enemy_PBRCharacter_Skill2_Effect(Clone)")
            SoundManager.Instance.PlaySFXSound("PBRCharacter_Bullet_Electric_Sound", 10f);
        else if (gameObject.name == "Our_PBRCharacter_Skill1_Effect(Clone)" || gameObject.name == "Enemy_PBRCharacter_Skill1_Effect(Clone)")
            SoundManager.Instance.PlaySFXSound("PBRCharacter_Bullet_Poison_Sound", 10f);
        Destroy(gameObject, 10f);
    }

  
}
