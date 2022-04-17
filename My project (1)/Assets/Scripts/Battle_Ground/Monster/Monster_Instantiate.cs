using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_Instantiate : MonoBehaviour
{
    public static Monster_Instantiate Instance;

    public GameObject Owr_Left_Minion;
    public GameObject Owr_Right_Minion;
    public GameObject Owr_Middle_Minion;
    public GameObject Left_Albino_Dragon;
    public GameObject Right_Albino_Dragon;
    public GameObject Enemy_Left_Minion;
    public GameObject Enemy_Right_Minion;
    public GameObject Enemy_Middle_Minion;
    public GameObject Left_Our_Minion_Dragon;
    public GameObject Right_Our_Minion_Dragon;


    public GameObject Owr_Left_Minion_Instantiate_Pos;
    public GameObject Owr_Middle_Minion_Instantiate_Pos;
    public GameObject Owr_Right_Minion_Instantiate_Pos;
    public GameObject Left_Albino_Dragon_Instantiate_Pos;
    public GameObject Right_Albino_Dragon_Instantiate_Pos;
    public GameObject Enemy_Left_Minion_Instantiate_Pos;
    public GameObject Enemy_Middle_Minion_Instantiate_Pos;
    public GameObject Enemy_Right_Minion_Instantiate_Pos;
    public Transform Enemy_Hp_Monster_Instantiate_Pos;
    public Transform Enemy_Mp_Monster_Instantiate_Pos;
    public Transform Our_Hp_Monster_Instantiate_Pos;
    public Transform Our_Mp_Monster_Instantiate_Pos;
    public GameObject Hp_Monster;
    public GameObject Mp_Monster;
    bool Enemy_Hp_Monster_Value = false;
    bool Enemy_Mp_Monster_Value = false;
    bool Our_Hp_Monster_Value = false;
    bool Our_Mp_Monster_Value = false;



    public float Minion_Create_Time;
    private float C_Time;
    public bool Our_Minion_Dragon_Left_Value = false;
    public bool Our_Minion_Dragon_Right_Value = false;
    public bool Enemy_Jungle_hit_Judgment = false;

    

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }
    void Start()
    {
        StartCoroutine(Owr_Minion_Instantiate());
        StartCoroutine(Enemy_Minion_Instantiate());

    }

    void Update()
    {
     
        Minion_Instantiate_Timer();
        Albino_Dragon_Instantiate();
        Hp_Monster_Instantiate();
        Mp_Monster_Instantiate();
    }

    void Albino_Dragon_Instantiate()
    {
        int Left_Albino_Dragon_Count;
        GameObject[] Left_Albino_Dragon_count = GameObject.FindGameObjectsWithTag("Albino_Dragon_Left");
        Left_Albino_Dragon_Count = Left_Albino_Dragon_count.Length;
        int Right_Albino_Dragon_Count;
        GameObject[] Right_Albino_Dragon_count = GameObject.FindGameObjectsWithTag("Albino_Dragon_Right");
        Right_Albino_Dragon_Count = Right_Albino_Dragon_count.Length;
        int Our_Minion_Dragon_Left_Count;
      



        if (Left_Albino_Dragon_Count < 1 && Our_Minion_Dragon_Left_Value == false)
        {
            Instantiate(Left_Albino_Dragon, Left_Albino_Dragon_Instantiate_Pos.transform.position, Quaternion.identity);

        }
        else if (Left_Albino_Dragon_Count < 1 && Our_Minion_Dragon_Left_Value == true)
        {
            Instantiate(Left_Our_Minion_Dragon, Left_Albino_Dragon_Instantiate_Pos.transform.position, Quaternion.identity);

        }
        if (Right_Albino_Dragon_Count < 1 && Our_Minion_Dragon_Right_Value == false)
        {
            Instantiate(Right_Albino_Dragon, Right_Albino_Dragon_Instantiate_Pos.transform.position, Quaternion.identity);

        }
        else if (Right_Albino_Dragon_Count < 1 && Our_Minion_Dragon_Right_Value == true)
        {
            Instantiate(Right_Our_Minion_Dragon, Right_Albino_Dragon_Instantiate_Pos.transform.position, Quaternion.identity);

        }

    }

    void Hp_Monster_Instantiate()
    {
        int Enemy_Hp_Monster_Count;
        GameObject[] Enemy_Hp_Monster_count = GameObject.FindGameObjectsWithTag("Enemy_Hp_Monster");
        Enemy_Hp_Monster_Count = Enemy_Hp_Monster_count.Length;
        int Our_Hp_Monster_Count;
        GameObject[] Our_Hp_Monster_count = GameObject.FindGameObjectsWithTag("Our_Hp_Monster");
        Our_Hp_Monster_Count = Our_Hp_Monster_count.Length;

        StartCoroutine(Enemy_Hp_Monster_CoolTime(Enemy_Hp_Monster_Count));
        StartCoroutine(Our_Hp_Monster_CoolTime(Our_Hp_Monster_Count));
    }
    IEnumerator Enemy_Hp_Monster_CoolTime(int Enemy_Hp_Monster_Count)
    {
        if (Enemy_Hp_Monster_Count < 1 && Enemy_Hp_Monster_Value == false)
        {
            Enemy_Hp_Monster_Value = true;
            yield return new WaitForSeconds(60f);

            GameObject go_Enemy_Hp_Monster =
                Instantiate(Hp_Monster, Enemy_Hp_Monster_Instantiate_Pos.transform.position, Quaternion.identity);
            go_Enemy_Hp_Monster.gameObject.tag = "Enemy_Hp_Monster";
            Enemy_Hp_Monster_Value = false;
        }
    }
    IEnumerator Our_Hp_Monster_CoolTime(int Our_Hp_Monster_Count)
    {
        if (Our_Hp_Monster_Count < 1 && Our_Hp_Monster_Value == false)
        {
            Our_Hp_Monster_Value = true;
            yield return new WaitForSeconds(60f);

            GameObject go_Our_Hp_Monster =
           Instantiate(Hp_Monster, Our_Hp_Monster_Instantiate_Pos.transform.position, Quaternion.identity);
            go_Our_Hp_Monster.gameObject.tag = "Our_Hp_Monster";
            Our_Hp_Monster_Value = false;
        }
    }



    void Mp_Monster_Instantiate()
    {
        int Enemy_Mp_Monster_Count;
        GameObject[] Enemy_Mp_Monster_count = GameObject.FindGameObjectsWithTag("Enemy_Mp_Monster");
        Enemy_Mp_Monster_Count = Enemy_Mp_Monster_count.Length;
        int Our_Mp_Monster_Count;
        GameObject[] Our_Mp_Monster_count = GameObject.FindGameObjectsWithTag("Our_Mp_Monster");
        Our_Mp_Monster_Count = Our_Mp_Monster_count.Length;
        StartCoroutine(Enemy_Mp_Monster_CoolTime(Enemy_Mp_Monster_Count));
        StartCoroutine(Our_Mp_Monster_CoolTime(Our_Mp_Monster_Count));
    }


    IEnumerator Enemy_Mp_Monster_CoolTime(int Enemy_Mp_Monster_Count)
    {
        if (Enemy_Mp_Monster_Count < 1 && Enemy_Mp_Monster_Value == false)
        {
            Enemy_Mp_Monster_Value = true;

            yield return new WaitForSeconds(60f);
            GameObject go_Enemy_Mp_Monster =
                Instantiate(Mp_Monster, Enemy_Mp_Monster_Instantiate_Pos.transform.position, Quaternion.identity);
            go_Enemy_Mp_Monster.gameObject.tag = "Enemy_Mp_Monster";
            Enemy_Mp_Monster_Value = false;

        }
    }
    IEnumerator Our_Mp_Monster_CoolTime(int Our_Mp_Monster_Count)
    {
        if (Our_Mp_Monster_Count < 1 && Our_Mp_Monster_Value == false)
        {
            Our_Mp_Monster_Value = true;

            yield return new WaitForSeconds(60f);
            GameObject go_Our_Mp_Monster =
           Instantiate(Mp_Monster, Our_Mp_Monster_Instantiate_Pos.transform.position, Quaternion.identity);
            go_Our_Mp_Monster.gameObject.tag = "Our_Mp_Monster";
            Our_Mp_Monster_Value = false;
        }

    }




    void Minion_Instantiate_Timer()
    {
        Minion_Create_Time = 30f;
        C_Time += Time.deltaTime;

        if (C_Time > Minion_Create_Time)
        {
            StartCoroutine(Enemy_Minion_Instantiate());
            StartCoroutine(Owr_Minion_Instantiate());
            C_Time = 0;
        }
    }
    IEnumerator Owr_Minion_Instantiate()
    {
        Instantiate(Owr_Left_Minion, Owr_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Middle_Minion, Owr_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Right_Minion, Owr_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(Owr_Left_Minion, Owr_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Middle_Minion, Owr_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Right_Minion, Owr_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(Owr_Left_Minion, Owr_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Middle_Minion, Owr_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Right_Minion, Owr_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(Owr_Left_Minion, Owr_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Middle_Minion, Owr_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Right_Minion, Owr_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(Owr_Left_Minion, Owr_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Middle_Minion, Owr_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Right_Minion, Owr_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(Owr_Left_Minion, Owr_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Middle_Minion, Owr_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Owr_Right_Minion, Owr_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);


    }

    IEnumerator Enemy_Minion_Instantiate()
    {
        Instantiate(Enemy_Left_Minion, Enemy_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Middle_Minion, Enemy_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Right_Minion, Enemy_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(Enemy_Left_Minion, Enemy_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Middle_Minion, Enemy_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Right_Minion, Enemy_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(Enemy_Left_Minion, Enemy_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Middle_Minion, Enemy_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Right_Minion, Enemy_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(Enemy_Left_Minion, Enemy_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Middle_Minion, Enemy_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Right_Minion, Enemy_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(Enemy_Left_Minion, Enemy_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Middle_Minion, Enemy_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Right_Minion, Enemy_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        Instantiate(Enemy_Left_Minion,  Enemy_Left_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Middle_Minion, Enemy_Middle_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        Instantiate(Enemy_Right_Minion, Enemy_Right_Minion_Instantiate_Pos.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);


    }
}
