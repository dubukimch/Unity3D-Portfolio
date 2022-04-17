using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBRCharacter_Bullet : MonoBehaviour
{
    Transform Shot_Pos;
    Vector3 Bullet_dir;
    float Speed =5f;
    public GameObject Skill1_Effect;
    GameObject go_Skill1_Effect;
    void Start()
    {
        Destroy(gameObject, 1f);
    }

    void Update()
    {
        this.transform.Translate(Vector3.forward  * Speed * Time.deltaTime);
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "PBRCharacter_Bullet")
        { 
            if (other.gameObject.layer == LayerMask.NameToLayer("Our") ||
                other.gameObject.layer == LayerMask.NameToLayer("Dragon") ||
                 other.gameObject.layer == LayerMask.NameToLayer("Monster") ||
                other.gameObject.layer == LayerMask.NameToLayer("Player"))
            {
                go_Skill1_Effect = Instantiate(Skill1_Effect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
        else if (gameObject.tag == "Our_PBRCharacter_Bullet")
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Enemy") ||
                other.gameObject.layer == LayerMask.NameToLayer("Monster") ||
                other.gameObject.layer == LayerMask.NameToLayer("Dragon"))
            {
                go_Skill1_Effect = Instantiate(Skill1_Effect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }


}
