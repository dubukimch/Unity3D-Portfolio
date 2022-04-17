using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Our_Dragon_Right_FSM : MonoBehaviour
{

    enum EnemyState
    {
        Stance,
        Walk,
        Attack,
        Die
    }

    EnemyState Minion_State;

    Animator ani;

    Transform Enemy_ForeTop_target;
    Transform Enemy_Minion_target;
    NavMeshAgent nav;

    Vector3 ForeTop_dir;
    Vector3 Enemy_Minion_dir;

    float Enemy_ForeTop_Attack_distance = 0;
    float Enemy_Minion_Attack_distance = 0;


    public GameObject Attack_Zone;


    public Slider Minion_Hp;
    float Minion_Hp_Value = 1f;
    bool Die_Value = false;

    bool Enemy_Value = false;



    [SerializeField] private float range;
    [SerializeField] private float rateOfAccuracy;
    [SerializeField] private float viewAngle;
    [SerializeField] private float spinSpeed;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform tf_TopGun;




    private RaycastHit hitInfo;


    private bool isFindTarget = false;
    private bool isAttack = false;

    private Transform tf_Target;
    Collider[] _target;
    Transform _targetTf;
    Rigidbody rg;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

        Minion_State = EnemyState.Stance;
        ani = GetComponent<Animator>();
        rg = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rg.velocity = Vector3.zero;
        Minion_Status();
        ForeTop_Set_Value();
        Enemy_Set_Value();

        if (Minion_Hp_Value < 0)
            Minion_State = EnemyState.Die;

        switch (Minion_State)
        {
            case EnemyState.Stance:
                Stance();
                break;
            case EnemyState.Walk:
                Walk();
                break;
            case EnemyState.Attack:
                Attack();
                break;
            case EnemyState.Die:
                Die();
                break;
        }
    }
    private void Spin()
    {
        if (!isFindTarget && !isAttack)
        {
            Quaternion _spin = Quaternion.Euler(0f, tf_TopGun.eulerAngles.y + (1f * spinSpeed * Time.deltaTime), 0f);
            tf_TopGun.rotation = _spin;
        }
    }

    private void SearchEnemy()
    {
        _target = Physics.OverlapSphere(tf_TopGun.position, range, layerMask);

        for (int i = 0; i < _target.Length; i++)
        {
            _targetTf = _target[i].transform;


            if (_targetTf.name == "Enemy_Left_Minion(Clone)" ||
                _targetTf.name == "Enemy_Middle_Minion(Clone)" ||
                _targetTf.name == "Enemy_Right_Minion(Clone)")
            {
                Vector3 _direction = (_targetTf.position - tf_TopGun.position).normalized;
                float _angle = Vector3.Angle(_direction, tf_TopGun.forward);
                Enemy_Minion_Attack_distance = Vector3.Distance(_targetTf.position, transform.position);
                if (_angle < viewAngle * 0.5f)
                {
                    tf_Target = _targetTf;
                    isFindTarget = true;

                    if (_angle < 10f)
                        isAttack = true;
                    else
                        isAttack = false;

                    return;

                }
            }
        }
        tf_Target = null;
        isAttack = false;
        isFindTarget = false;


    }

    private void LookTarget()
    {
        if (isFindTarget)
        {
            Vector3 _direction = (tf_Target.position - tf_TopGun.position).normalized;
            Quaternion _lookRotation = Quaternion.LookRotation(_direction);
            Quaternion _rotation = Quaternion.Lerp(tf_TopGun.rotation, _lookRotation, 0.2f);
            tf_TopGun.rotation = _rotation;
        }
    }


    void Minion_Status()
    {
        Minion_Hp.value = Minion_Hp_Value;
    }
    void ForeTop_Set_Value()
    {
        try
        {
            int LeftForetop_Count;
            GameObject[] LeftForetop_count = GameObject.FindGameObjectsWithTag("Enemy_Right_ForeTop");
            LeftForetop_Count = LeftForetop_count.Length;
            if (LeftForetop_Count >= 1)
            {
                Enemy_ForeTop_target = GameObject.FindWithTag("Enemy_Right_ForeTop").transform;
                ForeTop_dir = Enemy_ForeTop_target.transform.position - transform.position;
                ForeTop_dir.y = 0;
                Enemy_ForeTop_Attack_distance = Vector3.Distance(Enemy_ForeTop_target.position, transform.position);
            }
            else if (LeftForetop_Count < 1)
            {
                Enemy_ForeTop_target = GameObject.FindWithTag("Enemy_Last_ForeTop").transform;
                ForeTop_dir = Enemy_ForeTop_target.transform.position - transform.position;
                ForeTop_dir.y = 0;
                Enemy_ForeTop_Attack_distance = Vector3.Distance(Enemy_ForeTop_target.position, transform.position);
            }
        }
        catch (NullReferenceException ex)
        {
        }
    }

    void Enemy_Set_Value()
    {

        Spin();
        SearchEnemy();
        LookTarget();
        if (Physics.Raycast(tf_TopGun.position,
                                          tf_TopGun.forward + new Vector3(UnityEngine.Random.Range(-1, 1f) * rateOfAccuracy, UnityEngine.Random.Range(-1, 1f) * rateOfAccuracy, 0f),
                                          out hitInfo,
                                          range,
                                          layerMask))
        {
            Debug.Log("적발견!");
            Enemy_Value = true;
        }
        else if (!Physics.Raycast(tf_TopGun.position,
                                          tf_TopGun.forward + new Vector3(UnityEngine.Random.Range(-1, 1f) * rateOfAccuracy, UnityEngine.Random.Range(-1, 1f) * rateOfAccuracy, 0f),
                                          out hitInfo,
                                          range,
                                          layerMask))
            Enemy_Value = false;

    }

    void Stance()
    {
        if (Enemy_ForeTop_Attack_distance > 4f)
            Minion_State = EnemyState.Walk;

        else if (Enemy_ForeTop_Attack_distance <= 4f)
            Minion_State = EnemyState.Attack;


    }
    void Walk()
    {

        ani.SetBool("Attack", false);
        ani.SetBool("Run", true);

        rg.isKinematic = true;

       
        if (Enemy_ForeTop_Attack_distance > 8f)
        {
            if (nav.destination != Enemy_ForeTop_target.transform.position)
            {
                nav.SetDestination(Enemy_ForeTop_target.transform.position);
            }
            else
            {
                nav.SetDestination(transform.position);
            }
        }


        if (Enemy_ForeTop_Attack_distance <= 8f)
        {
            Minion_State = EnemyState.Attack;

        }

    }
    void Attack()
    {
        transform.LookAt(Enemy_ForeTop_target.transform);
        rg.isKinematic = false;


        ani.SetBool("Run", false);
        ani.SetBool("Attack", true);
        if (Enemy_ForeTop_Attack_distance > 8f)
        {
            Minion_State = EnemyState.Walk;

        }

    }

    void Die()
    {
        ani.SetBool("Run", false);
        ani.SetBool("Attack", false);
        if (Die_Value == false)
        {
            ani.SetTrigger("Die");
            Die_Value = true;
        }

        StartCoroutine(Die_After());

    }

    IEnumerator Die_After()
    {
        yield return new WaitForSeconds(1f);
        Monster_Instantiate.Instance.Our_Minion_Dragon_Right_Value = false;
        Destroy(gameObject);

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
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy_Player_Attack") ||
            other.gameObject.layer == LayerMask.NameToLayer("Enemy_Attack"))
        {
            Debug.Log("공격과 충돌 입장!");
            Minion_Hp_Value -= 5f * Time.deltaTime;
        }

    }




}
