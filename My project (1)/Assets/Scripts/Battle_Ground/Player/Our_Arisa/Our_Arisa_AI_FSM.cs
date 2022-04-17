using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Our_Arisa_AI_FSM : MonoBehaviour
{
    enum EnemyState
    {
        Stance,
        Walk,
        Attack,
        Die
    }

    EnemyState Arisa_State;

    Animator ani;

    Transform Enemy_Minion_target;
    NavMeshAgent nav;

    Vector3 TeamPlayer_dir;
    Vector3 Enemy_Minion_dir;

    float Enemy_TeamPlayer_distance = 0;
    float Enemy_Minion_Attack_distance = 0;


    public GameObject Enemy_Support_Player_UI;
    public Image Enemy_Support_Player_Hp;
    public Image Enemy_Support_Player_Mp;
    public Image Enemy_Support_Player_Exp;
    public Text Enemy_Support_Player_Level;

    float Our_Arisa_Hp_Value = 1f;
    float Our_Arisa_Mp_Value = 1f;
    float Our_Arisa_Exp_Value = 0f;

    bool Die_Value = false;


    bool Enemy_Value = false;


    [SerializeField] private float range;
    [SerializeField] private float rateOfAccuracy;
    [SerializeField] private float viewAngle;
    [SerializeField] private float spinSpeed;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform tf_TopGun;

    public GameObject Right_Sword_Attack_Zone;
    public GameObject Left_Sword_Attack_Zone;


    private RaycastHit hitInfo;


    private bool isFindTarget = false;
    private bool isAttack = false;

    private Transform tf_Target;

    Collider[] _target;

    Transform _targetTf;

    Rigidbody rg;


    Transform Middle_target;
    bool Middle_Value = false;
    bool Attack_Value = false;



    Collider[] _target_OurTeam;
    Transform _targetTf_OurTeam;
    private Transform tf_Target_OurTeam;
    Transform Enemy_TeamPlayer_target;

    Transform Enemy_Escape_target;
    Vector3 Enemy_Escape_target_dir;
    float Enemy_Escape_target_distance = 100;
    float Enemy_OurTeam_distance = 100;

    bool Attack_Judgment = false;

    bool Enemy_TeamPlayer_target_Value = false;
    public bool Skill_Cooltime = false;



    bool Enemy_Layer = false;
    bool Our_Layer = false;
    
    GameObject go_Skill_Attack3;
    Transform Enemy_ForeTop_target;

    Vector3 ForeTop_dir;
    Transform Enemy_Monster_target;
    float Enemy_Monster_Attack_distance;

    float Enemy_ForeTop_Attack_distance = 100;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

        Arisa_State = EnemyState.Stance;
        ani = GetComponent<Animator>();
        rg = GetComponent<Rigidbody>();





    }
    void Update()
    {
        rg.velocity = Vector3.zero;
        Minion_Status();

        Spin();

        SearchOurTeam();
        Look_OurTeam_Target();
        if (Our_Arisa_Hp_Value <= 0)
            Die();
        if (Attack_Judgment == true)
        {
            string ForTop_Name = null;
            if (gameObject.tag == "Our_Top" || gameObject.tag == "Our_Middle" || gameObject.tag == "Our_Bottom")
            {
                if (gameObject.tag == "Our_Top")
                    ForTop_Name = "Enemy_Right_ForeTop";
                else if (gameObject.tag == "Our_Middle")
                    ForTop_Name = "Enemy_Middle_ForeTop";
                else if (gameObject.tag == "Our_Bottom")
                    ForTop_Name = "Enemy_Left_ForeTop";
                Enemy_ForeTop_Set_Value(ForTop_Name);

            }
            else if (gameObject.tag == "Our_Support")
                TeamPlayer_Set_Value();
            else if (gameObject.tag == "Our_Jungle")
                Jungle_Monster_Set_Value();


            Enemy_Set_Value();

            switch (Arisa_State)
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

            Enemy_Escape_target = GameObject.FindWithTag("Our_Escape_Pos").transform;
            Enemy_Escape_target_dir = Enemy_Escape_target.transform.position - transform.position;
            Enemy_Escape_target_dir.y = 0;
            Enemy_Escape_target_distance = Vector3.Distance(Enemy_Escape_target.position, transform.position);

            if (Enemy_Escape_target_distance > 3f)
            {
                ani.SetBool("Run", true);
                if (nav.destination != Enemy_Escape_target.transform.position)
                {
                    nav.SetDestination(Enemy_Escape_target.transform.position);
                }
                else
                {
                    nav.SetDestination(transform.position);
                    Attack_Judgment = true;
                }
            }
            else if (Our_Arisa_Hp_Value >= 1f && Enemy_OurTeam_distance <= 10f) ;
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


            if (_targetTf.tag == "Enemy" || _targetTf.tag == "Enemy_Left_ForeTop" || _targetTf.tag == "Enemy_Right_ForeTop" || _targetTf.tag == "Enemy_Middle_ForeTop" ||
                   _targetTf.tag == "Enemy_Minion_Dragon" || _targetTf.tag == "Enemy_Top" || _targetTf.tag == "Enemy_Middle" ||
                     _targetTf.tag == "Enemy_Support" || _targetTf.tag == "Enemy_Bottom" || _targetTf.tag == "Enemy_Jungle")
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

            if (_targetTf_OurTeam.tag == "Our_Player" || _targetTf_OurTeam.tag == "Our" ||
                      _targetTf_OurTeam.tag == "Our_Minion_Dragon" || _targetTf_OurTeam.tag == "Our_Top" || _targetTf_OurTeam.tag == "Our_Middle" ||
                    _targetTf_OurTeam.tag == "Our_Support" || _targetTf_OurTeam.tag == "Our_Bottom" || _targetTf_OurTeam.tag == "Our_Jungle")
            {
                Enemy_OurTeam_distance = Vector3.Distance(_targetTf_OurTeam.position, transform.position);

                if (Enemy_OurTeam_distance <= 10f && Our_Arisa_Hp_Value > 0.3f)
                {
                    Attack_Judgment = true;
                }
                else if (Enemy_OurTeam_distance > 10f || Our_Arisa_Hp_Value <= 0.3f)
                {
                    Attack_Judgment = false;
                }
            }
        }
        tf_Target = null;
        isAttack = false;
        isFindTarget = false;


    }















    void Minion_Status()
    {
        Enemy_Support_Player_Hp.fillAmount = Our_Arisa_Hp_Value;
        Enemy_Support_Player_Mp.fillAmount = Our_Arisa_Mp_Value;
        Enemy_Support_Player_Exp.fillAmount = Enemy_Player_UI_Manager.Instance.Our_Arisa_Exp;
        Enemy_Support_Player_Level.text = "" + Enemy_Player_UI_Manager.Instance.Our_Arisa_Level;

        if (Our_Arisa_Hp_Value >= 1f)
            Our_Arisa_Hp_Value = 1f;
        if (Our_Arisa_Mp_Value >= 1f)
            Our_Arisa_Mp_Value = 1f;
        if (Our_Arisa_Exp_Value >= 1f)
            Our_Arisa_Exp_Value = 1f;
    }
    void Enemy_ForeTop_Set_Value(string ForTop_Name)
    {




        try
        {
            int LeftForetop_Count;
            GameObject[] LeftForetop_count = GameObject.FindGameObjectsWithTag(ForTop_Name);
            LeftForetop_Count = LeftForetop_count.Length;
            if (LeftForetop_Count >= 1)
            {
                Enemy_ForeTop_target = GameObject.FindWithTag(ForTop_Name).transform;
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
                                           range,
                                           layerMask))
            Enemy_Value = false;
    }
    void Jungle_Monster_Set_Value()
    {
        try
        {
            string[] Monster_target_Name =
                new string[4] { "Our_Hp_Monster", "Our_Mp_Monster", "Enemy_Hp_Monster", "Enemy_Mp_Monster" };
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
                    Enemy_Monster_Attack_distance = Vector3.Distance(Enemy_Monster_target.position, transform.position);

                    break;
                }
            }
            if (Enemy_Monster_target == null)
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

    void TeamPlayer_Set_Value()
    {
        try
        {

            int TeamPlayer_Count;
            GameObject[] TeamPlayer_count = GameObject.FindGameObjectsWithTag("Enemy_Player");

            TeamPlayer_Count = TeamPlayer_count.Length;
            if (Enemy_TeamPlayer_target_Value == false)
            {
                int Random_Target_Value = UnityEngine.Random.Range(0, TeamPlayer_count.Length);
                Enemy_TeamPlayer_target = TeamPlayer_count[Random_Target_Value].transform;
                Enemy_TeamPlayer_target_Value = true;

            }

            if ((Enemy_TeamPlayer_target.position == transform.position) ||
                Enemy_TeamPlayer_target == null ||
                Enemy_TeamPlayer_target.tag == "Enemy_Jungle")
            {
                Enemy_TeamPlayer_target_Value = false;
            }


            TeamPlayer_dir = Enemy_TeamPlayer_target.transform.position - transform.position;
            TeamPlayer_dir.y = 0;
            Enemy_TeamPlayer_distance = Vector3.Distance(Enemy_TeamPlayer_target.position, transform.position);


        }
        catch (NullReferenceException ex)
        {
        }
    }

    void Stance()
    {
        if (Enemy_ForeTop_Attack_distance > 3f)
            Arisa_State = EnemyState.Walk;

        else if (Enemy_ForeTop_Attack_distance <= 3f)
            Arisa_State = EnemyState.Attack;


    }
    void Walk()
    {

        ani.SetBool("Run", true);


        Walk_Pattern();

        float Target_Distance = 0;
        Transform Target_Dir = null;

        if (gameObject.tag == "Our_Top" || gameObject.tag == "Our_Middle" || gameObject.tag == "Our_Bottom")
        {
            Target_Dir = Enemy_ForeTop_target;
            Target_Distance = Enemy_ForeTop_Attack_distance;
        }
        else if (gameObject.tag == "Our_Jungle")
        {
            Target_Dir = Enemy_Monster_target;
            Target_Distance = Enemy_Monster_Attack_distance;
        }

        if (Target_Distance > 3f && Enemy_Value == false)
        {
            if (nav.destination != Target_Dir.transform.position)
            {
                nav.SetDestination(Target_Dir.transform.position);
            }
            else
            {
                nav.SetDestination(transform.position);
            }
        }


        else if (Enemy_Monster_Attack_distance <= 3f)
        {
            Arisa_State = EnemyState.Attack;

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

            if (Enemy_Minion_Attack_distance <= 3f)
                Arisa_State = EnemyState.Attack;
        }


    }


    void Attack()
    {
        ani.SetBool("Run", false);

        int Skill_Use_Random = UnityEngine.Random.Range(0, 2);

        for (int i = 0; i < 3; i++)
        {
            if (Skill_Use_Random == i && Enemy_Player_Manager.Instance.Enemy_Top_Skill_Attack_Level[i] >= 1 && Skill_Cooltime == false)
            {
                Skill_Attack(i);
                StartCoroutine(Skill_CoolTime(Enemy_Player_Manager.Instance.Enemy_Top_Skill_Attack_Level[i]));
            }
            else
            {
                if (Attack_Value == false)
                {
                    ani.SetTrigger("Basic_Attack");

                    Attack_Value = true;
                }
            }
        }


        if (Enemy_Value == true && Enemy_Minion_Attack_distance <= 3f)
            transform.LookAt(_targetTf.transform);
        else if (Enemy_Value == true && Enemy_Minion_Attack_distance > 3f)
        {
            Arisa_State = EnemyState.Walk;
        }

        if (Enemy_Value == false && Enemy_ForeTop_Attack_distance <= 3f)
            transform.LookAt(Enemy_ForeTop_target.transform);

        else if (Enemy_Value == false && Enemy_ForeTop_Attack_distance > 3f)
        {
            Arisa_State = EnemyState.Walk;
        }


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
        ani.SetBool("Run", false);
        //ani.SetTrigger("Basic_Attack");
        if (Die_Value == false)
        {
            ani.SetTrigger("Die");
            Die_Value = true;
            Battle_Player_UI_Manager.Instance.Enemy_Left_Minion_Kill = true;

        }
        Destroy(gameObject, 1f);
    }
    void Skill_Attack(int i)
    {
        if (i == 0)
            ani.SetTrigger("Skill1_Attack");
        else if (i == 1)
            ani.SetTrigger("Skill2_Attack");
        else if (i == 2)
            ani.SetTrigger("Skill3_Attack");
    }

    void Follow_go_Skill_Attack3()
    {
        if (go_Skill_Attack3 != null)
            go_Skill_Attack3.transform.position = transform.position;

    }
   

    public void Attack_Basic_True()
    {
        Left_Sword_Attack_Zone.GetComponent<BoxCollider>().enabled = true;
        SoundManager.Instance.PlaySFXSound("Arisa_Attack_Sound", 1f);

    }
    public void Attack_Basic_False()
    {
        Left_Sword_Attack_Zone.GetComponent<BoxCollider>().enabled = false;
        Attack_Value = false;

    }
    public void Attack_Skill1_True()
    {
        Right_Sword_Attack_Zone.GetComponent<BoxCollider>().enabled = true;
        SoundManager.Instance.PlaySFXSound("Arisa_Attack_Sound", 1f);

    }
    public void Attack_Skill1_False()
    {
        Right_Sword_Attack_Zone.GetComponent<BoxCollider>().enabled = false;

    }
    public void Attack_Skill2_True()
    {
        Left_Sword_Attack_Zone.GetComponent<BoxCollider>().enabled = true;
        SoundManager.Instance.PlaySFXSound("Arisa_Attack_Sound", 1f);

    }
    public void Attack_Skill2_False()
    {
        Left_Sword_Attack_Zone.GetComponent<BoxCollider>().enabled = false;

    }
    public void Attack_Skill3_True()
    {
        Right_Sword_Attack_Zone.GetComponent<BoxCollider>().enabled = true;
        SoundManager.Instance.PlaySFXSound("Arisa_Attack_Sound", 1f);

    }
    public void Attack_Skill3_False()
    {
        Right_Sword_Attack_Zone.GetComponent<BoxCollider>().enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Monster_Attack"))
        {
            Battle_Player_UI_Manager.Instance.Minion_hit_Judgment = true;

            Our_Arisa_Hp_Value -= 15f * Time.deltaTime;

        }

        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy_Attack"))
        {
            Battle_Player_UI_Manager.Instance.Minion_hit_Judgment = false;

            Our_Arisa_Hp_Value -= 5f * Time.deltaTime;


        }

        if (other.gameObject.tag == "Middle_Zone")
        {
            Middle_Value = true;

        }


    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Arisa_State = EnemyState.Attack;

        }

        if (collision.gameObject.tag == "Enemy_Minion_Dragon")
        {
            Arisa_State = EnemyState.Attack;

        }


    }

    public void Attack_Finish()
    {
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Our_Escape_Pos")
        {
            Our_Arisa_Hp_Value += 3f * Time.deltaTime;

        }
    }
}
