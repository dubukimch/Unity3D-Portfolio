using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy_GamblerCat_AI_Jungle_FSM : MonoBehaviour
{

    enum EnemyState
    {
        Stance,
        Walk,
        Attack,
        Die
    }

    EnemyState Jungle_State;
    List<string> animArray;
    Animation anim;
    int index = 0;

    Transform Enemy_Monster_target;
    NavMeshAgent nav;

    Vector3 ForeTop_dir;

    float Enemy_ForeTop_Attack_distance = 100;
    float Enemy_OurTeam_Attack_distance = 100;

    public GameObject Basic_Attack;
    public GameObject Skill_Attack1;

    public GameObject Skill_Attack2;
    GameObject go_Skill_Attack2;

    public GameObject Skill_Attack3;
    GameObject go_Skill_Attack3;


    public GameObject Enemy_Jungle_Player_UI;
    public Image Enemy_Jungle_Player_Hp;
    public Image Enemy_Jungle_Player_Mp;
    public Image Enemy_Jungle_Player_Exp;
    public Text Enemy_Jungle_Player_Level;

    float Enemy_Jungle_Player_Hp_Value = 1f;
    float Enemy_Jungle_Player_Mp_Value = 1f;
    float Enemy_Jungle_Player_Exp_Value = 0f;

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
    private Transform tf_Target_OurTeam;

    Collider[] _target;

    Transform _targetTf;

    Rigidbody rg;


    Transform Jungle_target;
    bool Jungle_Value = false;
    bool Attack_Value = false;



    Collider[] _target_OurTeam;
    Transform _targetTf_OurTeam;

    Transform Enemy_Escape_target;
    Vector3 Enemy_Escape_target_dir;
    float Enemy_Escape_target_distance = 0;
    float Enemy_OurTeam_distance = 0;

    bool Attack_Judgment = false;

    GameObject Go_Bullet;

    public bool Skill_Cooltime = false;


   

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

        Jungle_State = EnemyState.Stance;
        anim = gameObject.GetComponent<Animation>();
        rg = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rg.velocity = Vector3.zero;
        Enemy_Top_Player_Status();

        Spin();
        if (Enemy_Jungle_Player_Hp_Value <= 0)
            Die();

        if (Attack_Judgment == true)
        {
            Enemy_Set_Value();
            Jungle_Monster_Set_Value();
            switch (Jungle_State)
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
        else if (Attack_Judgment == false)
        {
            Enemy_Escape_target = GameObject.FindWithTag("Enemy_Escape_Pos").transform;
            Enemy_Escape_target_dir = Enemy_Escape_target.transform.position - transform.position;
            Enemy_Escape_target_dir.y = 0;
            Enemy_Escape_target_distance = Vector3.Distance(Enemy_Escape_target.position, transform.position);

                if (nav.destination != Enemy_Escape_target.transform.position)
                {
                    anim.Play("Run");
                    nav.SetDestination(Enemy_Escape_target.transform.position);
                }
                else
                {
                    nav.SetDestination(transform.position);
                }
            if(Enemy_Jungle_Player_Hp_Value >=1f)
                Attack_Judgment = true;

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


            if (_targetTf.tag == "Our" ||
                  _targetTf.tag == "Our_Minion_Dragon" ||
                  _targetTf.tag == "Monster" ||

                    _targetTf.tag == "Player")
            {
                Vector3 _direction = (_targetTf.position - tf_TopGun.position).normalized;
                float _angle = Vector3.Angle(_direction, tf_TopGun.forward);
                Enemy_OurTeam_Attack_distance = Vector3.Distance(_targetTf.position, transform.position);
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



    private void Look_OurTeam_Target()
    {
        if (isFindTarget)
        {
            Vector3 _direction = (tf_Target_OurTeam.position - tf_TopGun.position).normalized;
            Quaternion _lookRotation = Quaternion.LookRotation(_direction);
            Quaternion _rotation = Quaternion.Lerp(tf_TopGun.rotation, _lookRotation, 0.2f);
            tf_TopGun.rotation = _rotation;

        }
    }



    private void SearchOurTeam()
    {
        _target_OurTeam = Physics.OverlapSphere(tf_TopGun.position, range, layerMask);

        for (int i = 0; i < _target_OurTeam.Length; i++)
        {
            _targetTf_OurTeam = _target_OurTeam[i].transform;


            if (_targetTf_OurTeam.tag == "Enemy" ||
                  _targetTf_OurTeam.tag == "Enemy_Dragon") 
            {
                Enemy_OurTeam_distance = Vector3.Distance(_targetTf_OurTeam.position, transform.position);

                if (Enemy_Jungle_Player_Hp_Value > 0.3f)
                {
                    Attack_Judgment = true;
                }
                else if ( Enemy_Jungle_Player_Hp_Value <= 0.3f)
                {
                    Attack_Judgment = false;
                }
            }
        }

        tf_Target = null;
        isAttack = false;
        isFindTarget = false;


    }

    void Enemy_Top_Player_Status()
    {

        Enemy_Jungle_Player_Hp.fillAmount = Enemy_Jungle_Player_Hp_Value;
        Enemy_Jungle_Player_Mp.fillAmount = Enemy_Jungle_Player_Mp_Value;
        Enemy_Jungle_Player_Exp.fillAmount = Enemy_Player_UI_Manager.Instance.Enemy_Jungle_Player_Exp;
        Enemy_Jungle_Player_Level.text = "" + Enemy_Player_UI_Manager.Instance.Enemy_Jungle_Player_Level;

        if (Enemy_Jungle_Player_Hp_Value >= 1f)
            Enemy_Jungle_Player_Hp_Value = 1f;
        if (Enemy_Jungle_Player_Mp_Value >= 1f)
            Enemy_Jungle_Player_Mp_Value = 1f;
        if (Enemy_Jungle_Player_Exp_Value >= 1f)
            Enemy_Jungle_Player_Exp_Value = 1f;

    }
    void Jungle_Monster_Set_Value()
    {
        try
        {
            string[] Monster_target_Name =
                new string[4] { "Enemy_Hp_Monster", "Enemy_Mp_Monster", "Our_Hp_Monster", "Our_Mp_Monster" };
            for (int i = 0; i < 4; i++)
            {
                int Monster_Count;
                GameObject[] Monster_count = GameObject.FindGameObjectsWithTag(Monster_target_Name[i]);
                Monster_Count = Monster_count.Length;
                if (Monster_Count > 0)
                {
                    Enemy_Monster_target = GameObject.FindWithTag(Monster_target_Name[i]).transform;
                    ForeTop_dir = Enemy_Monster_target.transform.position - transform.position;
                    ForeTop_dir.y = 0;
                    Enemy_ForeTop_Attack_distance = Vector3.Distance(Enemy_Monster_target.position, transform.position);
                    break;
                }
            }
            if(Enemy_Monster_target == null)
            {
                Enemy_Monster_target = GameObject.FindWithTag("Middle_Zone").transform;

                if (nav.destination != Enemy_Monster_target.transform.position)
                {
                    nav.SetDestination(Enemy_Monster_target.transform.position);
                }
                else
                {
                    nav.SetDestination(transform.position);
                }
            }

        }
        catch (NullReferenceException ex)
        {
        }
    }

    void Enemy_Set_Value()
    {
        SearchEnemy();
        LookTarget();
        if (Physics.Raycast(tf_TopGun.position,
                                          tf_TopGun.forward + new Vector3(UnityEngine.Random.Range(-1, 1f) * rateOfAccuracy, UnityEngine.Random.Range(-1, 1f) * rateOfAccuracy, 0f),
                                          out hitInfo,
                                          range,
                                          layerMask))
        {
            Enemy_Value = true;
        }
        else if (!Physics.Raycast(tf_TopGun.position,
                                           tf_TopGun.forward + new Vector3(UnityEngine.Random.Range(-1, 1f) * rateOfAccuracy, UnityEngine.Random.Range(-1, 1f) * rateOfAccuracy, 0f),
                                           out hitInfo,
                                           range,layerMask))
        { 
            Enemy_Value = false;
        } 
    }

    void Stance()
    {
        if (Enemy_ForeTop_Attack_distance > 3f)
            Jungle_State = EnemyState.Walk;

        else if (Enemy_ForeTop_Attack_distance <= 3f)
            Jungle_State = EnemyState.Attack;


    }
    void Walk()
    {
        anim.Play("Run");
      
        Walk_Pattern();
            if (Enemy_ForeTop_Attack_distance > 3f && Enemy_Value == false)
            {
            if (nav.destination != Enemy_Monster_target.transform.position)
                {
                    nav.SetDestination(Enemy_Monster_target.transform.position);
                }
                else
                {
                    nav.SetDestination(transform.position);
                }
            }


            else if (Enemy_ForeTop_Attack_distance <= 3f)
            {
                Jungle_State = EnemyState.Attack;

            }
       
    }

    void Walk_Pattern()
    {
        if (Enemy_Value == true)
        {
            if (nav.destination != _targetTf.transform.position)
            {
                nav.SetDestination(_targetTf.transform.position);
            }
            else
            {
                nav.SetDestination(transform.position);
            }

            if (Enemy_OurTeam_Attack_distance <= 3f)
                Jungle_State = EnemyState.Attack;
        }


    }


    void Attack()
    {
        int Skill_Use_Random = UnityEngine.Random.Range(0, 2);

        for (int i = 0; i < 3; i++)
        {
            if (Skill_Use_Random == i && Enemy_Player_Manager.Instance.Enemy_Jungle_Skill_Attack_Level[i] >= 1 
                &&
                Skill_Cooltime == false)
            {
                Skill_Attack(i);
                StartCoroutine(Skill_CoolTime(Enemy_Player_Manager.Instance.Enemy_Jungle_Skill_Attack_Level[i]));
            }
            else
            {
                if (Attack_Value == false)
                {
                 
                   anim.Play("Basic_Attack");
                    Attack_Value = true;
                   StartCoroutine(Basic_Attack_True());
                }
            }

        }


        if (Enemy_Value == true && Enemy_OurTeam_Attack_distance <= 3f)
            transform.LookAt(_targetTf.transform);
        else if (Enemy_Value == true && Enemy_OurTeam_Attack_distance > 3f)
        {
            Jungle_State = EnemyState.Walk;
        }

        if (Enemy_Value == false && Enemy_ForeTop_Attack_distance <= 3f)
            transform.LookAt(Enemy_Monster_target.transform);

        else if (Enemy_Value == false && Enemy_ForeTop_Attack_distance > 3f)
        {
            Jungle_State = EnemyState.Walk;
        }
    }
    IEnumerator Basic_Attack_True()
    {
        yield return new WaitForSeconds(0.75f);
        Basic_Attack.GetComponent<BoxCollider>().enabled = true;
        yield return new WaitForSeconds(0.4f);
        Basic_Attack.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(0.8f);
        Attack_Value = false;
    }
    IEnumerator Skill_CoolTime(int Skill_Level)
    {
        float Skill_CoolTimer = 30 - 6 * Skill_Level;
        Skill_Cooltime = true;
        yield return new WaitForSeconds(Skill_CoolTimer);
        Skill_Cooltime = false;

    }
    void Die()
    {
        if (Die_Value == false)
        {
            anim.Play("Die");
            Die_Value = true;
            Battle_Player_UI_Manager.Instance.Enemy_Left_Minion_Kill = true;

        }
        Destroy(gameObject, 1f);
    }

    void Skill_Attack(int i)
    {
        if (i == 0)
            anim.Play("Skill_Attack1");
        else if (i == 1)
        {
            anim.Play("Skill_Attack2");
            go_Skill_Attack2 = Instantiate(Skill_Attack2, transform.position, Quaternion.identity);
            Destroy(go_Skill_Attack2, 3f);
        }
        else if (i == 2)
        {
            anim.Play("Skill_Attack3");
            go_Skill_Attack3 = Instantiate(Skill_Attack3, transform.position, Quaternion.identity);
            Destroy(go_Skill_Attack3, 30f);
        }
    }
    public void Attack_Basic_True()
    {
        Basic_Attack.GetComponent<BoxCollider>().enabled = true;
    }
    public void Attack_Basic_False()
    {
        Basic_Attack.GetComponent<BoxCollider>().enabled = false;
        Attack_Value = false;

    }
    public void Attack_Skill1_True()
    {
        Skill_Attack1.GetComponent<BoxCollider>().enabled = true;
    }
    public void Attack_Skill1_False()
    {
        Skill_Attack1.GetComponent<BoxCollider>().enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player_Attack"))
        {
            Battle_Player_UI_Manager.Instance.Minion_hit_Judgment = true;

            Enemy_Jungle_Player_Hp_Value -= 15f * Time.deltaTime;
        }

        if (other.gameObject.layer == LayerMask.NameToLayer("Own_Attack"))
        {
            Battle_Player_UI_Manager.Instance.Minion_hit_Judgment = false;
            Enemy_Jungle_Player_Hp_Value -= 5f * Time.deltaTime;
        }

        if (other.gameObject.layer == LayerMask.NameToLayer("Monster_Attack"))
        {
            Battle_Player_UI_Manager.Instance.Minion_hit_Judgment = false;
            Enemy_Jungle_Player_Hp_Value -= 5f * Time.deltaTime;
        }


    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Minion")||
            collision.gameObject.tag == "Our_Minion_Dragon"||
           collision.gameObject.tag == "Monster")
        {
            Jungle_State = EnemyState.Attack;

        }

    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy_Escape_Pos")
        {
            Enemy_Jungle_Player_Hp_Value += 3f * Time.deltaTime;

        }
    }



}
