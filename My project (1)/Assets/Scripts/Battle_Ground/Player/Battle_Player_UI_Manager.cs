using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Battle_Player_UI_Manager : MonoBehaviour
{
    public static Battle_Player_UI_Manager Instance;


    public Transform Player_Revive_pos;
    GameObject player;
    GameObject player_UI;

    public float Enemy_Demage = 0;

    public bool Monster_Attack= false;
    public bool Hp_Monster_Kill = false;
    public bool Mp_Monster_Kill = false;
    public bool Albino_Dragon_Monster_Kill = false;
    public bool Enemy_Left_Minion_Kill = false;


    public bool Player_hit_Judgment = false;
    public bool Minion_hit_Judgment = false;

    GameObject go;
    GameObject go_UI;

    public GameObject Hp_Effect;
    public GameObject Mp_Effect;

    Transform Player_Transform;

    public Text Coin_Value_Text;




    public int Approach_Attack_Total_Value = 0;
    public int Throw_Attack_Total_Value = 0;
    public int Onehand_Attack_Total_Value = 0;
    public int Twohand_Attack_Total_Value = 0;
    public int Approach_Defence_Total_Value = 0;
    public int Throw_Defence_Total_Value = 0;
    public int Onehand_Defence_Total_Value = 0;
    public int Twohand_Defence_Total_Value = 0;
    public int Approach_Magic_Total_Value = 0;
    public int Throw_Magic_Total_Value = 0;
    public int Onehand_Magic_Total_Value = 0;
    public int Twohand_Magic_Total_Value = 0;
    public int Approach_Speed_Total_Value = 0;
    public int Throw_Speed_Total_Value = 0;
    public int Onehand_Speed_Total_Value = 0;
    public int Twohand_Speed_Total_Value = 0;

    public int Approach_Attack_Basic_Value = 0;
    public int Throw_Attack_Basic_Value = 0;
    public int Onehand_Attack_Basic_Value = 0;
    public int Twohand_Attack_Basic_Value = 0;
    public int Approach_Defence_Basic_Value = 0;
    public int Throw_Defence_Basic_Value = 0;
    public int Onehand_Defence_Basic_Value = 0;
    public int Twohand_Defence_Basic_Value = 0;
    public int Approach_Magic_Basic_Value = 0;
    public int Throw_Magic_Basic_Value = 0;
    public int Onehand_Magic_Basic_Value = 0;
    public int Twohand_Magic_Basic_Value = 0;
    public int Approach_Speed_Basic_Value = 0;
    public int Throw_Speed_Basic_Value = 0;
    public int Onehand_Speed_Basic_Value = 0;
    public int Twohand_Speed_Basic_Value = 0;

    public int Approach_Attack_Add_Value = 0;
    public int Throw_Attack_Add_Value = 0;
    public int Onehand_Attack_Add_Value = 0;
    public int Twohand_Attack_Add_Value = 0;
    public int Approach_Defence_Add_Value = 0;
    public int Throw_Defence_Add_Value = 0;
    public int Onehand_Defence_Add_Value = 0;
    public int Twohand_Defence_Add_Value = 0;
    public int Approach_Magic_Add_Value = 0;
    public int Throw_Magic_Add_Value = 0;
    public int Onehand_Magic_Add_Value = 0;
    public int Twohand_Magic_Add_Value = 0;
    public int Approach_Speed_Add_Value = 0;
    public int Throw_Speed_Add_Value = 0;
    public int Onehand_Speed_Add_Value = 0;
    public int Twohand_Speed_Add_Value = 0;

    public bool Poshin_Hp_Get_Value = false;
    public bool Poshin_Mp_Get_Value = false;
    public bool Poshin_Exp_Get_Value = false;
    public bool Item_Storage_Empty = false;

    public bool Poshin_Hp_Use_Value = false;
    public bool Poshin_Mp_Use_Value = false;
    public bool Poshin_Exp_Use_Value = false;
    
   

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }


    void Update()
    {
        Player_Camera_Instance();
        Monster_Attack_Demage();
        Player_Status();
        Player_Get_Item();
    }



    void Player_Get_Item()
    {
        if (Poshin_Hp_Get_Value == false &&
            Poshin_Mp_Get_Value == false &&
            Poshin_Exp_Get_Value == false)
            Item_Storage_Empty = false;
        else
            Item_Storage_Empty = true;

        if(Poshin_Exp_Use_Value == true)
            StartCoroutine(Exp_Poshion_Effect());
        else if (Poshin_Mp_Use_Value == true)
            StartCoroutine(Mp_Poshion_Effect());
        else if (Poshin_Hp_Use_Value == true)
            StartCoroutine(Hp_Poshion_Effect());



    }
    IEnumerator Hp_Poshion_Effect()
    {


        Poshin_Hp_Use_Value = false;
        SoundManager.Instance.PlaySFXSound("Poshion_Eating_Sound", 1f);

        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(1f);
            if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_UnityChan(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_UnityChan_Hp += 3f * Time.deltaTime;
           else  if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_PBRCharacter(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Hp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Satomi(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_Satomi_Hp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Arisa(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_Arisa_Hp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_RobotKyle(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_RobotKyle_Hp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_GamblerCat(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_GamblerCat_Hp += 3f * Time.deltaTime;
        }
    }

    IEnumerator Mp_Poshion_Effect()
    {
        Poshin_Mp_Use_Value = false;
        SoundManager.Instance.PlaySFXSound("Poshion_Eating_Sound", 1f);

        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(1f);
            if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_UnityChan(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_UnityChan_Mp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_PBRCharacter(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Mp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Satomi(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_Satomi_Mp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Arisa(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_Arisa_Mp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_RobotKyle(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_RobotKyle_Mp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_GamblerCat(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_GamblerCat_Mp += 3f * Time.deltaTime;

        }
    }

    IEnumerator Exp_Poshion_Effect()
    {
        Poshin_Exp_Use_Value = false;
        SoundManager.Instance.PlaySFXSound("Poshion_Eating_Sound", 1f);

        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(1f);
            if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_UnityChan(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_UnityChan_Exp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_PBRCharacter(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Exp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Satomi(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_Satomi_Exp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_Arisa(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_Arisa_Exp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_RobotKyle(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_RobotKyle_Exp += 3f * Time.deltaTime;
            else if (GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).name == "Our_GamblerCat(Clone)")
                Enemy_Player_UI_Manager.Instance.Our_GamblerCat_Exp += 3f * Time.deltaTime;

        }
    }

    void Player_Camera_Instance()
    {
        if ((SceneManager.GetActiveScene().name == "Battle_Background"))
        {
            int Player_Count;
            string Player_Obj_Tag = Character_Select.Instance.Player_Character_Tag;
            GameObject[] Player_count = GameObject.FindGameObjectsWithTag(Character_Select.Instance.Player_Character_Tag);

            Player_Count = Player_count.Length;


            if (Player_Count < 1)
            {
                Enemy_Player_UI_Manager.Instance.Our_Player_Hp = 1f;
                Enemy_Player_UI_Manager.Instance.Our_Player_Mp = 1f;

                if (Character_Select.Instance.Player_Character_Tag == "Our_Top")
                {
                   player = Resources.Load<GameObject>(Character_Select.Instance.Our_Top_Character);
                    go = Instantiate(player, Player_Revive_pos.position, Quaternion.identity);
                    go.gameObject.tag = "Our_Top";
                    go.layer = LayerMask.NameToLayer("Our");
                }
                else if (Character_Select.Instance.Player_Character_Tag == "Our_Middle")
                {
                   player = Resources.Load<GameObject>(Character_Select.Instance.Our_Middle_Character);
                    go = Instantiate(player, Player_Revive_pos.position, Quaternion.identity);
                    go.gameObject.tag = "Our_Middle";
                    go.layer = LayerMask.NameToLayer("Our");
                }
                else if (Character_Select.Instance.Player_Character_Tag == "Our_Bottom")
                {
                   player = Resources.Load<GameObject>(Character_Select.Instance.Our_Bottom_Character);
                    go = Instantiate(player, Player_Revive_pos.position, Quaternion.identity);
                    go.gameObject.tag = "Our_Bottom";
                    go.layer = LayerMask.NameToLayer("Our");
                }
                else if (Character_Select.Instance.Player_Character_Tag == "Our_Support")
                {
                  player = Resources.Load<GameObject>(Character_Select.Instance.Our_Support_Character);
                    go = Instantiate(player, Player_Revive_pos.position, Quaternion.identity);
                    go.gameObject.tag = "Our_Support";
                    go.layer = LayerMask.NameToLayer("Our");
                }
                else if (Character_Select.Instance.Player_Character_Tag == "Our_Jungle")
                {
                   player = Resources.Load<GameObject>(Character_Select.Instance.Our_Jungle_Character);
                    go = Instantiate(player, Player_Revive_pos.position, Quaternion.identity);
                    go.gameObject.tag = "Our_Jungle";
                    go.layer = LayerMask.NameToLayer("Our");
                }
                player_UI = Resources.Load<GameObject>("Player_UI");
                go_UI = Instantiate(player_UI, Player_Revive_pos.position, Quaternion.identity);




                if (go.name == "Our_UnityChan(Clone)")
                {
                    go.gameObject.GetComponent<Our_UnityChan_AI_FSM>().enabled = false;
                    go.gameObject.GetComponent<PlayerMove>().enabled = true;
                    Enemy_Player_UI_Manager.Instance.Our_UnityChan_Hp = 1f;
                    Enemy_Player_UI_Manager.Instance.Our_UnityChan_Mp = 1f;
                }
                else if (go.name == "Our_PBRCharacter(Clone)")
                {
                    go.gameObject.GetComponent<Our_PBRCharacter_AI_FSM>().enabled = false;
                    go.gameObject.GetComponent<Player_PBRCharacter>().enabled = true;
                    Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Hp = 1f;
                    Enemy_Player_UI_Manager.Instance.Our_PBRCharacter_Mp = 1f;
                }
                else if (go.name == "Our_RobotKyle(Clone)")
                {
                    go.gameObject.GetComponent<Our_Robotkyle_AI_FSM>().enabled = false;
                    go.gameObject.GetComponent<Player_RobotKyle>().enabled = true;
                    Enemy_Player_UI_Manager.Instance.Our_RobotKyle_Hp = 1f;
                    Enemy_Player_UI_Manager.Instance.Our_RobotKyle_Mp = 1f;
                }

                else if (go.name == "Our_Satomi(Clone)")
                {
                    go.gameObject.GetComponent<Our_Satomi_AI_FSM>().enabled = false;
                    go.gameObject.GetComponent<Player_Satomi>().enabled = true;
                    Enemy_Player_UI_Manager.Instance.Our_Satomi_Hp = 1f;
                    Enemy_Player_UI_Manager.Instance.Our_Satomi_Mp = 1f;
                }
                else if (go.name == "Our_Arisa(Clone)")
                {
                    go.gameObject.GetComponent<Our_Arisa_AI_FSM>().enabled = false;
                    go.gameObject.GetComponent<Player_Arisa>().enabled = true;
                    Enemy_Player_UI_Manager.Instance.Our_Arisa_Hp = 1f;
                    Enemy_Player_UI_Manager.Instance.Our_Arisa_Mp = 1f;
                }

                else if (go.name == "Our_SopphiArt(Clone)")
                {
                    go.gameObject.GetComponent<Player_SapphiArtchan>().enabled = true;
                    Enemy_Player_UI_Manager.Instance.Our_SopphiArt_Hp = 1f;
                    Enemy_Player_UI_Manager.Instance.Our_SopphiArt_Mp = 1f;
                }




            }


        }
    }
    void Monster_Attack_Demage()
    {
        try
        {
            Enemy_Player_UI_Manager.Instance.Our_Player_Hp -= (Enemy_Demage * Time.deltaTime);
            Player_Transform = GameObject.FindWithTag(Character_Select.Instance.Player_Character_Tag).transform;

            if (Enemy_Demage > 0)
            {

                Enemy_Demage = 0;
            }

            if(Enemy_Player_UI_Manager.Instance.Our_Player_Hp <= 0)
            {
                Destroy(go,1f);
                Destroy(go_UI, 0.5f);

            }

        }

        catch (NullReferenceException ex)
        {
        }
    }
    void Player_Status()
    {

        Coin_Value_Text.text = "" + Enemy_Player_UI_Manager.Instance.Our_Player_Coin_Value;


        Approach_Attack_Total_Value = Approach_Attack_Basic_Value + Approach_Attack_Add_Value;
        Throw_Attack_Total_Value = Throw_Attack_Basic_Value + Throw_Attack_Add_Value;
        Onehand_Attack_Total_Value = Onehand_Attack_Basic_Value + Onehand_Attack_Add_Value;
        Twohand_Attack_Total_Value = Twohand_Attack_Basic_Value + Twohand_Attack_Add_Value;
        Approach_Defence_Total_Value = Approach_Defence_Basic_Value + Approach_Defence_Add_Value;
        Throw_Defence_Total_Value = Throw_Defence_Basic_Value + Throw_Defence_Add_Value; 
        Onehand_Defence_Total_Value =  Onehand_Defence_Basic_Value + Onehand_Defence_Add_Value;
        Twohand_Defence_Total_Value  = Twohand_Defence_Basic_Value + Twohand_Defence_Add_Value;
        Approach_Magic_Total_Value = Approach_Magic_Basic_Value + Approach_Magic_Add_Value;
        Throw_Magic_Total_Value =  Throw_Magic_Basic_Value + Throw_Magic_Add_Value;
        Onehand_Magic_Total_Value = Onehand_Magic_Basic_Value + Onehand_Magic_Add_Value;
        Twohand_Magic_Total_Value = Twohand_Magic_Basic_Value + Twohand_Magic_Add_Value;
        Approach_Speed_Total_Value = Approach_Speed_Basic_Value + Approach_Speed_Add_Value;
        Throw_Speed_Total_Value = Throw_Speed_Basic_Value + Throw_Speed_Add_Value;
        Onehand_Speed_Total_Value = Onehand_Speed_Basic_Value + Onehand_Speed_Add_Value;
        Twohand_Speed_Total_Value = Twohand_Speed_Basic_Value + Twohand_Speed_Add_Value; 

    }
   

   

}
