using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player_PBRCharacter : MonoBehaviour
{
    


    public float moveSpead = 5f;
    public float rotationSpead = 360f;
    GameObject Player_UI;

    public int Approach_Attack = 5;
    public int Throw_Attack = 5;
    public int Onehand_Attack = 5;
    public int Twohand_Attack = 5;
    public int Approach_Defence = 5;
    public int Throw_Defence = 5;
    public int Onehand_Defence = 5;
    public int Twohand_Defence = 5;
    public int Approach_Magic = 5;
    public int Throw_Magic = 5;
    public int Onehand_Magic = 5;
    public int Twohand_Magic = 5;
    public int Approach_Speed = 5;
    public int Throw_Speed = 5;
    public int Onehand_Speed = 5;
    public int Twohand_Speed = 5;
    float xx;
    float zz;

    private float Speed_Value;

    public float Player_Hp_Value = 1f;
    public float Player_Mp_Value = 1f;
    bool Die_Value = false;

    CharacterController characterController;
    Animator animator;
    Rigidbody rb;
    Vector3 lookDirection;
    public Transform CameraArm;
    private Joystick joystick;

    
 




    public Transform Shot_Pos;
    public GameObject Shot_Effect;
    GameObject Go_Bullet;

    public GameObject Basic_Bullet;
    public GameObject Skill1_Bullet;
    public GameObject Skill2_Bullet;
    public GameObject Skill3_Bullet;

    public bool Skill_Cooltime = false;
   

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        joystick = GameObject.FindObjectOfType<Joystick>();
        CameraArm = GameObject.FindWithTag("MainCamera").transform;
        gameObject.GetComponent<NavMeshAgent>().enabled = false;
        transform.GetChild(8).gameObject.SetActive(false);
    }

    private void Update()
    {

        rb.velocity = Vector3.zero;
        if (Enemy_Player_UI_Manager.Instance.Our_Player_Hp <= 0)
        {

            Die();

        }
        if (Die_Value == false)
        {
            Walk();
            Attack();
            Player_Status_1();
            
        }
    }






    void Player_Status_1()
    {

        if (Player_Hp_Value >= 1)
            Player_Hp_Value = 1;
        else if (Player_Mp_Value >= 1)
            Player_Mp_Value = 1;
        if (Player_Hp_Value <= 0)
            Player_Hp_Value = 0;
        else if (Player_Mp_Value <= 0)
            Player_Mp_Value = 0;
        Battle_Player_UI_Manager.Instance.Approach_Attack_Basic_Value = Approach_Attack * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Throw_Attack_Basic_Value = Throw_Attack * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Onehand_Attack_Basic_Value = Onehand_Attack * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Twohand_Attack_Basic_Value = Twohand_Attack * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Approach_Defence_Basic_Value = Approach_Defence * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Throw_Defence_Basic_Value = Throw_Defence * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Onehand_Defence_Basic_Value = Onehand_Defence * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Twohand_Defence_Basic_Value = Twohand_Defence * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Approach_Magic_Basic_Value = Approach_Magic * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Throw_Magic_Basic_Value = Throw_Magic * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Onehand_Magic_Basic_Value = Onehand_Magic * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Twohand_Magic_Basic_Value = Twohand_Magic * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Approach_Speed_Basic_Value = Approach_Speed * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Throw_Speed_Basic_Value = Throw_Speed * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Onehand_Speed_Basic_Value = Onehand_Speed * Enemy_Player_UI_Manager.Instance.Our_Player_Level;
        Battle_Player_UI_Manager.Instance.Twohand_Speed_Basic_Value = Twohand_Speed * Enemy_Player_UI_Manager.Instance.Our_Player_Level;


    }

    public void Move(Vector2 inputDirection)
    {
        Vector2 moveInput = inputDirection;
        bool isMove = moveInput.magnitude != 0;
        if (isMove)
        {
            animator.SetBool("Run", true);
            Vector3 lookForward = new Vector3(CameraArm.forward.x, 0f, CameraArm.forward.z).normalized;
            Vector3 lookRight = new Vector3(CameraArm.right.x, 0f, CameraArm.right.z).normalized;
            Vector3 moveDir = lookForward * moveInput.y + lookRight * moveInput.x;
            gameObject.transform.forward = moveDir;
            transform.position += moveDir * Time.deltaTime * 5f;
        }
        else
            animator.SetBool("Run", false);

    }


    void Walk()
    {
        if (Input.GetKey(KeyCode.LeftArrow) ||
            Input.GetKey(KeyCode.RightArrow) ||
            Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.DownArrow))
        {

            animator.SetBool("Run", true);
            xx = Input.GetAxisRaw("Vertical");
            zz = Input.GetAxisRaw("Horizontal");
            lookDirection = xx * Vector3.forward + zz * Vector3.right;

            this.transform.rotation = Quaternion.LookRotation(lookDirection);
            this.transform.Translate(Vector3.forward * moveSpead * Time.deltaTime);
        }

    }

    void Attack()
    {
        
        GameObject[] Our_Bullet_count = GameObject.FindGameObjectsWithTag("Our_PBRCharacter_Bullet");
        int Our_Bullet_Count = Our_Bullet_count.Length;
        if (Our_Bullet_Count < 1)
        {
            if (Input.GetKeyDown(KeyCode.Z) || Player_Status.Instance.Basic_Attack_Value == true)
            {
                animator.SetTrigger("Basic_Attack");
                Player_Status.Instance.Basic_Attack_Value = false;
            }

            if ((Input.GetKeyDown(KeyCode.X) || Player_Status.Instance.Skill_Attack1_Value == true) &&
                Player_Status.Instance.Player_Skill1_CoolTime_Value <= 0f && Player_Status.Instance.Player_Skill1_Level_Value >= 1 && Enemy_Player_UI_Manager.Instance.Our_Player_Mp > 0f)
            {
                float coolTime = 30f - 6f * Player_Status.Instance.Player_Skill1_Level_Value;

                animator.SetTrigger("Skill1_Attack");
                Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Mp -= 0.1f;
                Player_Status.Instance.Skill_Attack1_Value = false;
                StartCoroutine(Player_Status.Instance.Player_Skill1_CoolTime_Start(coolTime));

            }

            if ((Input.GetKeyDown(KeyCode.C) || Player_Status.Instance.Skill_Attack2_Value == true) &&
                Player_Status.Instance.Player_Skill2_CoolTime_Value <= 0f && Player_Status.Instance.Player_Skill2_Level_Value >= 1 && Enemy_Player_UI_Manager.Instance.Our_Player_Mp > 0f)
            {
                float coolTime = 30f - 6f * Player_Status.Instance.Player_Skill2_Level_Value;

                animator.SetTrigger("Skill2_Attack");
                Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Mp -= 0.1f;

                Player_Status.Instance.Skill_Attack2_Value = false;

                StartCoroutine(Player_Status.Instance.Player_Skill2_CoolTime_Start(coolTime));

            }

            if ((Input.GetKeyDown(KeyCode.V) || Player_Status.Instance.Skill_Attack3_Value == true) &&
                Player_Status.Instance.Player_Skill3_CoolTime_Value <= 0f && Player_Status.Instance.Player_Skill3_Level_Value >= 1 && Enemy_Player_UI_Manager.Instance.Our_Player_Mp > 0f)
            {
                float coolTime = 60f - 6f * Player_Status.Instance.Player_Skill3_Level_Value;

                animator.SetTrigger("Skill3_Attack");
                Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Mp -= 0.1f;

                Player_Status.Instance.Skill_Attack3_Value = false;

                StartCoroutine(Player_Status.Instance.Player_Skill3_CoolTime_Start(coolTime));
                StartCoroutine(Skill_Attack3_Continue_Time());


            }
        }
    }

    IEnumerator Skill_Attack3_Continue_Time()
    {
        Battle_Player_UI_Manager.Instance.Approach_Attack_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Throw_Attack_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Onehand_Attack_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Twohand_Attack_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Approach_Defence_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Throw_Defence_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Onehand_Defence_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Twohand_Defence_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Approach_Magic_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Throw_Magic_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Onehand_Magic_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Twohand_Magic_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Approach_Speed_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Throw_Speed_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Onehand_Speed_Add_Value += 30;
        Battle_Player_UI_Manager.Instance.Twohand_Speed_Add_Value += 30;
        yield return new WaitForSeconds(30f);
        Battle_Player_UI_Manager.Instance.Approach_Attack_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Throw_Attack_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Onehand_Attack_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Twohand_Attack_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Approach_Defence_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Throw_Defence_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Onehand_Defence_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Twohand_Defence_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Approach_Magic_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Throw_Magic_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Onehand_Magic_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Twohand_Magic_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Approach_Speed_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Throw_Speed_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Onehand_Speed_Add_Value -= 30;
        Battle_Player_UI_Manager.Instance.Twohand_Speed_Add_Value -= 30;
    }
    void Die()
    {
        if (Die_Value == false)
        {
            animator.SetTrigger("Die");
            Die_Value = true;
        }
    }
    public void Basic_Attack_True()
    {
        Go_Bullet = Instantiate(Basic_Bullet, Shot_Pos.position, transform.rotation);
    }
    public void Skill_Attack1_True()
    {
        Go_Bullet = Instantiate(Skill1_Bullet, Shot_Pos.position, transform.rotation);

    }
    public void Skill_Attack2_True()
    {
        Go_Bullet = Instantiate(Skill2_Bullet, Shot_Pos.position, transform.rotation);
    }
    public void Skill_Attack3_True()
    {
        Go_Bullet = Instantiate(Skill3_Bullet, Shot_Pos.position, transform.rotation);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.GetComponent<Player_PBRCharacter>().enabled == true)
        {
            if (other.gameObject.layer == LayerMask.NameToLayer("Enemy_Attack"))
            {
                Battle_Player_UI_Manager.Instance.Minion_hit_Judgment = true;

                Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Hp -= 15f * Time.deltaTime;
            }

            if (other.gameObject.layer == LayerMask.NameToLayer("Monster_Attack"))
            {
                Battle_Player_UI_Manager.Instance.Minion_hit_Judgment = false;
                Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Hp -= 5f * Time.deltaTime;
            }
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Item"))
        {
            if (collision.gameObject.name == "Hp_Poshion(Clone)")
            {
                Battle_Player_UI_Manager.Instance.Poshin_Hp_Get_Value = true;
                Destroy(collision.gameObject);

            }
            else if (collision.gameObject.name == "Mp_Poshion(Clone)")
            {
                Battle_Player_UI_Manager.Instance.Poshin_Mp_Get_Value = true;
                Destroy(collision.gameObject);

            }
            else if (collision.gameObject.name == "Exp_Poshion(Clone)")
            {

                Battle_Player_UI_Manager.Instance.Poshin_Exp_Get_Value = true;
                Destroy(collision.gameObject);
            }
        }
    }
}
