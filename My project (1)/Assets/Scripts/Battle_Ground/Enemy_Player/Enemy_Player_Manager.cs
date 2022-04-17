using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy_Player_Manager : MonoBehaviour
{
    public static Enemy_Player_Manager Instance;

    public Transform Enemy_Top_Revive_pos;
    public Transform Enemy_Middle_Revive_pos;
    public Transform Enemy_Support_Revive_pos;
    public Transform Enemy_Bottom_Revive_pos;
    public Transform Enemy_Jungle_Revive_pos;

    public Transform Our_Top_Revive_pos;
    public Transform Our_Middle_Revive_pos;
    public Transform Our_Support_Revive_pos;
    public Transform Our_Bottom_Revive_pos;
    public Transform Our_Jungle_Revive_pos;

    GameObject player;

    GameObject Our_PBRCharacter;
    GameObject Our_Arisa;
    GameObject Our_RobotKyle;
    GameObject Our_Satomi;
    GameObject Our_UnityChan;
    GameObject Our_GamblerCat;
    GameObject Our_SapphiArtchan;



    GameObject Enemy_Top;
    GameObject Enemy_Middle;
    GameObject Enemy_Jungle;
    GameObject Enemy_Support;
    GameObject Enemy_Bottom;

    public float Enemy_Demage = 0;


    public bool Monster_Attack = false;
    public bool Hp_Monster_Kill = false;
    public bool Mp_Monster_Kill = false;
    public bool Albino_Dragon_Monster_Kill = false;
    public bool Enemy_Left_Minion_Kill = false;


    public bool Player_hit_Judgment = false;
    public bool Minion_hit_Judgment = false;

    GameObject go;

    GameObject go_Our_PBRCharacter;
    GameObject go_Our_Arisa;
    GameObject go_Our_RobotKyle;
    GameObject go_Our_Satomi;
    GameObject go_Our_UnityChan;
    GameObject go_Our_GamblerCat;
    GameObject go_Our_SapphiArtchan;



    GameObject go_Enemy_Top;
    GameObject go_Enemy_Middle;
    GameObject go_Enemy_Jungle;
    GameObject go_Enemy_Support;
    GameObject go_Enemy_Bottom;


    GameObject go_UI;

    Transform Player_Transform;

    int Coin_Value_Text_Value = 0;

    public int[] Enemy_Top_Skill_Attack_Level = new int[3];
    public int Enemy_Top_Player_Level_Check = 1;

    public int[] Enemy_Bottom_Skill_Attack_Level = new int[3];
    public int Enemy_Bottom_Player_Level_Check = 1;

    public int[] Enemy_Middle_Skill_Attack_Level = new int[3];
    public int Enemy_Middle_Player_Level_Check = 1;

    public int[] Enemy_Support_Skill_Attack_Level = new int[3];
    public int Enemy_Support_Player_Level_Check = 1;

    public int[] Enemy_Jungle_Skill_Attack_Level = new int[3];
    public int Enemy_Jungle_Player_Level_Check = 1;

    public GameObject[] Enemy_Player_List = new GameObject[5];


    public int[] Our_PBRCharacter_Skill_Attack_Level = new int[3];
    public int Our_PBRCharacter_Level_Check = 1;

    public int[] Our_Satomi_Skill_Attack_Level = new int[3];
    public int Our_Satomi_Level_Check = 1;

    public int[] Our_Arisa_Skill_Attack_Level = new int[3];
    public int Our_Arisa_Player_Level_Check = 1;

    public int[] Our_RobotKyle_Skill_Attack_Level = new int[3];
    public int Our_RobotKyle_Level_Check = 1;

    public int[] Our_UnityChan_Skill_Attack_Level = new int[3];
    public int Our_UnityChan_Level_Check = 1;

    public int[] Our_GamblerCat_Skill_Attack_Level = new int[3];
    public int Our_GamblerCat_Level_Check = 1;

    public int[] Our_SapphiArtchan_Skill_Attack_Level = new int[3];
    public int Our_SapphiArtchan_Level_Check = 1;


    public string[] Our_Player_List = new string[5];
    public string[] Our_Player_List_Tag = new string[5];
    public GameObject[] Our_Player_List_Obj = new GameObject[5];


    public bool Our_PBRCharacter_Value = false;
    public string Our_PBRCharacter_Tag;

    public bool Our_Arisa_Value = false;
    public string Our_Arisa_Tag;

    public bool Our_Satomi_Value = false;
    public string Our_Satomi_Tag;

    public bool Our_RobotKyle_Value = false;
    public string Our_RobotKyle_Tag;

    public bool Our_UnityChan_Value = false;
    public string Our_UnityChan_Tag;

    public bool Our_GamblerCat_Value = false;
    public string Our_GamblerCat_Tag;

    public bool Our_SapphiArtchan_Value = false;
    public string Our_SapphiArtchan_Tag;
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

       

        Our_Player_List_Obj[0] = Resources.Load<GameObject>(Character_Select.Instance.Our_Top_Character);
        Our_Player_List_Obj[1] = Resources.Load<GameObject>(Character_Select.Instance.Our_Middle_Character);
        Our_Player_List_Obj[2] = Resources.Load<GameObject>(Character_Select.Instance.Our_Bottom_Character);
        Our_Player_List_Obj[3] = Resources.Load<GameObject>(Character_Select.Instance.Our_Support_Character);
        Our_Player_List_Obj[4] = Resources.Load<GameObject>(Character_Select.Instance.Our_Jungle_Character);

        Our_Player_List_Obj[0].tag = "Our_Top";
        Our_Player_List_Obj[1].tag = "Our_Middle";
        Our_Player_List_Obj[2].tag = "Our_Bottom";
        Our_Player_List_Obj[3].tag = "Our_Support";
        Our_Player_List_Obj[4].tag = "Our_Jungle";

        Our_Player_List[0] = Character_Select.Instance.Our_Top_Character;
        Our_Player_List[1] = Character_Select.Instance.Our_Middle_Character;
        Our_Player_List[2] = Character_Select.Instance.Our_Bottom_Character;
        Our_Player_List[3] = Character_Select.Instance.Our_Support_Character;
        Our_Player_List[4] = Character_Select.Instance.Our_Jungle_Character;





        for (int i = 0; i < 5; i++)
        {
            if (Our_Player_List[i] == "Our_PBRCharacter")
            {
                Our_PBRCharacter_Value = true;
                Our_PBRCharacter_Tag = Our_Player_List_Obj[i].tag;
            }
            else if (Our_Player_List[i] == "Our_Arisa")
            {
                Our_Arisa_Value = true;
                Our_Arisa_Tag = Our_Player_List_Obj[i].tag;

            }
            else if (Our_Player_List[i] == "Our_RobotKyle")
            {
                Our_RobotKyle_Value = true;
                Our_RobotKyle_Tag = Our_Player_List_Obj[i].tag;

            }
            else if (Our_Player_List[i] == "Our_Satomi")
            {
                Our_Satomi_Value = true;
                Our_Satomi_Tag = Our_Player_List_Obj[i].tag;

            }
            else if (Our_Player_List[i] == "Our_UnityChan")
            {
                Our_UnityChan_Value = true;
                Our_UnityChan_Tag = Our_Player_List_Obj[i].tag;

            }
            else if (Our_Player_List[i] == "Our_GamblerCat")
            {
                Our_GamblerCat_Value = true;
                Our_GamblerCat_Tag = Our_Player_List_Obj[i].tag;

            }
        }


        for (int i = 0; i < 3; i++)
        { 
            if (i == 1)
            {
                Enemy_Top_Skill_Attack_Level[i] = 1;
                Enemy_Middle_Skill_Attack_Level[i] = 1;
                Enemy_Bottom_Skill_Attack_Level[i] = 1;
                Enemy_Support_Skill_Attack_Level[i] = 1;
                Enemy_Jungle_Skill_Attack_Level[i] = 1;
                Our_PBRCharacter_Skill_Attack_Level[i] = 1;
                Our_Arisa_Skill_Attack_Level[i] = 1;
                Our_Satomi_Skill_Attack_Level[i] = 1;
                Our_RobotKyle_Skill_Attack_Level[i] = 1;
                Our_UnityChan_Skill_Attack_Level[i] = 1;
                Our_GamblerCat_Skill_Attack_Level[i] = 1;


            }
            else
            {
                Enemy_Top_Skill_Attack_Level[i] = 0;
                Enemy_Middle_Skill_Attack_Level[i] = 0;
                Enemy_Bottom_Skill_Attack_Level[i] = 0;
                Enemy_Support_Skill_Attack_Level[i] = 0;
                Enemy_Jungle_Skill_Attack_Level[i] = 0;
                Our_PBRCharacter_Skill_Attack_Level[i] = 0;
                Our_Arisa_Skill_Attack_Level[i] = 0;
                Our_Satomi_Skill_Attack_Level[i] = 0;
                Our_RobotKyle_Skill_Attack_Level[i] = 0;
                Our_UnityChan_Skill_Attack_Level[i] = 0;
                Our_GamblerCat_Skill_Attack_Level[i] = 1;

            }
        }
    }

    void Update()
    {
        Enemy_Top_Instance();
        Enemy_Middle_Instance();
        Enemy_Support_Instance();
        Enemy_Bottom_Instance();
        Enemy_Jungle_Instance();

        Our_PBRCharacter_Instance();
        Our_Arisa_Instance();
        Our_Satomi_Instance();
        Our_RobotKyle_Instance();
        Our_UnityChan_Instance();
        Our_GamblerCat_Instance();

    }
    void Enemy_Top_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background"))
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag("Enemy_Top");

            Player_Count = Player_count.Length;


            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Enemy_Top_Player_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Enemy_Top_Player_Mp = 1f;
                Enemy_Top = Resources.Load<GameObject>("Enemy_PBRCharacter");
                go_Enemy_Top = Instantiate(Enemy_Top, Enemy_Top_Revive_pos.position, Quaternion.identity);

            }
            Top_Level_Check_Control();
        }
    }

    void Top_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try 
            {
                if (((i == Random_Skill_Tree_Value) && (Enemy_Top_Skill_Attack_Level[i] < 4)) && 
                    (Enemy_Player_UI_Manager.Instance.Enemy_Top_Player_Level > Enemy_Top_Player_Level_Check))
                {
                    Enemy_Top_Skill_Attack_Level[i]++;
                    Enemy_Top_Player_Level_Check++;
                }
            }
            catch(NullReferenceException ex)
            {

            }
         }
    }


    void Enemy_Middle_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background"))
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag("Enemy_Middle");

            Player_Count = Player_count.Length;


            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Enemy_Middle_Player_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Enemy_Middle_Player_Mp = 1f;
                Enemy_Middle = Resources.Load<GameObject>("Enemy_RobotKyle");
                go_Enemy_Middle = Instantiate(Enemy_Middle, Enemy_Middle_Revive_pos.position, Quaternion.identity);
            

            }
            Middle_Level_Check_Control();
        }
    }
    void Middle_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Enemy_Middle_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Enemy_Middle_Player_Level > Enemy_Middle_Player_Level_Check))
                {
                    Enemy_Middle_Skill_Attack_Level[i]++;
                    Enemy_Middle_Player_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }
 
    void Enemy_Support_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background"))
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag("Enemy_Support");

            Player_Count = Player_count.Length;


            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Enemy_Support_Player_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Enemy_Support_Player_Mp = 1f;
                Enemy_Support = Resources.Load<GameObject>("Enemy_Arisa");
                go_Enemy_Support = Instantiate(Enemy_Support, Enemy_Support_Revive_pos.position, Quaternion.identity);

            }
            Support_Level_Check_Control();
        }
    }
    void Support_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Enemy_Support_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Enemy_Support_Player_Level > Enemy_Support_Player_Level_Check))
                {
                    Enemy_Support_Skill_Attack_Level[i]++;
                    Enemy_Support_Player_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }
    void Enemy_Bottom_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background"))
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag("Enemy_Bottom");

            Player_Count = Player_count.Length;

            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Enemy_Bottom_Player_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Enemy_Bottom_Player_Mp = 1f;
                Enemy_Bottom = Resources.Load<GameObject>("Enemy_Satomi");
                go_Enemy_Bottom = Instantiate(Enemy_Bottom, Enemy_Bottom_Revive_pos.position, Quaternion.identity);

            }
            Bottom_Level_Check_Control();
        }
    }

    void Bottom_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Enemy_Bottom_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Enemy_Bottom_Player_Level > Enemy_Bottom_Player_Level_Check))
                {
                    Enemy_Bottom_Skill_Attack_Level[i]++;
                    Enemy_Bottom_Player_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }

    void Enemy_Jungle_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background"))
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag("Enemy_Jungle");

            Player_Count = Player_count.Length;

            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Enemy_Jungle_Player_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Enemy_Jungle_Player_Mp = 1f;
                Enemy_Jungle = Resources.Load<GameObject>("Enemy_SopphiArt");
                go_Enemy_Jungle = Instantiate(Enemy_Jungle, Enemy_Jungle_Revive_pos.position, Quaternion.identity);

            }
            Jungle_Level_Check_Control();
        }
    }

    void Jungle_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Enemy_Jungle_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Enemy_Jungle_Player_Level > Enemy_Jungle_Player_Level_Check))
                {
                    Enemy_Jungle_Skill_Attack_Level[i]++;
                    Enemy_Jungle_Player_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }


    void Our_PBRCharacter_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background") && Our_PBRCharacter_Value == true)
        {

            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag(Our_PBRCharacter_Tag);

            Player_Count = Player_count.Length;


            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Mp = 1f;
                Our_PBRCharacter = Resources.Load<GameObject>("Our_PBRCharacter");
                go_Our_PBRCharacter = Instantiate(Our_PBRCharacter, Our_Top_Revive_pos.position, Quaternion.identity);
                go_Our_PBRCharacter.gameObject.tag = Our_PBRCharacter_Tag;
                go_Our_PBRCharacter.layer =LayerMask.NameToLayer("Our");

            }
            Our_PBRCharacter_Level_Check_Control();
        }
    }

    void Our_PBRCharacter_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Our_PBRCharacter_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Level > Our_PBRCharacter_Level_Check))
                {
                    Our_PBRCharacter_Skill_Attack_Level[i]++;
                    Our_PBRCharacter_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }


    void Our_Arisa_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background") && 
            Our_Arisa_Value == true)
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag(Our_Arisa_Tag);

            Player_Count = Player_count.Length;


            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Our_Arisa_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Our_Arisa_Mp = 1f;
                Our_Arisa = Resources.Load<GameObject>("Our_Arisa");
                go_Our_Arisa = Instantiate(Our_Arisa, Our_Middle_Revive_pos.position, Quaternion.identity);
                go_Our_Arisa.gameObject.tag = Our_Arisa_Tag;
                go_Our_Arisa.layer = LayerMask.NameToLayer("Our");

            }
            Our_Arisa_Level_Check_Control();
        }
    }
    void Our_Arisa_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Our_Arisa_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Our_Arisa_Level > Our_Arisa_Player_Level_Check))
                {
                    Our_Arisa_Skill_Attack_Level[i]++;
                    Our_Arisa_Player_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }
   
    void Our_Satomi_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background") && Our_Satomi_Value == true)
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag(Our_Satomi_Tag);

            Player_Count = Player_count.Length;


            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Our_Satomi_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Our_Satomi_Mp = 1f;
                Our_Satomi = Resources.Load<GameObject>("Our_Satomi");
                go_Our_Satomi = Instantiate(Our_Satomi, Our_Support_Revive_pos.position, Quaternion.identity);
                go_Our_Satomi.gameObject.tag = Our_Satomi_Tag;
                go_Our_Satomi.layer = LayerMask.NameToLayer("Our");

            }
            Our_Satomi_Level_Check_Control();
        }
    }
    void Our_Satomi_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Our_Satomi_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Our_Satomi_Level > Our_Satomi_Level_Check))
                {
                    Our_Satomi_Skill_Attack_Level[i]++;
                    Our_Satomi_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }
    void Our_RobotKyle_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background") && Our_RobotKyle_Value == true)
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag(Our_RobotKyle_Tag);

            Player_Count = Player_count.Length;

            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Our_RobotKyle_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Our_RobotKyle_Mp = 1f;
                Our_RobotKyle = Resources.Load<GameObject>("Our_RobotKyle");
                go_Our_RobotKyle = Instantiate(Our_RobotKyle, Our_Bottom_Revive_pos.position, Quaternion.identity);
                go_Our_RobotKyle.gameObject.tag = Our_RobotKyle_Tag;
                go_Our_RobotKyle.layer = LayerMask.NameToLayer("Our");

            }
            Our_RobotKyle_Level_Check_Control();
        }
    }

    void Our_RobotKyle_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Our_RobotKyle_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Our_RobotKyle_Level > Our_RobotKyle_Level_Check))
                {
                    Our_RobotKyle_Skill_Attack_Level[i]++;
                    Our_RobotKyle_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }

    void Our_UnityChan_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background") && Our_UnityChan_Value == true)
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag(Our_UnityChan_Tag);

            Player_Count = Player_count.Length;

            if (Player_Count < 1 )
            {
                Enemy_Player_UI_Manager.Instance.Our_UnityChan_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Our_UnityChan_Mp = 1f;
                Our_UnityChan = Resources.Load<GameObject>("Our_UnityChan");
                go_Our_UnityChan = Instantiate(Our_UnityChan, Our_Jungle_Revive_pos.position, Quaternion.identity);
                go_Our_UnityChan.gameObject.tag = Our_UnityChan_Tag;
                go_Our_UnityChan.layer = LayerMask.NameToLayer("Our");

            }
            Our_UnityChan_Level_Check_Control();
        }
    }

    void Our_UnityChan_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Our_UnityChan_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Our_UnityChan_Level > Our_UnityChan_Level_Check))
                {
                    Our_UnityChan_Skill_Attack_Level[i]++;
                    Our_UnityChan_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }

    void Our_GamblerCat_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background") && Our_GamblerCat_Value == true)
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag(Our_GamblerCat_Tag);

            Player_Count = Player_count.Length;

            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Our_GamblerCat_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Our_GamblerCat_Mp = 1f;
                Our_GamblerCat = Resources.Load<GameObject>("Our_GamblerCat");
                go_Our_GamblerCat = Instantiate(Our_GamblerCat, Our_Jungle_Revive_pos.position, Quaternion.identity);
                go_Our_GamblerCat.gameObject.tag = Our_GamblerCat_Tag;
                go_Our_GamblerCat.layer = LayerMask.NameToLayer("Our");

            }
            Our_GamblerCat_Level_Check_Control();
        }
    }

    void Our_GamblerCat_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Our_GamblerCat_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Our_GamblerCat_Level > Our_GamblerCat_Level_Check))
                {
                    Our_GamblerCat_Skill_Attack_Level[i]++;
                    Our_GamblerCat_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }

    void Our_SapphiArtchan_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background") && Our_SapphiArtchan_Value == true)
        {
            int Player_Count;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag(Our_SapphiArtchan_Tag);

            Player_Count = Player_count.Length;

            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Our_SopphiArt_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Our_SopphiArt_Mp = 1f;
                Our_SapphiArtchan = Resources.Load<GameObject>("Our_SopphiArt");
                go_Our_SapphiArtchan = Instantiate(Our_SapphiArtchan, Our_Jungle_Revive_pos.position, Quaternion.identity);
                go_Our_SapphiArtchan.gameObject.tag = Our_SapphiArtchan_Tag;
                go_Our_SapphiArtchan.layer = LayerMask.NameToLayer("Our");

            }
            Our_SapphiArtchan_Level_Check_Control();
        }
    }

    void Our_SapphiArtchan_Level_Check_Control()
    {
        int Random_Skill_Tree_Value = UnityEngine.Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            try
            {
                if (((i == Random_Skill_Tree_Value) && (Our_SapphiArtchan_Skill_Attack_Level[i] < 4)) &&
                    (Enemy_Player_UI_Manager.Instance.Our_SopphiArt_Level > Our_SapphiArtchan_Level_Check))
                {
                    Our_SapphiArtchan_Skill_Attack_Level[i]++;
                    Our_SapphiArtchan_Level_Check++;
                }
            }
            catch (NullReferenceException ex)
            {

            }
        }
    }

}
