using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Status : MonoBehaviour
{

    public static Player_Status Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;

    }

    public Image[] Player_Skill = new Image[4];

    public Image[] Skill_Item = new Image[32];

    public int[] Player_Skill_Value = new int[4];

    public Text[] Player_Status_Values_Text = new Text[16];
    public int[] Player_Status_Values = new int[16];
    public int[] Player_Status_Basic_Values = new int[16];


    public bool[] Player_Status_Add_Input_Values = new bool[32];
    public int[] Player_Status_Add_Values = new int[32];
    public int[] Player_Status_Add_Total_Values = new int[16];


    public int[] Skil_Item_Cost_Values = new int[32];

    public int[] Player_Status_Cost_Values = new int[4];

    public bool Basic_Attack_Value = false;
    public bool Skill_Attack1_Value = false;
    public bool Skill_Attack2_Value = false;
    public bool Skill_Attack3_Value = false;

    public Image[] Player_Skill_Level_Select = new Image[3];
    public Image[] Player_Skill1_Level = new Image[4];
    public float Player_Skill1_Level_Value = 0;
    public Image[] Player_Skill2_Level = new Image[4];
    public float Player_Skill2_Level_Value = 0;
    public Image[] Player_Skill3_Level = new Image[4];
    public float Player_Skill3_Level_Value = 0;
    public int Level_Up_Check = 1;

    public Image Player_Skill1_CoolTime;
    public int Player_Skill1_CoolTime_Value = 0;
    public Text Player_Skill1_CoolTime_Text;
    public Image Player_Skill2_CoolTime;
    public int Player_Skill2_CoolTime_Value = 0;
    public Text Player_Skill2_CoolTime_Text;
    public Image Player_Skill3_CoolTime;
    public int Player_Skill3_CoolTime_Value = 0;
    public Text Player_Skill3_CoolTime_Text;

    public Image[] Player_Attack_Skill = new Image[3];
   
    

    void Start()
    {
        Skill_Item_Icon_Explain_Content();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 1; j < 33; j++)
            {
                if (Skill_Item_Manager.Instance.Skill_Item_Inventory_array[i] == j)
                {
                    Player_Skill_Value[i] = j - 1;
                    Player_Skill[i].GetComponent<Image>().sprite = Skill_Item[j - 1].GetComponent<Image>().sprite;
                    Player_Status_Cost_Values[i] = Skil_Item_Cost_Values[j - 1];
                    Player_Status_Add_Input_Values[j - 1] = false;
                }

            }
        }

        for (int i = 0; i < 3; i++)
        {
            Player_Attack_Skill[i].GetComponent<Image>().sprite =
                   Character_Select.Instance.Character_Attack_Skill_Zip[Character_Select.Instance.Character_Attack_Skill_Value[i]].GetComponent<Image>().sprite;
        }

    }

    void Update()
    {
        Player_Status_Total_Value();
        Player_Skill_Level_Up_Select();
        for (int i = 0; i < 3; i++)
        {
            Player_Attack_Skill[i].GetComponent<Image>().sprite =
                Character_Select.Instance.Character_Attack_Skill_Zip[Character_Select.Instance.Character_Attack_Skill_Value[i]].GetComponent<Image>().sprite;
        }
    }
    void Player_Status_Total_Value()
    {
        Player_Status_Add_Value();

        Player_Status_Values[0] = Battle_Player_UI_Manager.Instance.Approach_Attack_Total_Value;
        Player_Status_Values[1] = Battle_Player_UI_Manager.Instance.Throw_Attack_Total_Value;
        Player_Status_Values[2] = Battle_Player_UI_Manager.Instance.Onehand_Attack_Total_Value;
        Player_Status_Values[3] = Battle_Player_UI_Manager.Instance.Twohand_Attack_Total_Value;
        Player_Status_Values[4] = Battle_Player_UI_Manager.Instance.Approach_Defence_Total_Value;
        Player_Status_Values[5] = Battle_Player_UI_Manager.Instance.Throw_Defence_Total_Value;
        Player_Status_Values[6] = Battle_Player_UI_Manager.Instance.Onehand_Defence_Total_Value;
        Player_Status_Values[7] = Battle_Player_UI_Manager.Instance.Twohand_Defence_Total_Value;
        Player_Status_Values[8] = Battle_Player_UI_Manager.Instance.Approach_Magic_Total_Value;
        Player_Status_Values[9] = Battle_Player_UI_Manager.Instance.Throw_Magic_Total_Value;
        Player_Status_Values[10] = Battle_Player_UI_Manager.Instance.Onehand_Magic_Total_Value;
        Player_Status_Values[11] = Battle_Player_UI_Manager.Instance.Twohand_Magic_Total_Value;
        Player_Status_Values[12] = Battle_Player_UI_Manager.Instance.Approach_Speed_Total_Value;
        Player_Status_Values[13] = Battle_Player_UI_Manager.Instance.Throw_Speed_Total_Value;
        Player_Status_Values[14] = Battle_Player_UI_Manager.Instance.Onehand_Speed_Total_Value;
        Player_Status_Values[15] = Battle_Player_UI_Manager.Instance.Twohand_Speed_Total_Value;


        Player_Status_Add_Total_Values[0] = Battle_Player_UI_Manager.Instance.Approach_Attack_Add_Value;
        Player_Status_Add_Total_Values[1] = Battle_Player_UI_Manager.Instance.Throw_Attack_Add_Value;
        Player_Status_Add_Total_Values[2] = Battle_Player_UI_Manager.Instance.Onehand_Attack_Add_Value;
        Player_Status_Add_Total_Values[3] = Battle_Player_UI_Manager.Instance.Twohand_Attack_Add_Value;
        Player_Status_Add_Total_Values[4] = Battle_Player_UI_Manager.Instance.Approach_Defence_Add_Value;
        Player_Status_Add_Total_Values[5] = Battle_Player_UI_Manager.Instance.Throw_Defence_Add_Value;
        Player_Status_Add_Total_Values[6] = Battle_Player_UI_Manager.Instance.Onehand_Defence_Add_Value;
        Player_Status_Add_Total_Values[7] = Battle_Player_UI_Manager.Instance.Twohand_Defence_Add_Value;
        Player_Status_Add_Total_Values[8] = Battle_Player_UI_Manager.Instance.Approach_Magic_Add_Value;
        Player_Status_Add_Total_Values[9] = Battle_Player_UI_Manager.Instance.Throw_Magic_Add_Value;
        Player_Status_Add_Total_Values[10] = Battle_Player_UI_Manager.Instance.Onehand_Magic_Add_Value;
        Player_Status_Add_Total_Values[11] = Battle_Player_UI_Manager.Instance.Twohand_Magic_Add_Value;
        Player_Status_Add_Total_Values[12] = Battle_Player_UI_Manager.Instance.Approach_Speed_Add_Value;
        Player_Status_Add_Total_Values[13] = Battle_Player_UI_Manager.Instance.Throw_Speed_Add_Value;
        Player_Status_Add_Total_Values[14] = Battle_Player_UI_Manager.Instance.Onehand_Speed_Add_Value;
        Player_Status_Add_Total_Values[15] = Battle_Player_UI_Manager.Instance.Twohand_Speed_Add_Value;

        Player_Status_Basic_Values[0] = Battle_Player_UI_Manager.Instance.Approach_Attack_Basic_Value;
        Player_Status_Basic_Values[1] = Battle_Player_UI_Manager.Instance.Throw_Attack_Basic_Value;
        Player_Status_Basic_Values[2] = Battle_Player_UI_Manager.Instance.Onehand_Attack_Basic_Value;
        Player_Status_Basic_Values[3] = Battle_Player_UI_Manager.Instance.Twohand_Attack_Basic_Value;
        Player_Status_Basic_Values[4] = Battle_Player_UI_Manager.Instance.Approach_Defence_Basic_Value;
        Player_Status_Basic_Values[5] = Battle_Player_UI_Manager.Instance.Throw_Defence_Basic_Value;
        Player_Status_Basic_Values[6] = Battle_Player_UI_Manager.Instance.Onehand_Defence_Basic_Value;
        Player_Status_Basic_Values[7] = Battle_Player_UI_Manager.Instance.Twohand_Defence_Basic_Value;
        Player_Status_Basic_Values[8] = Battle_Player_UI_Manager.Instance.Approach_Magic_Basic_Value;
        Player_Status_Basic_Values[9] = Battle_Player_UI_Manager.Instance.Throw_Magic_Basic_Value;
        Player_Status_Basic_Values[10] = Battle_Player_UI_Manager.Instance.Onehand_Magic_Basic_Value;
        Player_Status_Basic_Values[11] = Battle_Player_UI_Manager.Instance.Twohand_Magic_Basic_Value;
        Player_Status_Basic_Values[12] = Battle_Player_UI_Manager.Instance.Approach_Speed_Basic_Value;
        Player_Status_Basic_Values[13] = Battle_Player_UI_Manager.Instance.Throw_Speed_Basic_Value;
        Player_Status_Basic_Values[14] = Battle_Player_UI_Manager.Instance.Onehand_Speed_Basic_Value;
        Player_Status_Basic_Values[15] = Battle_Player_UI_Manager.Instance.Twohand_Speed_Basic_Value;



        for (int k = 0; k < 16; k++)
            Player_Status_Values_Text[k].text = "" +
                Player_Status_Values[k] +
                "(" + "<color=yellow>" +
                Player_Status_Basic_Values[k] +
                "</color> " + "+" + "<color=red>" +
                Player_Status_Add_Total_Values[k] + "</color>)";



    }

    void Player_Skill_Level_Up_Select()
    {
        if (Enemy_Player_UI_Manager.Instance.Our_Player_Level > Level_Up_Check)
        {
            Level_Up_Check += 1;
            for (int i = 0; i < 3; i++)
                Player_Skill_Level_Select[i].GetComponent<RectTransform>().SetAsLastSibling();
        }

        if (Player_Skill1_Level_Value == 1)
        {
            Color color = Player_Skill1_Level[0].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill1_Level[0].GetComponent<Image>().color = color;
        }
        else if (Player_Skill1_Level_Value == 2)
        {
            Color color = Player_Skill1_Level[1].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill1_Level[1].GetComponent<Image>().color = color;
        }
        else if (Player_Skill1_Level_Value == 3)
        {
            Color color = Player_Skill1_Level[2].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill1_Level[2].GetComponent<Image>().color = color;
        }
        else if (Player_Skill1_Level_Value == 4)
        {
            Color color = Player_Skill1_Level[3].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill1_Level[3].GetComponent<Image>().color = color;
        }

        if (Player_Skill2_Level_Value == 1)
        {

            Color color = Player_Skill2_Level[0].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill2_Level[0].GetComponent<Image>().color = color;
        }
        else if (Player_Skill2_Level_Value == 2)
        {
            Color color = Player_Skill2_Level[1].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill2_Level[1].GetComponent<Image>().color = color;
        }
        else if (Player_Skill2_Level_Value == 3)
        {
            Color color = Player_Skill2_Level[2].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill2_Level[2].GetComponent<Image>().color = color;
        }
        else if (Player_Skill2_Level_Value == 4)
        {
            Color color = Player_Skill2_Level[3].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill2_Level[3].GetComponent<Image>().color = color;
        }
        if (Player_Skill3_Level_Value == 1)
        {

            Color color = Player_Skill3_Level[0].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill3_Level[0].GetComponent<Image>().color = color;
        }
        else if (Player_Skill3_Level_Value == 2)
        {
            Color color = Player_Skill3_Level[1].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill3_Level[1].GetComponent<Image>().color = color;
        }
        else if (Player_Skill3_Level_Value == 3)
        {
            Color color = Player_Skill3_Level[2].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill3_Level[2].GetComponent<Image>().color = color;
        }
        else if (Player_Skill3_Level_Value == 4)
        {
            Color color = Player_Skill3_Level[3].GetComponent<Image>().color;
            color = new Color(255, 255, 0);
            Player_Skill3_Level[3].GetComponent<Image>().color = color;
        }
    }
   
    public IEnumerator Player_Skill1_CoolTime_Start(float cool)
    {
        Player_Skill1_CoolTime.GetComponent<RectTransform>().SetAsLastSibling();
        while (cool > 1.0f)
        {
            if (Enemy_Player_UI_Manager.Instance.Our_Player_Hp <= 0)
                cool = 0f;
            cool -= Time.deltaTime;
            Player_Skill1_CoolTime.fillAmount = 1f-(1.0f / cool);
            Player_Skill1_CoolTime_Value = (int)cool;
            Player_Skill1_CoolTime_Text.text = "" + Player_Skill1_CoolTime_Value;
           
            yield return new WaitForFixedUpdate();
        }
        Player_Skill1_CoolTime.GetComponent<RectTransform>().SetAsFirstSibling();

    }
    public IEnumerator Player_Skill2_CoolTime_Start(float cool)
    {
        Player_Skill2_CoolTime.GetComponent<RectTransform>().SetAsLastSibling();

        while (cool > 1.0f)
        {
            if (Enemy_Player_UI_Manager.Instance.Our_Player_Hp <= 0)
                cool = 0f;
            cool -= Time.deltaTime;
            Player_Skill2_CoolTime.fillAmount = 1f - (1.0f / cool);
            Player_Skill2_CoolTime_Value = (int)cool;
            Player_Skill2_CoolTime_Text.text = "" + Player_Skill2_CoolTime_Value;
            
            yield return new WaitForFixedUpdate();

        }
        Player_Skill2_CoolTime.GetComponent<RectTransform>().SetAsFirstSibling();

    }
    public IEnumerator Player_Skill3_CoolTime_Start(float cool)
    {
        Player_Skill3_CoolTime.GetComponent<RectTransform>().SetAsLastSibling();

        while (cool > 1.0f)
        {
            if (Enemy_Player_UI_Manager.Instance.Our_Player_Hp <= 0)
                cool = 0f;
            cool -= Time.deltaTime;
            Player_Skill3_CoolTime.fillAmount = 1f - (1.0f / cool);
            Player_Skill3_CoolTime_Value = (int)cool;
            Player_Skill3_CoolTime_Text.text = "" + Player_Skill3_CoolTime_Value;
            
            yield return new WaitForFixedUpdate();

        }
        Player_Skill3_CoolTime.GetComponent<RectTransform>().SetAsFirstSibling();

    }

    void Player_Status_Add_Value()
    {
        for (int i = 0; i < 4; i++)
        {

            for (int j = 1; j < 33; j++)
            {
              if(  Player_Skill_Value[i] == j-1 && Player_Skill[i].GetComponent<Image>().color.a == 1f)
                {

                    if (j == 1 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Approach_Attack_Add_Value += Player_Status_Add_Values[j - 1];

                    }
                    else if (j == 2 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Throw_Attack_Add_Value += Player_Status_Add_Values[j - 1];

                    }
                    else if (j == 3 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Onehand_Attack_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 4 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Twohand_Attack_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 5 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Approach_Defence_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 6 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Throw_Defence_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 7 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Onehand_Defence_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 8 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Twohand_Defence_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 9 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Approach_Magic_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 10 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Throw_Magic_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 11 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Onehand_Magic_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 12 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Twohand_Magic_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 13 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Approach_Speed_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 14 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Throw_Speed_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 15 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Onehand_Speed_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 16 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Twohand_Speed_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 17 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Approach_Attack_Add_Value += Player_Status_Add_Values[j - 1];

                    }
                    else if (j == 18 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Throw_Attack_Add_Value += Player_Status_Add_Values[j - 1];

                    }
                    else if (j == 19 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Onehand_Attack_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 20 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Twohand_Attack_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 21 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Approach_Defence_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 22 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Throw_Defence_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 23 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Onehand_Defence_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 24 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Twohand_Defence_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 25 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Approach_Magic_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 26 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Throw_Magic_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 27 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Onehand_Magic_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 28 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Twohand_Magic_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 29 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Approach_Speed_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 30 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Throw_Speed_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 31 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Onehand_Speed_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                    else if (j == 32 && Player_Status_Add_Input_Values[j - 1] == false)
                    {
                        Player_Status_Add_Input_Values[j - 1] = true;
                        Battle_Player_UI_Manager.Instance.Twohand_Speed_Add_Value += Player_Status_Add_Values[j - 1];
                    }
                }
            } 
        } 
    }

    void Skill_Item_Icon_Explain_Content()
    {
        for (int j = 1; j < 33; j++)
            if (j <= 16)
            {
                Player_Status_Add_Values[j - 1] = 5;
                Skil_Item_Cost_Values[j - 1] = 300;
            }
            else if (j > 16)
            {
                Player_Status_Add_Values[j - 1] = 30;
                Skil_Item_Cost_Values[j - 1] = 3000;

            }
    }

    public void Skill_OnClick()
    {
        for (int i = 0; i < 4; i++)
        {
            if ((gameObject.name == ""+"Player_Skill("+i+")") &&
                Enemy_Player_UI_Manager.Instance.Our_Player_Coin_Value >= Player_Status_Cost_Values[i])
            {
                
                Color color = Player_Skill[i].GetComponent<Image>().color;
                color.a = 255;
            }
        }
        Player_Status_Add_Value();
    }

}
