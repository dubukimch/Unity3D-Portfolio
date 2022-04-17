using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satomi_Hit_Effect : MonoBehaviour
{
    public GameObject Enemy_Basic_Attack_Effect;
    public GameObject Enemy_Skill_Attack1_Effect;
    public GameObject Enemy_Skill_Attack2_Effect;
   
    public bool Enemy_Basic_Attack_Effect_Value = false;
    public bool Enemy_Skill_Attack1_Effect_Value = false;
    public bool Enemy_Skill_Attack2_Effect_Value = false;
    [SerializeField] private LayerMask layerMask;


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Minion") ||
            other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            GameObject go_hit_effect = Instantiate(Enemy_Skill_Attack2_Effect, other.transform.position, Quaternion.identity);
            Destroy(go_hit_effect, 1f);

     
        }
    }
    void Enemy_Basic_Attack_Effect_Value_()
    {
        Enemy_Basic_Attack_Effect_Value = true;
    }
    void Enemy_Skill_Attack1_Effect_Value_()
    {
        Enemy_Skill_Attack1_Effect_Value = true;
    }

    void Enemy_Skill_Attack2_Effect_Value_()
    {
        Enemy_Skill_Attack2_Effect_Value = true;

    }

}
