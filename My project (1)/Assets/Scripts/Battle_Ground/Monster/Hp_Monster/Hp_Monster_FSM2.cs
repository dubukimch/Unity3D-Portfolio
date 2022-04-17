using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Hp_Monster_FSM2 : MonoBehaviour
{
    public Slider Monster_Hp;

    enum EnemyState
    {
        Stance,
        Walk,
        Attack,
        Die
    }

    EnemyState Hp_Monster_State;

    Animator ani;

    Transform target;
    private List<GameObject> collEnemys = new List<GameObject>();

    NavMeshAgent nav;

    Vector3 dir = new Vector3(0, 0, 0);
    public GameObject Attack_Zone;
    float Attack_distance = 0;
    float Revive_distance = 0;
    Transform Hp_Monster_Revive1;
    CharacterController characterController;
    bool Die_Value = false;
    bool Enemy_Hp_Monster_hit = false;
    bool Our_Hp_Monster_hit = false;


    void Start()
    {
        Set_Value();
        nav = GetComponent<NavMeshAgent>();

        Hp_Monster_State = EnemyState.Stance;
        ani = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();


    }
    void Update()
    {
        if (Monster_Hp.value <= 0)
            Hp_Monster_State = EnemyState.Die;

        Set_Value();

        switch (Hp_Monster_State)
        {
            case EnemyState.Stance:
                {
                    Stance();
                    break;
                }
            case EnemyState.Walk:
                {
                    Walk();
                    break;
                }
            case EnemyState.Attack:
                {
                    Attack();
                    break;
                }
            case EnemyState.Die:
                {
                    Die();
                    break;
                }
        }
    }

    void Set_Value()
    {
        if (Monster_Hp.value < 1f)
        {
            try
            {
                Hp_Monster_Revive1 = GameObject.Find("Hp_Monster_Revive2_pos").transform;
                Attack_distance = Vector3.Distance(transform.position, target.position); 
                Revive_distance = Vector3.Distance(transform.position, Hp_Monster_Revive1.position);

            }
            catch (NullReferenceException ex)
            {

            }

        }
    }
    void Stance()
    {
        ani.SetBool("Run", false);

        if (Revive_distance <= 10 && Attack_distance <= 10)
        {
            if (Attack_distance <= 5)
            {

                Hp_Monster_State = EnemyState.Attack;
            }
            else
            {

                Hp_Monster_State = EnemyState.Walk;
            }
        }

    }
    void Walk()
    {

        if (Attack_distance > 20)
        {
            if (Revive_distance > 2)
            {
                dir = Hp_Monster_Revive1.position - transform.position;
                dir.y = 0;
                dir.Normalize();

                ani.SetBool("Run", true);
                transform.LookAt(target.transform);
                characterController.Move(dir * 0.1f * Time.deltaTime);
            }
            else if (Revive_distance < 1)
            {
                ani.SetBool("Run", false);

                Hp_Monster_State = EnemyState.Stance;

            }
        }
        else if (Attack_distance < 20)
        {
            if (Attack_distance >= 5)
            {
                dir = target.transform.position - transform.position;
                dir.y = 0;
                ani.SetBool("Run", true);
                dir.Normalize();
                transform.LookAt(target.transform);
                characterController.Move(dir * 5f * Time.deltaTime);
            }
            else if (Attack_distance < 5)
            {
                ani.SetBool("Run", false);

                Hp_Monster_State = EnemyState.Attack;

            }
        }


    }
    void Attack()
    {
        if (Monster_Hp.value < 1)
        {
            ani.SetBool("Run", false);
            ani.SetTrigger("Attack1");

            if (Attack_distance > 10 && Revive_distance > 5)
            {
                Hp_Monster_State = EnemyState.Walk;
            }
            else if (Attack_distance > 10 && Revive_distance < 5)
            {
                Hp_Monster_State = EnemyState.Stance;
            }
        }
    }
    void Die()
    {
        ani.SetBool("Run", false);
        if (Die_Value == false)
        {
            ani.SetTrigger("Die");
            Die_Value = true;

            if (Enemy_Hp_Monster_hit == true)
                Enemy_Player_UI_Manager.Instance.Enemy_Hp_Monster_Kill = true;
            else if (Our_Hp_Monster_hit == true)
                Enemy_Player_UI_Manager.Instance.Our_Hp_Monster_Kill = true;

        }
        Destroy(gameObject, 5f);
    }


    public void Attack_Zone_True()
    {
        Attack_Zone.SetActive(true);
    }
    public void Attack_Zone_False()
    {
        Attack_Zone.SetActive(false);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            collEnemys.Add(other.gameObject);

        if (other.gameObject.layer == LayerMask.NameToLayer("Player_Attack") ||
       other.gameObject.layer == LayerMask.NameToLayer("Enemy_Attack") ||
       other.gameObject.layer == LayerMask.NameToLayer("Own_Attack"))
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Enemy_Attack"))
            {
                Enemy_Hp_Monster_hit = true;
                Our_Hp_Monster_hit = false;
                Monster_Hp.value -= 15f * Time.deltaTime;
                dir = transform.position - other.gameObject.transform.position;
                target = other.gameObject.transform;
            }
            if (other.gameObject.layer == LayerMask.NameToLayer("Own_Attack"))
            {
                Our_Hp_Monster_hit = true;
                Enemy_Hp_Monster_hit = false;
                Monster_Hp.value -= 15f * Time.deltaTime;
                dir = transform.position - other.gameObject.transform.position;
                target = other.gameObject.transform;
            }

        }    

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            collEnemys.Add(other.gameObject);

        if (other.gameObject.layer == LayerMask.NameToLayer("Player_Attack") ||
       other.gameObject.layer == LayerMask.NameToLayer("Enemy_Attack") ||
       other.gameObject.layer == LayerMask.NameToLayer("Own_Attack"))
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Enemy_Attack"))
            {
                Enemy_Hp_Monster_hit = true;
                Our_Hp_Monster_hit = false;
                Monster_Hp.value -= 15f * Time.deltaTime;
                dir = transform.position - other.gameObject.transform.position;
                target = other.gameObject.transform;
            }
            if (other.gameObject.layer == LayerMask.NameToLayer("Own_Attack"))
            {
                Our_Hp_Monster_hit = true;
                Enemy_Hp_Monster_hit = false;
                Monster_Hp.value -= 15f * Time.deltaTime;
                dir = transform.position - other.gameObject.transform.position;
                target = other.gameObject.transform;
            }
        }

    }

}
