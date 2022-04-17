using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_Player_UI_Manager : MonoBehaviour
{
    public static Enemy_Player_UI_Manager Instance;

    public int Enemy_Top_Player_Level =1;
    public float Enemy_Top_Player_Hp = 1f;
    public float Enemy_Top_Player_Mp = 1f;
    public float Enemy_Top_Player_Exp = 0f;
    public float Enemy_Top_Exp_Capacity = 0f;
    public int Enemy_Top_Coin_Value = 0;
    public bool Enemy_Top_Player_Exp_Value = false;

    public int Enemy_Middle_Player_Level = 1;
    public float Enemy_Middle_Player_Hp = 1f;
    public float Enemy_Middle_Player_Mp = 1f;
    public float Enemy_Middle_Player_Exp = 0f;
    public float Enemy_Middle_Exp_Capacity = 0f;
    public int Enemy_Middle_Coin_Value = 0;
    public bool Enemy_Middle_Player_Exp_Value = false;

    public int Enemy_Bottom_Player_Level = 1;
    public float Enemy_Bottom_Player_Hp = 1f;
    public float Enemy_Bottom_Player_Mp = 1f;
    public float Enemy_Bottom_Player_Exp = 0f;
    public float Enemy_Bottom_Exp_Capacity = 0f;
    public int Enemy_Bottom_Coin_Value = 0;
    public bool Enemy_Bottom_Player_Exp_Value = false;

    public int Enemy_Support_Player_Level = 1;
    public float Enemy_Support_Player_Hp = 1f;
    public float Enemy_Support_Player_Mp = 1f;
    public float Enemy_Support_Player_Exp = 0f;
    public float Enemy_Support_Exp_Capacity = 0f;
    public int Enemy_Support_Coin_Value = 0;
    public bool Enemy_Support_Player_Exp_Value = false;

    public int Enemy_Jungle_Player_Level = 1;
    public float Enemy_Jungle_Player_Hp = 1f;
    public float Enemy_Jungle_Player_Mp = 1f;
    public float Enemy_Jungle_Player_Exp = 0f;
    public float Enemy_Jungle_Exp_Capacity = 0f;
    public int Enemy_Jungle_Coin_Value = 0;
    public bool Enemy_Jungle_Player_Exp_Value = false;



    public int Our_PBRCharacter_Level = 1;
    public float Our_PBRCharacter_Hp = 1f;
    public float Our_PBRCharacter_Mp = 1f;
    public float Our_PBRCharacter_Exp = 0f;
    public float Our_PBRCharacter_Exp_Capacity = 0f;
    public int Our_PBRCharacter_Coin_Value = 0;
    public bool Our_PBRCharacter_Exp_Value = false;

    public int Our_Satomi_Level = 1;
    public float Our_Satomi_Hp = 1f;
    public float Our_Satomi_Mp = 1f;
    public float Our_Satomi_Exp = 0f;
    public float Our_Satomi_Exp_Capacity = 0f;
    public int Our_Satomi_Coin_Value = 0;
    public bool Our_Satomi_Exp_Value = false;

    public int Our_RobotKyle_Level = 1;
    public float Our_RobotKyle_Hp = 1f;
    public float Our_RobotKyle_Mp = 1f;
    public float Our_RobotKyle_Exp = 0f;
    public float Our_RobotKyle_Exp_Capacity = 0f;
    public int Our_RobotKyle_Coin_Value = 0;
    public bool Our_RobotKyle_Exp_Value = false;

    public int Our_Arisa_Level = 1;
    public float Our_Arisa_Hp = 1f;
    public float Our_Arisa_Mp = 1f;
    public float Our_Arisa_Exp = 0f;
    public float Our_Arisa_Exp_Capacity = 0f;
    public int Our_Arisa_Coin_Value = 0;
    public bool Our_Arisa_Exp_Value = false;

    public int Our_UnityChan_Level = 1;
    public float Our_UnityChan_Hp = 1f;
    public float Our_UnityChan_Mp = 1f;
    public float Our_UnityChan_Exp = 0f;
    public float Our_UnityChan_Exp_Capacity = 0f;
    public int Our_UnityChan_Coin_Value = 0;
    public bool Our_UnityChan_Exp_Value = false;

    public int Our_GamblerCat_Level = 1;
    public float Our_GamblerCat_Hp = 1f;
    public float Our_GamblerCat_Mp = 1f;
    public float Our_GamblerCat_Exp = 0f;
    public float Our_GamblerCat_Exp_Capacity = 0f;
    public int Our_GamblerCat_Coin_Value = 0;
    public bool Our_GamblerCat_Exp_Value = false;


    public int Our_SopphiArt_Level = 1;
    public float Our_SopphiArt_Hp = 1f;
    public float Our_SopphiArt_Mp = 1f;
    public float Our_SopphiArt_Exp = 0f;
    public float Our_SopphiArt_Exp_Capacity = 0f;
    public int Our_SopphiArt_Coin_Value = 0;
    public bool Our_SopphiArt_Exp_Value = false;




    public bool Enemy_Mp_Monster_Kill = false;
    public bool Enemy_Hp_Monster_Kill = false;
    public bool Enemy_Hp_Monster_Kill_Effect = false;
    public bool Enemy_Mp_Monster_Kill_Effect = false;



    public bool Our_Mp_Monster_Kill = false;
    public bool Our_Hp_Monster_Kill = false;
    public bool Our_Hp_Monster_Kill_Effect = false;
    public bool Our_Mp_Monster_Kill_Effect = false;


    public bool Enemy_Albino_Dragon_Monster_Kill = false;
    public bool Our_Albino_Dragon_Monster_Kill = false;

    
    public float[] Enemy_Player_Exp_Capacity = new float[5];
    public float[] Our_Player_Exp_Capacity = new float[7];


    Transform go_Enemy_Top;
    Transform go_Enemy_Middle;
    Transform go_Enemy_Jungle;
    Transform go_Enemy_Bottom;
    Transform go_Enemy_Support;


    GameObject go_Enemy_Top_Hp_Effect;
    GameObject go_Enemy_Middle_Hp_Effect;
    GameObject go_Enemy_Jungle_Hp_Effect;
    GameObject go_Enemy_Bottom_Hp_Effect;
    GameObject go_Enemy_Support_Hp_Effect;

    GameObject go_Enemy_Top_Mp_Effect;
    GameObject go_Enemy_Middle_Mp_Effect;
    GameObject go_Enemy_Jungle_Mp_Effect;
    GameObject go_Enemy_Bottom_Mp_Effect;
    GameObject go_Enemy_Support_Mp_Effect;


    Transform go_Our_Top;
    Transform go_Our_Middle;
    Transform go_Our_Support;
    Transform go_Our_Bottom;
    Transform go_Our_Jungle;

    GameObject go_Our_Top_Mp_Effect;
    GameObject go_Our_Middle_Mp_Effect;
    GameObject go_Our_Jungle_Mp_Effect;
    GameObject go_Our_Bottom_Mp_Effect;
    GameObject go_Our_Support_Mp_Effect;

    GameObject go_Our_Top_Hp_Effect;
    GameObject go_Our_Middle_Hp_Effect;
    GameObject go_Our_Jungle_Hp_Effect;
    GameObject go_Our_Bottom_Hp_Effect;
    GameObject go_Our_Support_Hp_Effect;


    public GameObject Hp_Effect;
    public GameObject Mp_Effect;


    public int Our_Player_Level = 1;
    public float Our_Player_Hp = 1f;
    public float Our_Player_Mp = 1f;
    public float Our_Player_Exp = 0f;
    public int Our_Player_Coin_Value = 0;

    public bool Enemy_Hp_UI_Effect_Value = false;
    public bool Our_Hp_UI_Effect_Value = false;
    public bool Enemy_Mp_UI_Effect_Value = false;
    public bool Our_Mp_UI_Effect_Value = false;


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
         Enemy_Top_Player_Exp = 0f;
        Enemy_Top_Exp_Capacity = 0f;
        Enemy_Top_Exp_Capacity = Enemy_Player_Exp_Capacity[0];

        Enemy_Middle_Player_Exp = 0f;
        Enemy_Middle_Exp_Capacity = 0f;
        Enemy_Middle_Exp_Capacity =Enemy_Player_Exp_Capacity[1];

        Enemy_Bottom_Player_Exp = 0f;
        Enemy_Bottom_Exp_Capacity = 0f;
        Enemy_Bottom_Exp_Capacity = Enemy_Player_Exp_Capacity[2];

        Enemy_Support_Player_Exp = 0f;
        Enemy_Support_Exp_Capacity = 0f;
        Enemy_Support_Exp_Capacity = Enemy_Player_Exp_Capacity[3];

        Enemy_Jungle_Player_Exp = 0f;
        Enemy_Jungle_Exp_Capacity = 0f;
        Enemy_Jungle_Exp_Capacity = Enemy_Player_Exp_Capacity[4];


        Our_PBRCharacter_Exp = 0f;
        Our_PBRCharacter_Exp_Capacity = 0f;
        Our_PBRCharacter_Exp_Capacity = Our_Player_Exp_Capacity[0];

        Our_Arisa_Exp = 0f;
        Our_Arisa_Exp_Capacity = 0f;
        Our_Arisa_Exp_Capacity = Our_Player_Exp_Capacity[1];

        Our_Satomi_Exp = 0f;
        Our_Satomi_Exp_Capacity = 0f;
        Our_Satomi_Exp_Capacity = Our_Player_Exp_Capacity[2];

        Our_RobotKyle_Exp = 0f;
        Our_RobotKyle_Exp_Capacity = 0f;
        Our_RobotKyle_Exp_Capacity = Our_Player_Exp_Capacity[3];

        Our_UnityChan_Exp = 0f;
        Our_UnityChan_Exp_Capacity = 0f;
        Our_UnityChan_Exp_Capacity = Our_Player_Exp_Capacity[4];

        Our_GamblerCat_Exp = 0f;
        Our_GamblerCat_Exp_Capacity = 0f;
        Our_GamblerCat_Exp_Capacity = Our_Player_Exp_Capacity[5];

        Our_SopphiArt_Exp = 0f;
        Our_SopphiArt_Exp_Capacity = 0f;
        Our_SopphiArt_Exp_Capacity = Our_Player_Exp_Capacity[6];



        Exp_division();
        Level_Control();

    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            Find_Object("Enemy_Middle");
            Find_Object("Enemy_Top");
            Find_Object("Enemy_Jungle");
            Find_Object("Enemy_Support");
            Find_Object("Enemy_Bottom");
            Find_Object("Our_Middle");
            Find_Object("Our_Top");
            Find_Object("Our_Jungle");
            Find_Object("Our_Support");
            Find_Object("Our_Bottom");

        }
        catch (NullReferenceExcelltion ex)
        { }
        Exp_division();
        Level_Control();
        Monster_Kill_Effect();
        Player_Character_Select();
        Hp_Control();
        Mp_Control();
    }

    void Find_Object(string Tag_Name)
    {
        Transform go_obj=null;
        

        int go_Enemy_count;
        GameObject[] go_Enemy_Count = GameObject.FindGameObjectsWithTag(Tag_Name);
        go_Enemy_count = go_Enemy_Count.Length;
        if (go_Enemy_count > 0)
            go_obj= GameObject.FindWithTag(Tag_Name).transform;


        if (Tag_Name == "Enemy_Top")
            go_Enemy_Top = go_obj;
        else if (Tag_Name == "Enemy_Middle")
            go_Enemy_Middle = go_obj;
        else if (Tag_Name == "Enemy_Jungle")
            go_Enemy_Jungle = go_obj;
        else if (Tag_Name == "Enemy_Support")
            go_Enemy_Support  = go_obj;
        else if (Tag_Name == "Enemy_Bottom")
            go_Enemy_Bottom  = go_obj;


        if (Tag_Name == "Our_Top")
            go_Our_Top  = go_obj;
        else if (Tag_Name == "Our_Middle")
            go_Our_Middle  = go_obj;
        else if (Tag_Name == "Our_Jungle")
            go_Our_Jungle = go_obj;
        else if (Tag_Name == "Our_Support")
            go_Our_Support  = go_obj;
        else if (Tag_Name == "Our_Bottom")
            go_Our_Bottom  = go_obj;

    }

    void Player_Character_Select()
    {
        if(GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_UnityChan(Clone)")
        {
            Our_Player_Level = Our_UnityChan_Level;
            Our_Player_Hp = Our_UnityChan_Hp;
            Our_Player_Mp = Our_UnityChan_Mp;
            Our_Player_Exp = Our_UnityChan_Exp;
            Our_Player_Coin_Value = Our_UnityChan_Coin_Value;
        }

        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_PBRCharacter(Clone)")
        {
            Our_Player_Level =      Our_PBRCharacter_Level;
            Our_Player_Hp =         Our_PBRCharacter_Hp;
            Our_Player_Mp =         Our_PBRCharacter_Mp;
            Our_Player_Exp =        Our_PBRCharacter_Exp;
            Our_Player_Coin_Value = Our_PBRCharacter_Coin_Value;
        }
        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Satomi(Clone)")
        {
            Our_Player_Level =      Our_Satomi_Level;
            Our_Player_Hp =         Our_Satomi_Hp;
            Our_Player_Mp =         Our_Satomi_Mp;
            Our_Player_Exp =        Our_Satomi_Exp;
            Our_Player_Coin_Value = Our_Satomi_Coin_Value;
        }
        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Arisa(Clone)")
        {
            Our_Player_Level =      Our_Arisa_Level;
            Our_Player_Hp =         Our_Arisa_Hp;
            Our_Player_Mp =         Our_Arisa_Mp;
            Our_Player_Exp =        Our_Arisa_Exp;
            Our_Player_Coin_Value = Our_Arisa_Coin_Value;
        }
        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_RobotKyle(Clone)")
        {
            Our_Player_Level =      Our_RobotKyle_Level;
            Our_Player_Hp =         Our_RobotKyle_Hp;
            Our_Player_Mp =         Our_RobotKyle_Mp;
            Our_Player_Exp =        Our_RobotKyle_Exp;
            Our_Player_Coin_Value = Our_RobotKyle_Coin_Value;
        }
        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_GamblerCat(Clone)")
        {
            Our_Player_Level = Our_GamblerCat_Level;
            Our_Player_Hp = Our_GamblerCat_Hp;
            Our_Player_Mp = Our_GamblerCat_Mp;
            Our_Player_Exp = Our_GamblerCat_Exp;
            Our_Player_Coin_Value = Our_GamblerCat_Coin_Value;
        }
        else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_SopphiArt(Clone)")
        {
            Our_Player_Level = Our_SopphiArt_Level;
            Our_Player_Hp = Our_SopphiArt_Hp;
            Our_Player_Mp = Our_SopphiArt_Mp;
            Our_Player_Exp = Our_SopphiArt_Exp;
            Our_Player_Coin_Value = Our_SopphiArt_Coin_Value;
        }      
    }



    void Exp_division()
    {
        if (Enemy_Top_Player_Exp_Value == true)
        {
            Enemy_Top_Player_Exp += Enemy_Top_Exp_Capacity;       
            Enemy_Top_Player_Exp_Value = false;
            Enemy_Top_Exp_Capacity = 0;
          
        }

        if (Enemy_Middle_Player_Exp_Value == true)
        {
            Enemy_Middle_Player_Exp += Enemy_Middle_Exp_Capacity;      
            Enemy_Middle_Player_Exp_Value = false;
            Enemy_Middle_Exp_Capacity = 0;
           
        }

        if (Enemy_Bottom_Player_Exp_Value == true)
        {
            Enemy_Bottom_Player_Exp += Enemy_Bottom_Exp_Capacity;         
            Enemy_Bottom_Player_Exp_Value = false;
            Enemy_Bottom_Exp_Capacity = 0;
        
        }

        if (Enemy_Support_Player_Exp_Value == true)
        {
            Enemy_Support_Player_Exp += Enemy_Support_Exp_Capacity;      
            Enemy_Support_Player_Exp_Value = false;
            Enemy_Support_Exp_Capacity = 0;
           

        }
        if (Enemy_Jungle_Player_Exp_Value == true)
        {
            Enemy_Jungle_Player_Exp += Enemy_Jungle_Exp_Capacity;      
            Enemy_Jungle_Player_Exp_Value = false;
            Enemy_Jungle_Exp_Capacity = 0;     

        }

        if (Our_PBRCharacter_Exp_Value == true)
        {
            Our_PBRCharacter_Exp += Our_PBRCharacter_Exp_Capacity;
            Our_PBRCharacter_Exp_Value = false;
            Our_PBRCharacter_Exp_Capacity = 0;

        }

        if (Our_Arisa_Exp_Value == true)
        {
            Our_Arisa_Exp += Our_Arisa_Exp_Capacity;
            Our_Arisa_Exp_Value = false;
            Our_Arisa_Exp_Capacity = 0;

        }

        if (Our_Satomi_Exp_Value == true)
        {
            Our_Satomi_Exp += Our_Satomi_Exp_Capacity;
            Our_Satomi_Exp_Value = false;
            Our_Satomi_Exp_Capacity = 0;

        }

        if (Our_RobotKyle_Exp_Value == true)
        {
            Our_RobotKyle_Exp += Our_RobotKyle_Exp_Capacity;
            Our_RobotKyle_Exp_Value = false;
            Our_RobotKyle_Exp_Capacity = 0;

        }
        if (Our_UnityChan_Exp_Value == true)
        {
            Our_UnityChan_Exp += Our_UnityChan_Exp_Capacity;
            Our_UnityChan_Exp_Value = false;
            Our_UnityChan_Exp_Capacity = 0;

        }
        if (Our_GamblerCat_Exp_Value == true)
        {
            Our_GamblerCat_Exp += Our_GamblerCat_Exp_Capacity;
            Our_GamblerCat_Exp_Value = false;
            Our_GamblerCat_Exp_Capacity = 0;

        }
        if (Our_SopphiArt_Exp_Value == true)
        {
            Our_SopphiArt_Exp += Our_SopphiArt_Exp_Capacity;
            Our_SopphiArt_Exp_Value = false;
            Our_SopphiArt_Exp_Capacity = 0;
        }
    }

    void Level_Control()
    {
        if(Enemy_Top_Player_Exp >=1f)
        {
            Enemy_Top_Player_Level++;
            Enemy_Top_Player_Exp = 0;
        }

        if (Enemy_Middle_Player_Exp >= 1f)
        {
            Enemy_Middle_Player_Level++;
            Enemy_Middle_Player_Exp = 0;
        }

        if (Enemy_Bottom_Player_Exp >= 1f)
        {
            Enemy_Bottom_Player_Level++;
            Enemy_Bottom_Player_Exp = 0;
        }

        if (Enemy_Support_Player_Exp >= 1f)
        {
            Enemy_Support_Player_Level++;
            Enemy_Support_Player_Exp = 0;
        }
        if (Enemy_Jungle_Player_Exp >= 1f)
        {
            Enemy_Jungle_Player_Level++;
            Enemy_Jungle_Player_Exp = 0;
        }

        if (Our_PBRCharacter_Exp >= 1f)
        {
            Our_PBRCharacter_Level++;
            Our_PBRCharacter_Exp = 0;
        }

        if (Our_Arisa_Exp >= 1f)
        {
            Our_Arisa_Level++;
            Our_Arisa_Exp = 0;
        }

        if (Our_Satomi_Exp >= 1f)
        {
            Our_Satomi_Level++;
            Our_Satomi_Exp = 0;
        }

        if (Our_RobotKyle_Exp >= 1f)
        {
            Our_RobotKyle_Level++;
            Our_RobotKyle_Exp = 0;
        }
        if (Our_UnityChan_Exp >= 1f)
        {
            Our_UnityChan_Level++;
            Our_UnityChan_Exp = 0;
        }
        if (Our_GamblerCat_Exp >= 1f)
        {       
            Our_GamblerCat_Level++;
            Our_GamblerCat_Exp = 0;
        }

        if (Our_SopphiArt_Exp >= 1f)
        {
            Our_SopphiArt_Level++;
            Our_SopphiArt_Exp = 0;
        }
    }

    void Hp_Control()
    {
        if (Enemy_Top_Player_Hp >= 1f)
        {
           
            Enemy_Top_Player_Hp = 1;
        }

        if (Enemy_Middle_Player_Hp >= 1f)
        {
            
            Enemy_Middle_Player_Hp = 0;
        }

        if (Enemy_Bottom_Player_Hp >= 1f)
        {
           
            Enemy_Bottom_Player_Hp = 1;
        }

        if (Enemy_Support_Player_Hp >= 1f)
        {
           
            Enemy_Support_Player_Hp = 1;
        }
        if (Enemy_Jungle_Player_Hp >= 1f)
        {
           
            Enemy_Jungle_Player_Hp = 1;
        }



        if (Our_PBRCharacter_Hp >= 1f)
        {
      
            Our_PBRCharacter_Hp = 1;
        }

        if (Our_Arisa_Hp >= 1f)
        {
           
            Our_Arisa_Hp = 1;
        }

        if (Our_Satomi_Hp >= 1f)
        {
           
            Our_Satomi_Hp = 1;
        }

        if (Our_RobotKyle_Hp >= 1f)
        {
            
            Our_RobotKyle_Hp = 1;
        }
        if (Our_UnityChan_Hp>= 1f)
        {
            
            Our_UnityChan_Hp = 1;
        }
        if (Our_GamblerCat_Hp >= 1f)
        {

            Our_GamblerCat_Hp = 1;
        }
        if (Our_SopphiArt_Hp >= 1f)
        {

            Our_SopphiArt_Hp = 1;
        }

        
    }

    void Mp_Control()
    {
        if (Enemy_Top_Player_Mp >= 1f)
        {

            Enemy_Top_Player_Mp = 1;
        }

        if (Enemy_Middle_Player_Mp >= 1f)
        {

            Enemy_Middle_Player_Mp = 0;
        }

        if (Enemy_Bottom_Player_Mp >= 1f)
        {

            Enemy_Bottom_Player_Mp = 1;
        }

        if (Enemy_Support_Player_Mp >= 1f)
        {

            Enemy_Support_Player_Mp = 1;
        }
        if (Enemy_Jungle_Player_Mp >= 1f)
        {

            Enemy_Jungle_Player_Mp = 1;
        }



        if (Our_PBRCharacter_Mp >= 1f)
        {

            Our_PBRCharacter_Mp = 1;
        }

        if (Our_Arisa_Mp >= 1f)
        {

            Our_Arisa_Mp = 1;
        }

        if (Our_Satomi_Mp >= 1f)
        {

            Our_Satomi_Mp = 1;
        }

        if (Our_RobotKyle_Mp >= 1f)
        {

            Our_RobotKyle_Mp = 1;
        }
        if (Our_UnityChan_Mp >= 1f)
        {

            Our_UnityChan_Mp = 1;
        }
        if (Our_GamblerCat_Mp >= 1f)
        {

            Our_GamblerCat_Mp = 1;
        }
        if (Our_SopphiArt_Mp >= 1f)
        {

            Our_SopphiArt_Mp = 1;
        }


    }


    void Monster_Kill_Effect()
    {
       
        try
        { 



        if (Enemy_Mp_Monster_Kill_Effect == true )
        {

            go_Enemy_Top = GameObject.FindGameObjectWithTag("Enemy_Top").transform;
            go_Enemy_Middle = GameObject.FindGameObjectWithTag("Enemy_Middle").transform;
            go_Enemy_Jungle = GameObject.FindGameObjectWithTag("Enemy_Jungle").transform;
            go_Enemy_Bottom = GameObject.FindGameObjectWithTag("Enemy_Bottom").transform;
            go_Enemy_Support = GameObject.FindGameObjectWithTag("Enemy_Support").transform;

            go_Enemy_Top_Mp_Effect.transform.position = new Vector3(go_Enemy_Top.position.x, go_Enemy_Top.position.y + 2f, go_Enemy_Top.position.z);
            go_Enemy_Middle_Mp_Effect.transform.position = new Vector3(go_Enemy_Middle.position.x, go_Enemy_Middle.position.y + 2f, go_Enemy_Middle.position.z);
            go_Enemy_Jungle_Mp_Effect.transform.position = new Vector3(go_Enemy_Jungle.position.x, go_Enemy_Jungle.position.y + 2f, go_Enemy_Jungle.position.z);
            go_Enemy_Bottom_Mp_Effect.transform.position = new Vector3(go_Enemy_Bottom.position.x, go_Enemy_Bottom.position.y + 2f, go_Enemy_Bottom.position.z);
            go_Enemy_Support_Mp_Effect.transform.position = new Vector3(go_Enemy_Support.position.x, go_Enemy_Support.position.y + 2f, go_Enemy_Support.position.z);

            
        }

        if (Enemy_Hp_Monster_Kill_Effect == true)
        {

            go_Enemy_Top = GameObject.FindGameObjectWithTag("Enemy_Top").transform;
            go_Enemy_Middle = GameObject.FindGameObjectWithTag("Enemy_Middle").transform;
            go_Enemy_Jungle = GameObject.FindGameObjectWithTag("Enemy_Jungle").transform;
            go_Enemy_Bottom = GameObject.FindGameObjectWithTag("Enemy_Bottom").transform;
            go_Enemy_Support = GameObject.FindGameObjectWithTag("Enemy_Support").transform;

            go_Enemy_Top_Hp_Effect.transform.position = new Vector3(go_Enemy_Top.position.x, go_Enemy_Top.position.y + 2f, go_Enemy_Top.position.z);
            go_Enemy_Middle_Hp_Effect.transform.position = new Vector3(go_Enemy_Middle.position.x, go_Enemy_Middle.position.y + 2f, go_Enemy_Middle.position.z);
            go_Enemy_Jungle_Hp_Effect.transform.position = new Vector3(go_Enemy_Jungle.position.x, go_Enemy_Jungle.position.y + 2f, go_Enemy_Jungle.position.z);
            go_Enemy_Bottom_Hp_Effect.transform.position = new Vector3(go_Enemy_Bottom.position.x, go_Enemy_Bottom.position.y + 2f, go_Enemy_Bottom.position.z);
            go_Enemy_Support_Hp_Effect.transform.position = new Vector3(go_Enemy_Support.position.x, go_Enemy_Support.position.y + 2f, go_Enemy_Support.position.z);


        }
        if (Our_Hp_Monster_Kill_Effect == true)
        {

            go_Our_Top      = GameObject.FindGameObjectWithTag("Our_Top").transform;
            go_Our_Middle   = GameObject.FindGameObjectWithTag("Our_Middle").transform;
            go_Our_Jungle   = GameObject.FindGameObjectWithTag("Our_Jungle").transform;
            go_Our_Bottom   = GameObject.FindGameObjectWithTag("Our_Bottom").transform;
            go_Our_Support  = GameObject.FindGameObjectWithTag("Our_Support").transform;

                go_Our_Top_Hp_Effect.transform.position = new Vector3(go_Our_Top.position.x, go_Our_Top.position.y + 2f, go_Our_Top.position.z);
                go_Our_Middle_Hp_Effect.transform.position = new Vector3(go_Our_Middle.position.x, go_Our_Middle.position.y + 2f, go_Our_Middle.position.z);
                go_Our_Jungle_Hp_Effect.transform.position = new Vector3(go_Our_Jungle.position.x, go_Our_Jungle.position.y + 2f, go_Our_Jungle.position.z);
                go_Our_Bottom_Hp_Effect.transform.position = new Vector3(go_Our_Bottom.position.x, go_Our_Bottom.position.y + 2f, go_Our_Bottom.position.z);
                go_Our_Support_Hp_Effect.transform.position = new Vector3(go_Our_Support.position.x, go_Our_Support.position.y + 2f, go_Our_Support.position.z);


            }
        if (Our_Mp_Monster_Kill_Effect == true )
        {

            go_Our_Top     = GameObject.FindGameObjectWithTag("Our_Top").transform;
            go_Our_Middle   = GameObject.FindGameObjectWithTag("Our_Middle").transform;
            go_Our_Jungle   = GameObject.FindGameObjectWithTag("Our_Jungle").transform;
            go_Our_Bottom      = GameObject.FindGameObjectWithTag("Our_Bottom").transform;
            go_Our_Support = GameObject.FindGameObjectWithTag("Our_Support").transform;

                go_Our_Top_Mp_Effect.transform.position = new Vector3(go_Our_Top.position.x, go_Our_Top.position.y + 2f, go_Our_Top.position.z);
                go_Our_Middle_Mp_Effect.transform.position = new Vector3(go_Our_Middle.position.x, go_Our_Middle.position.y + 2f, go_Our_Middle.position.z);
                go_Our_Jungle_Mp_Effect.transform.position = new Vector3(go_Our_Jungle.position.x, go_Our_Jungle.position.y + 2f, go_Our_Jungle.position.z);
                go_Our_Bottom_Mp_Effect.transform.position = new Vector3(go_Our_Bottom.position.x, go_Our_Bottom.position.y + 2f, go_Our_Bottom.position.z);
                go_Our_Support_Mp_Effect.transform.position = new Vector3(go_Our_Support.position.x, go_Our_Support.position.y + 2f, go_Our_Support.position.z);


            }
        if (Enemy_Hp_Monster_Kill == true)
        {
            Enemy_Top_Player_Exp += 0.5f;
            Enemy_Middle_Player_Exp += 0.5f;
            Enemy_Jungle_Player_Exp += 0.5f;
            Enemy_Support_Player_Exp += 0.5f;
            Enemy_Bottom_Player_Exp += 0.5f;

            Enemy_Top_Coin_Value += 500;
            Enemy_Middle_Coin_Value += 500;
            Enemy_Jungle_Coin_Value += 500;
            Enemy_Support_Coin_Value += 500;
            Enemy_Bottom_Coin_Value += 500;



            StartCoroutine(Enemy_HP_Monster_Kill_Effect());

            Enemy_Hp_Monster_Kill = false;
                Enemy_Hp_UI_Effect_Value = true;

            }
            if (Enemy_Mp_Monster_Kill == true)
        {
            Enemy_Top_Player_Exp += 0.5f;
            Enemy_Middle_Player_Exp += 0.5f;
            Enemy_Jungle_Player_Exp += 0.5f;
            Enemy_Support_Player_Exp += 0.5f;
            Enemy_Bottom_Player_Exp += 0.5f;

            Enemy_Top_Coin_Value += 500;
            Enemy_Middle_Coin_Value += 500;
            Enemy_Jungle_Coin_Value += 500;
            Enemy_Support_Coin_Value += 500;
            Enemy_Bottom_Coin_Value += 500;

            StartCoroutine(Enemy_MP_Monster_Kill_Effect());
            Enemy_Mp_Monster_Kill = false;
                Enemy_Mp_UI_Effect_Value = true;
            }

        if (Our_Hp_Monster_Kill == true)
        {
            Our_PBRCharacter_Exp += 0.5f;
            Our_RobotKyle_Exp += 0.5f;
            Our_UnityChan_Exp += 0.5f;
            Our_Satomi_Exp += 0.5f;
            Our_Arisa_Exp += 0.5f;
            Our_GamblerCat_Exp += 0.5f;
                Our_SopphiArt_Exp += 0.5f;

            Our_PBRCharacter_Coin_Value += 500;
            Our_RobotKyle_Coin_Value += 500;
            Our_UnityChan_Coin_Value += 500;
            Our_Satomi_Coin_Value += 500;
            Our_Arisa_Coin_Value += 500;
            Our_GamblerCat_Coin_Value += 500;
                Our_SopphiArt_Coin_Value += 500;

              

            StartCoroutine(Our_HP_Monster_Kill_Effect());
                Our_Hp_UI_Effect_Value = true;

                Our_Hp_Monster_Kill = false;
        }
        if (Our_Mp_Monster_Kill == true)
        {
            Our_PBRCharacter_Exp += 0.5f;
            Our_RobotKyle_Exp += 0.5f;
            Our_UnityChan_Exp += 0.5f;
            Our_Satomi_Exp += 0.5f;
            Our_Arisa_Exp += 0.5f;
            Our_GamblerCat_Exp += 0.5f;
                Our_SopphiArt_Exp += 0.5f;


            Our_PBRCharacter_Coin_Value += 500;
            Our_RobotKyle_Coin_Value += 500;
            Our_UnityChan_Coin_Value += 500;
            Our_Satomi_Coin_Value += 500;
            Our_Arisa_Coin_Value += 500;
            Our_GamblerCat_Coin_Value += 500;
                Our_SopphiArt_Coin_Value += 500;


               
            StartCoroutine(Our_MP_Monster_Kill_Effect());
            Our_Mp_Monster_Kill = false;
                Our_Mp_UI_Effect_Value = true;
            }




        if (Enemy_Albino_Dragon_Monster_Kill == true)
        {
            Enemy_Top_Player_Exp += 1.5f;
            Enemy_Middle_Player_Exp += 1.5f;
            Enemy_Jungle_Player_Exp += 1.5f;
            Enemy_Support_Player_Exp += 1.5f;
            Enemy_Bottom_Player_Exp += 1.5f;

            Enemy_Top_Coin_Value += 5000;
            Enemy_Middle_Coin_Value += 5000;
            Enemy_Jungle_Coin_Value += 5000;
            Enemy_Support_Coin_Value += 5000;
            Enemy_Bottom_Coin_Value += 5000;

            Enemy_Albino_Dragon_Monster_Kill = false;
        }
        if (Our_Albino_Dragon_Monster_Kill == true)
        {
            Our_PBRCharacter_Exp += 1.5f;
            Our_RobotKyle_Exp += 1.5f;
            Our_UnityChan_Exp += 1.5f;
            Our_Satomi_Exp += 1.5f;
            Our_Arisa_Exp += 1.5f;
            Our_GamblerCat_Exp += 1.5f;
                Our_SopphiArt_Exp += 1.5f;

            Our_PBRCharacter_Coin_Value += 5000;
            Our_RobotKyle_Coin_Value += 5000;
            Our_UnityChan_Coin_Value += 5000;
            Our_Satomi_Coin_Value += 5000;
            Our_Arisa_Coin_Value += 5000;
            Our_GamblerCat_Coin_Value += 5000;
                Our_SopphiArt_Coin_Value += 5000;
            Our_Albino_Dragon_Monster_Kill = false;
        }

            

        }
        catch (NullReferenceExcelltion ex)
        { }


        if (Enemy_Mp_UI_Effect_Value == true)
        {
            go_Enemy_Top_Mp_Effect.transform.position = new Vector3(go_Enemy_Top.position.x, go_Enemy_Top.position.y + 2f, go_Enemy_Top.position.z);
            go_Enemy_Middle_Mp_Effect.transform.position = new Vector3(go_Enemy_Middle.position.x, go_Enemy_Middle.position.y + 2f, go_Enemy_Middle.position.z);
            go_Enemy_Jungle_Mp_Effect.transform.position = new Vector3(go_Enemy_Jungle.position.x, go_Enemy_Jungle.position.y + 2f, go_Enemy_Jungle.position.z);
            go_Enemy_Bottom_Mp_Effect.transform.position = new Vector3(go_Enemy_Bottom.position.x, go_Enemy_Bottom.position.y + 2f, go_Enemy_Bottom.position.z);
            go_Enemy_Support_Mp_Effect.transform.position = new Vector3(go_Enemy_Support.position.x, go_Enemy_Support.position.y + 2f, go_Enemy_Support.position.z);
        }
        if (Enemy_Hp_UI_Effect_Value == true)
        { 
            go_Enemy_Top_Hp_Effect.transform.position = new Vector3(go_Enemy_Top.position.x, go_Enemy_Top.position.y + 2f, go_Enemy_Top.position.z);
            go_Enemy_Middle_Hp_Effect.transform.position = new Vector3(go_Enemy_Middle.position.x, go_Enemy_Middle.position.y + 2f, go_Enemy_Middle.position.z);
            go_Enemy_Jungle_Hp_Effect.transform.position = new Vector3(go_Enemy_Jungle.position.x, go_Enemy_Jungle.position.y + 2f, go_Enemy_Jungle.position.z);
            go_Enemy_Bottom_Hp_Effect.transform.position = new Vector3(go_Enemy_Bottom.position.x, go_Enemy_Bottom.position.y + 2f, go_Enemy_Bottom.position.z);
            go_Enemy_Support_Hp_Effect.transform.position = new Vector3(go_Enemy_Support.position.x, go_Enemy_Support.position.y + 2f, go_Enemy_Support.position.z);

        }

        if (Our_Hp_UI_Effect_Value == true)
        {
            go_Our_Top_Hp_Effect.transform.position = new Vector3(go_Our_Top.position.x, go_Our_Top.position.y + 2f, go_Our_Top.position.z);
            go_Our_Middle_Hp_Effect.transform.position = new Vector3(go_Our_Middle.position.x, go_Our_Middle.position.y + 2f, go_Our_Middle.position.z);
            go_Our_Jungle_Hp_Effect.transform.position = new Vector3(go_Our_Jungle.position.x, go_Our_Jungle.position.y + 2f, go_Our_Jungle.position.z);
            go_Our_Bottom_Hp_Effect.transform.position = new Vector3(go_Our_Bottom.position.x, go_Our_Bottom.position.y + 2f, go_Our_Bottom.position.z);
            go_Our_Support_Hp_Effect.transform.position = new Vector3(go_Our_Support.position.x, go_Our_Support.position.y + 2f, go_Our_Support.position.z);
        }
        if (Our_Mp_UI_Effect_Value == true)
        {
                go_Our_Top_Mp_Effect.transform.position = new Vector3(go_Our_Top.position.x, go_Our_Top.position.y + 2f, go_Our_Top.position.z);
            go_Our_Middle_Mp_Effect.transform.position = new Vector3(go_Our_Middle.position.x, go_Our_Middle.position.y + 2f, go_Our_Middle.position.z);
            go_Our_Jungle_Mp_Effect.transform.position = new Vector3(go_Our_Jungle.position.x, go_Our_Jungle.position.y + 2f, go_Our_Jungle.position.z);
            go_Our_Bottom_Mp_Effect.transform.position = new Vector3(go_Our_Bottom.position.x, go_Our_Bottom.position.y + 2f, go_Our_Bottom.position.z);
            go_Our_Support_Mp_Effect.transform.position = new Vector3(go_Our_Support.position.x, go_Our_Support.position.y + 2f, go_Our_Support.position.z);

        }

    }
    IEnumerator Enemy_HP_Monster_Kill_Effect()
    {
        try
        {
            go_Enemy_Top_Hp_Effect = Instantiate(Hp_Effect, go_Enemy_Top.position, Quaternion.identity);
            go_Enemy_Middle_Hp_Effect = Instantiate(Hp_Effect, go_Enemy_Middle.position, Quaternion.identity);
            go_Enemy_Jungle_Hp_Effect = Instantiate(Hp_Effect, go_Enemy_Jungle.position, Quaternion.identity);
            go_Enemy_Bottom_Hp_Effect = Instantiate(Hp_Effect, go_Enemy_Bottom.position, Quaternion.identity);
            go_Enemy_Support_Hp_Effect = Instantiate(Hp_Effect, go_Enemy_Support.position, Quaternion.identity);
        }
        catch (NullReferenceExcelltion ex)
        { }
        Enemy_Top_Player_Hp += 0.1f;
            Enemy_Middle_Player_Hp += 0.1f;
            Enemy_Jungle_Player_Hp += 0.1f;
            Enemy_Support_Player_Hp += 0.1f;
            Enemy_Bottom_Player_Hp += 0.1f;
            yield return new WaitForSeconds(1f);
            Enemy_Top_Player_Hp += 0.1f;
            Enemy_Middle_Player_Hp += 0.1f;
            Enemy_Jungle_Player_Hp += 0.1f;
            Enemy_Support_Player_Hp += 0.1f;
            Enemy_Bottom_Player_Hp += 0.1f;
            yield return new WaitForSeconds(1f);
            Enemy_Top_Player_Hp += 0.1f;
            Enemy_Middle_Player_Hp += 0.1f;
            Enemy_Jungle_Player_Hp += 0.1f;
            Enemy_Support_Player_Hp += 0.1f;
            Enemy_Bottom_Player_Hp += 0.1f;
            yield return new WaitForSeconds(1f);
            Enemy_Top_Player_Hp += 0.1f;
            Enemy_Middle_Player_Hp += 0.1f;
            Enemy_Jungle_Player_Hp += 0.1f;
            Enemy_Support_Player_Hp += 0.1f;
            Enemy_Bottom_Player_Hp += 0.1f;
            yield return new WaitForSeconds(1f);
            Enemy_Top_Player_Hp += 0.1f;
            Enemy_Middle_Player_Hp += 0.1f;
            Enemy_Jungle_Player_Hp += 0.1f;
            Enemy_Support_Player_Hp += 0.1f;
            Enemy_Bottom_Player_Hp += 0.1f;
            yield return new WaitForSeconds(1f);
            Enemy_Top_Player_Hp += 0.1f;
            Enemy_Middle_Player_Hp += 0.1f;
            Enemy_Jungle_Player_Hp += 0.1f;
            Enemy_Support_Player_Hp += 0.1f;
            Enemy_Bottom_Player_Hp += 0.1f;
        Enemy_Hp_UI_Effect_Value = false;

        Destroy(go_Enemy_Top_Hp_Effect);
            Destroy(go_Enemy_Middle_Hp_Effect);
            Destroy(go_Enemy_Jungle_Hp_Effect);
            Destroy(go_Enemy_Support_Hp_Effect);
            Destroy(go_Enemy_Bottom_Hp_Effect);
      

    }
    IEnumerator Our_HP_Monster_Kill_Effect()
    {
        try { 
        go_Our_Top_Hp_Effect = Instantiate(Hp_Effect, go_Our_Top.position, Quaternion.identity);
        go_Our_Middle_Hp_Effect = Instantiate(Hp_Effect, go_Our_Middle.position, Quaternion.identity);
        go_Our_Jungle_Hp_Effect = Instantiate(Hp_Effect, go_Our_Jungle.position, Quaternion.identity);
        go_Our_Bottom_Hp_Effect = Instantiate(Hp_Effect, go_Our_Bottom.position, Quaternion.identity);
        go_Our_Support_Hp_Effect = Instantiate(Hp_Effect, go_Our_Support.position, Quaternion.identity);
        }
        catch (NullReferenceExcelltion ex)
        { }
        Our_PBRCharacter_Hp += 0.1f;
        Our_UnityChan_Hp += 0.1f;
        Our_Satomi_Hp += 0.1f;
        Our_Arisa_Hp += 0.1f;
        Our_RobotKyle_Hp += 0.1f;
        Our_GamblerCat_Hp += 0.1f;
        Our_SopphiArt_Hp += 0.1f;


        yield return new WaitForSeconds(1f);
        Our_PBRCharacter_Hp += 0.1f;
        Our_UnityChan_Hp += 0.1f;
        Our_Satomi_Hp += 0.1f;
        Our_Arisa_Hp += 0.1f;
        Our_RobotKyle_Hp += 0.1f;
        Our_GamblerCat_Hp += 0.1f;
        Our_SopphiArt_Hp += 0.1f;
        

        yield return new WaitForSeconds(1f);
        Our_PBRCharacter_Hp += 0.1f;
        Our_UnityChan_Hp += 0.1f;
        Our_Satomi_Hp += 0.1f;
        Our_Arisa_Hp += 0.1f;
        Our_RobotKyle_Hp += 0.1f;
        Our_GamblerCat_Hp += 0.1f;
        Our_SopphiArt_Hp += 0.1f;
        yield return new WaitForSeconds(1f);
        Our_PBRCharacter_Hp += 0.1f;
        Our_UnityChan_Hp += 0.1f;
        Our_Satomi_Hp += 0.1f;
        Our_Arisa_Hp += 0.1f;
        Our_RobotKyle_Hp += 0.1f;
        Our_GamblerCat_Hp += 0.1f;
        Our_SopphiArt_Hp += 0.1f;
        yield return new WaitForSeconds(1f);
        Our_PBRCharacter_Hp += 0.1f;
        Our_UnityChan_Hp += 0.1f;
        Our_Satomi_Hp += 0.1f;
        Our_Arisa_Hp += 0.1f;
        Our_RobotKyle_Hp += 0.1f;
        Our_GamblerCat_Hp += 0.1f;
        Our_SopphiArt_Hp += 0.1f;
        yield return new WaitForSeconds(1f);
        Our_PBRCharacter_Hp += 0.1f;
        Our_UnityChan_Hp += 0.1f;
        Our_Satomi_Hp += 0.1f;
        Our_Arisa_Hp += 0.1f;
        Our_RobotKyle_Hp += 0.1f;
        Our_GamblerCat_Hp += 0.1f;
        Our_SopphiArt_Hp += 0.1f;
        Our_Hp_UI_Effect_Value = false;
        Destroy(go_Our_Top_Hp_Effect);
        Destroy(go_Our_Middle_Hp_Effect);
        Destroy(go_Our_Jungle_Hp_Effect);
        Destroy(go_Our_Support_Hp_Effect);
        Destroy(go_Our_Bottom_Hp_Effect);


     
    }
    IEnumerator Enemy_MP_Monster_Kill_Effect()
    {
        try {
            go_Enemy_Top_Mp_Effect = Instantiate(Mp_Effect, go_Enemy_Top.position, Quaternion.identity);
            go_Enemy_Middle_Mp_Effect = Instantiate(Mp_Effect, go_Enemy_Middle.position, Quaternion.identity);
            go_Enemy_Jungle_Mp_Effect = Instantiate(Mp_Effect, go_Enemy_Jungle.position, Quaternion.identity);
            go_Enemy_Bottom_Mp_Effect = Instantiate(Mp_Effect, go_Enemy_Bottom.position, Quaternion.identity);
            go_Enemy_Support_Mp_Effect = Instantiate(Mp_Effect, go_Enemy_Support.position, Quaternion.identity);
        }
        catch (NullReferenceExcelltion ex)
        { }
        Enemy_Top_Player_Mp += 0.1f;
        Enemy_Middle_Player_Mp += 0.1f;
        Enemy_Jungle_Player_Mp += 0.1f;
        Enemy_Support_Player_Mp += 0.1f;
        Enemy_Bottom_Player_Mp += 0.1f;
        yield return new WaitForSeconds(1f);
        Enemy_Top_Player_Mp += 0.1f;
        Enemy_Middle_Player_Mp += 0.1f;
        Enemy_Jungle_Player_Mp += 0.1f;
        Enemy_Support_Player_Mp += 0.1f;
        Enemy_Bottom_Player_Mp += 0.1f;
        yield return new WaitForSeconds(1f);
        Enemy_Top_Player_Mp += 0.1f;
        Enemy_Middle_Player_Mp += 0.1f;
        Enemy_Jungle_Player_Mp += 0.1f;
        Enemy_Support_Player_Mp += 0.1f;
        Enemy_Bottom_Player_Mp += 0.1f;
        yield return new WaitForSeconds(1f);
        Enemy_Top_Player_Mp += 0.1f;
        Enemy_Middle_Player_Mp += 0.1f;
        Enemy_Jungle_Player_Mp += 0.1f;
        Enemy_Support_Player_Mp += 0.1f;
        Enemy_Bottom_Player_Mp += 0.1f;
        yield return new WaitForSeconds(1f);
        Enemy_Top_Player_Mp += 0.1f;
        Enemy_Middle_Player_Mp += 0.1f;
        Enemy_Jungle_Player_Mp += 0.1f;
        Enemy_Support_Player_Mp += 0.1f;
        Enemy_Bottom_Player_Mp += 0.1f;
        yield return new WaitForSeconds(1f);
        Enemy_Top_Player_Mp += 0.1f;
        Enemy_Middle_Player_Mp += 0.1f;
        Enemy_Jungle_Player_Mp += 0.1f;
        Enemy_Support_Player_Mp += 0.1f;
        Enemy_Bottom_Player_Mp += 0.1f;
        Enemy_Mp_UI_Effect_Value = false;

        Destroy(go_Enemy_Top_Mp_Effect);
        Destroy(go_Enemy_Middle_Mp_Effect);
        Destroy(go_Enemy_Jungle_Mp_Effect);
        Destroy(go_Enemy_Support_Mp_Effect);
        Destroy(go_Enemy_Bottom_Mp_Effect);
      
    }
    IEnumerator Our_MP_Monster_Kill_Effect()
    {
        try {
            go_Our_Top_Mp_Effect = Instantiate(Mp_Effect, go_Our_Top.position, Quaternion.identity);
            go_Our_Middle_Mp_Effect = Instantiate(Mp_Effect, go_Our_Middle.position, Quaternion.identity);
            go_Our_Jungle_Mp_Effect = Instantiate(Mp_Effect, go_Our_Jungle.position, Quaternion.identity);
            go_Our_Bottom_Mp_Effect = Instantiate(Mp_Effect, go_Our_Bottom.position, Quaternion.identity);
            go_Our_Support_Mp_Effect = Instantiate(Mp_Effect, go_Our_Support.position, Quaternion.identity);
        }
        catch (NullReferenceExcelltion ex)
        { }
        Our_PBRCharacter_Mp += 0.1f;
        Our_UnityChan_Mp += 0.1f;
        Our_Satomi_Mp += 0.1f;
        Our_Arisa_Mp += 0.1f;
        Our_RobotKyle_Mp += 0.1f;
        Our_GamblerCat_Mp += 0.1f;
        Our_SopphiArt_Mp += 0.1f;

        yield return new WaitForSeconds(1f);
        Our_PBRCharacter_Mp += 0.1f;
        Our_UnityChan_Mp += 0.1f;
        Our_Satomi_Mp += 0.1f;
        Our_Arisa_Mp += 0.1f;
        Our_RobotKyle_Mp += 0.1f;
        Our_GamblerCat_Mp += 0.1f;
        Our_SopphiArt_Mp += 0.1f;
        yield return new WaitForSeconds(1f);
        Our_PBRCharacter_Mp += 0.1f;
        Our_UnityChan_Mp += 0.1f;
        Our_Satomi_Mp += 0.1f;
        Our_Arisa_Mp += 0.1f;
        Our_RobotKyle_Mp += 0.1f;
        Our_GamblerCat_Mp += 0.1f;
        Our_SopphiArt_Mp += 0.1f;
        yield return new WaitForSeconds(1f);
        Our_PBRCharacter_Mp += 0.1f;
        Our_UnityChan_Mp += 0.1f;
        Our_Satomi_Mp += 0.1f;
        Our_Arisa_Mp += 0.1f;
        Our_RobotKyle_Mp += 0.1f;
        Our_GamblerCat_Mp += 0.1f;
        Our_SopphiArt_Mp += 0.1f;
        yield return new WaitForSeconds(1f);
        Our_PBRCharacter_Mp += 0.1f;
        Our_UnityChan_Mp += 0.1f;
        Our_Satomi_Mp += 0.1f;
        Our_Arisa_Mp += 0.1f;
        Our_RobotKyle_Mp += 0.1f;
        Our_GamblerCat_Mp += 0.1f;
        Our_SopphiArt_Mp += 0.1f;
        yield return new WaitForSeconds(1f);
        Our_PBRCharacter_Mp += 0.1f;
        Our_UnityChan_Mp += 0.1f;
        Our_Satomi_Mp += 0.1f;
        Our_Arisa_Mp += 0.1f;
        Our_RobotKyle_Mp += 0.1f;
        Our_GamblerCat_Mp += 0.1f;
        Our_SopphiArt_Mp += 0.1f;
        Our_Mp_UI_Effect_Value = false;

        Destroy(go_Our_Top_Mp_Effect);
        Destroy(go_Our_Middle_Mp_Effect);
        Destroy(go_Our_Jungle_Mp_Effect);
        Destroy(go_Our_Support_Mp_Effect);
        Destroy(go_Our_Bottom_Mp_Effect);



    }
}
