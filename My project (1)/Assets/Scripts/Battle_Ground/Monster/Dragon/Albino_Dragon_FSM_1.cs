using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Albino_Dragon_FSM_1 : MonoBehaviour
{
    public Slider Monster_Hp;

    enum EnemyState
    {
        Stance,
        Attack1,
        Sleep,
       
    }
    EnemyState Albino_Dragon_Monster_State;
    Animator ani;
    Transform target;
    private List<GameObject> collEnemys = new List<GameObject>();

    NavMeshAgent nav;

    Vector3 dir = new Vector3(0, 0, 0);
    public GameObject Monster_Attack_Zone;
    public GameObject Minion_Attack_Zone;
    public GameObject Head;
    float Attack_distance = 0;
    float Revive_distance = 0;
    Transform Hp_Monster_Revive1;
    CharacterController characterController;
    bool Die_Value = false;

    int Die_Count = 0;
    float Monster_Hp_Value = 1f;
    bool Sleep_Value = false;
    Transform Albino_Dragon_Monster_Revive_pos;
    public Transform Head_transform;

    Rigidbody rg;


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

    float Enemy_Minion_Attack_distance = 0;
    bool Enemy_Value = false;

    void Start()
    {
        
        nav = GetComponent<NavMeshAgent>();
        Albino_Dragon_Monster_State = EnemyState.Stance;
        ani = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        rg = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rg.velocity = Vector3.zero;
      
        Monster_Status();
        

        if (Die_Count < 1)
        {
            if (Monster_Hp_Value < 1f)
            {
                Initialize_Set_Value();
                Initialize_State(); 
            }
        }
        if (Die_Count > 1) 
        {
            Minion_Set_Value();
            Enemy_Set_Value();
  
        }
       

    }
    void Monster_Status()
    {

        if (Monster_Hp_Value >= 1)
            Monster_Hp_Value = 1;

        Monster_Hp.value = Monster_Hp_Value;

    }
    void SearchPlayer()
    {
  

        if (Monster_Hp_Value < 1f)
        {

            _target = Physics.OverlapSphere(tf_TopGun.position, range, layerMask);

            for (int i = 0; i < _target.Length; i++)
            {
                _targetTf = _target[i].transform;


                if (_targetTf.tag == "Our_Top" ||
                    _targetTf.tag == "Our_Middle" ||
                    _targetTf.tag == "Our_Jungle" ||
                    _targetTf.tag == "Our_Bottom" ||
                    _targetTf.tag == "Our_Support" ||
                    _targetTf.tag == "Our" ||
                      _targetTf.tag == "Albino_Dragon_Left")
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
    }
    void Initialize_Set_Value()
    {

        Spin();
         SearchPlayer();
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
    void Initialize_State()
    {
        switch (Albino_Dragon_Monster_State)
        {
            case EnemyState.Stance:
                {

                    Stance();
                    break;
                }
            case EnemyState.Attack1:
                {

                    Attack1();
                    break;
                }
            case EnemyState.Sleep:
                {

                    Sleep();
                    break;
                }
        }
    }

    void Minion_Set_Value()
    {
        try
        {
            int LeftForetop_Count;
            GameObject[] LeftForetop_count = GameObject.FindGameObjectsWithTag("Enemy_Left_ForeTop");

            LeftForetop_Count = LeftForetop_count.Length;


            if (LeftForetop_Count >= 1)
            {
                target = GameObject.FindWithTag("Enemy_Left_ForeTop").transform;
                dir = target.transform.position - transform.position;
                dir.y = 0;
                Attack_distance = Vector3.Distance(target.position, transform.position); 
            }
            else if (LeftForetop_Count < 1)
            {
                target = GameObject.FindWithTag("Enemy_Last_ForeTop").transform;
                dir = target.transform.position - transform.position;
                dir.y = 0;
                Attack_distance = Vector3.Distance(target.position, transform.position); 
            }
        }
        catch (NullReferenceException ex)
        {
            Debug.Log(" ");
        }

    }
   




    void Stance()
    {
        transform.LookAt(target.transform);

        if (Attack_distance <= 10 && Monster_Hp_Value <= 0)
        {
            ani.SetBool("Run", false);
            ani.SetBool("Attack", false);
            Albino_Dragon_Monster_State = EnemyState.Sleep;
        }

        if (Attack_distance > 10 && Monster_Hp_Value > 0)
        {
            Monster_Hp_Value += 0.1f * Time.deltaTime;
        }
        else if (Attack_distance <= 10 && Monster_Hp_Value > 0)
        {
            ani.SetBool("Run", false);
            Albino_Dragon_Monster_State = EnemyState.Attack1;
        }

    }

   
    void Attack1()
    {
        if ((Attack_distance <= 15f) && (Monster_Hp_Value < 0f))
        {
            ani.SetBool("Run", false);
            ani.SetBool("Attack", false);
            Albino_Dragon_Monster_State = EnemyState.Sleep;
        }
        else if ((Attack_distance >= 10f) && (Monster_Hp_Value > 0f))
        {
            Albino_Dragon_Monster_State = EnemyState.Stance;

        }
        else if ((Attack_distance <= 10f) && (Monster_Hp_Value > 0f))
        {
            ani.SetBool("Run", false);
            ani.SetBool("Attack", true);
        }
        else if (Attack_distance > 15f && Monster_Hp_Value > 0f)
        {
            ani.SetBool("Run", false);
            ani.SetBool("Attack", false);
            Albino_Dragon_Monster_State = EnemyState.Stance;
        }
    }
   
    void Sleep()
    {
        ani.SetBool("Attack", false);

        ani.SetBool("Sleep", true);
        if (Sleep_Value == false)
        {
            Sleep_Value = true;
            Battle_Player_UI_Manager.Instance.Albino_Dragon_Monster_Kill = true;
        }
        Die_Count = 1;
        StartCoroutine(Sleep_After());
    }

    IEnumerator Sleep_After()
    {
        yield return new WaitForSeconds(5f);
        Die_Count = 2;
        ani.SetBool("Sleep", false);
        Monster_Instantiate.Instance.Our_Minion_Dragon_Left_Value = true;
        Destroy(gameObject);

    }

  

    void Attack_Zone_True()
    {
        if (Die_Count < 1 && Monster_Hp_Value > 0)
            Monster_Attack_Zone.SetActive(true);

        if (Die_Count > 1 && Monster_Hp_Value > 0)
            Minion_Attack_Zone.SetActive(true);

    }
    void Attack_Zone_False()
    {
        if (Die_Count < 1 && Monster_Hp_Value > 0)
            Monster_Attack_Zone.SetActive(false);
        if (Die_Count > 1 && Monster_Hp_Value > 0)
        {
            Monster_Attack_Zone.SetActive(false);
            Minion_Attack_Zone.SetActive(false);
        }

        ani.SetBool("Attack", false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            collEnemys.Add(other.gameObject);

        if (other.gameObject.layer == LayerMask.NameToLayer("Player_Attack"))
        {
            Monster_Hp_Value -= 15f * Time.deltaTime;
            Initialize_Set_Value();
            transform.LookAt(target.transform);

        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Enemy_Attack"))
        {
            Monster_Hp_Value -= 5f * Time.deltaTime;
            Initialize_Set_Value();
            transform.LookAt(target.transform);
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Own_Attack"))
        {
            Monster_Hp_Value -= 5f * Time.deltaTime;
            Initialize_Set_Value();
            transform.LookAt(target.transform);
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.layer == LayerMask.NameToLayer("Player_Attack"))
        {
            Monster_Hp_Value -= 0.1f * Time.deltaTime;
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



}
