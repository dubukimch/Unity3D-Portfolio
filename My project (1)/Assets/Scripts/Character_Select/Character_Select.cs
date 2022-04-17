using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Character_Select : MonoBehaviour
{
    public static Character_Select Instance;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);

    }

    public GameObject UnityChan_Character;
    public GameObject PBRCharacter_Character;
    public GameObject GameblerCat_Character;
    public GameObject RobotKyle_Character;
    public GameObject SopphiARt_Character;
    public GameObject Arisa_Character;
    public GameObject Satomi_Character;

    public Image UnityChan_Character_Profile;
    public Image PBRCharacter_Character_Profile;
    public Image GameblerCat_Character_Profile;
    public Image RobotKyle_Character_Profile;
    public Image SopphiARt_Character_Profile;
    public Image Arisa_Character_Profile;
    public Image Satomi_Character_Profile;


    public Image Power_Star_1;
    public Image Power_Star_2;
    public Image Power_Star_3;

    public Image Speed_Star_1;
    public Image Speed_Star_2;
    public Image Speed_Star_3;

    public Image Potential_Star_1;
    public Image Potential_Star_2;
    public Image Potential_Star_3;

    bool UnityChan_Character_Value =false;
    bool PBRCharacter_Character_Value = false;
    bool GameblerCat_Character_Value = false;
    bool RobotKyle_Character_Value = false;
    bool SopphiARt_Character_Value = false;
    bool Arisa_Character_Value = false;
    bool Satomi_Character_Value = false;

    bool Character_Move_Value = false;

    public Image Job_Top;
    public Image Job_Middle;
    public Image Job_Jungle;
    public Image Job_Support;
    public Image Job_Bottom;

    public GameObject Attack_Icon;

    bool Select_Job_Top_Value = false;
    bool Select_Job_Middle_Value = false;
    bool Select_Job_Jungle_Value = false;
    bool Select_Job_Support_Value = false;
    bool Select_Job_Bottom_Value = false;



    bool Perfect_Select_Job_Top_Value = false;
    bool Perfect_Select_Job_Middle_Value = false;
    bool Perfect_Select_Job_Jungle_Value = false;
    bool Perfect_Select_Job_Support_Value = false;
    bool Perfect_Select_Job_Bottom_Value = false;

    public Button Game_Start;
    public Image Player_Select_Button;
    bool Player_Select_Character_Value = false;
    bool Perfect_Player_Select_Character_Value = false;

    public string Player_Character = null;

    public string Player_Character_Tag = null;


    public string Our_Top_Character = null;
    public string Our_Middle_Character = null;
    public string Our_Jungle_Character = null;
    public string Our_Support_Character = null;
    public string Our_Bottom_Character = null;



    public Image Character_Basic_Attack;
    public Image[] Character_Attack_Skill = new Image[3];
    public Image[] Character_Attack_Skill_Zip = new Image[21];
    public int[] Character_Attack_Skill_Value = new int[3];

    public string Video_Character_Target_Name = null;

    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Game_Character_Select")
            All_Perfect_Select_Character();
    }

    public void Select_UnityChan_Character()
    {
        All_SetAtcive_False();
        All_OutLine_False();
        UnityChan_Character_Profile.GetComponent<Outline>().enabled = true;
        Skill_Item_Manager.Instance.Skill_Item_Inventory_array = Skill_Item_Manager.Instance.UnityChan_Skill_Item_Inventory_array;

        UnityChan_Character.SetActive(true);
        Attack_Icon.SetActive(true);

        Power_Star_1.fillAmount = 1f;
        Power_Star_2.fillAmount = 1f;
        Power_Star_3.fillAmount = 0f;
        Speed_Star_1.fillAmount = 1f;
        Speed_Star_2.fillAmount = 1f;
        Speed_Star_3.fillAmount = 0f;
        Potential_Star_1.fillAmount = 1f;
        Potential_Star_2.fillAmount = 1f;
        Potential_Star_3.fillAmount = 1f;
        Character_Job_Select_Name("Our_UnityChan");
        Select_Character(UnityChan_Character_Profile);
        Skill_Item_Manager.Instance.Inventory_Window_Profile_Image = GameObject.Find("UnityChan_Profile").GetComponent<Image>().sprite;
        for (int i = 0; i < 3; i++)
        {
            Character_Attack_Skill[i].GetComponent<Image>().sprite = Character_Attack_Skill_Zip[i].GetComponent<Image>().sprite;
            Character_Attack_Skill_Value[i] = i;
        }
    }
    public void Select_PBR_Character()
    {
        All_SetAtcive_False();
        All_OutLine_False();
        PBRCharacter_Character_Profile.GetComponent<Outline>().enabled = true;
        Skill_Item_Manager.Instance.Skill_Item_Inventory_array = Skill_Item_Manager.Instance.PBRCharacter_Skill_Item_Inventory_array;
        Attack_Icon.SetActive(true);

        Video_Character_Target_Name = "PBRCharacter";

        PBRCharacter_Character.SetActive(true);
        Power_Star_1.fillAmount = 1f;
        Power_Star_2.fillAmount = 0.5f;
        Power_Star_3.fillAmount = 0f;
        Speed_Star_1.fillAmount = 1f;
        Speed_Star_2.fillAmount = 1f;
        Speed_Star_3.fillAmount = 0.5f;
        Potential_Star_1.fillAmount = 1f;
        Potential_Star_2.fillAmount = 1f;
        Potential_Star_3.fillAmount = 0f;
        Character_Job_Select_Name("Our_PBRCharacter");
        Select_Character(PBRCharacter_Character_Profile);
        Skill_Item_Manager.Instance.Inventory_Window_Profile_Image = GameObject.Find("PBRCharacter_Profile").GetComponent<Image>().sprite;
        for (int i = 0; i < 3; i++)
        {
            Character_Attack_Skill[i].GetComponent<Image>().sprite = Character_Attack_Skill_Zip[i + 3].GetComponent<Image>().sprite;
            Character_Attack_Skill_Value[i] = i+3;

        }
    }

    public void Select_RobotKyle_Character()
    {
        All_SetAtcive_False();
        All_OutLine_False();
        RobotKyle_Character_Profile.GetComponent<Outline>().enabled = true;
        Skill_Item_Manager.Instance.Skill_Item_Inventory_array = Skill_Item_Manager.Instance.RobotKyle_Skill_Item_Inventory_array;
        Attack_Icon.SetActive(true);

        RobotKyle_Character.SetActive(true);
        Power_Star_1.fillAmount = 1f;
        Power_Star_2.fillAmount = 0.5f;
        Power_Star_3.fillAmount = 0f;
        Speed_Star_1.fillAmount = 1f;
        Speed_Star_2.fillAmount = 1f;
        Speed_Star_3.fillAmount = 0f;
        Potential_Star_1.fillAmount = 1f;
        Potential_Star_2.fillAmount = 1f;
        Potential_Star_3.fillAmount = 1f;
        Character_Job_Select_Name("Our_RobotKyle");
        Select_Character(RobotKyle_Character_Profile);
        Skill_Item_Manager.Instance.Inventory_Window_Profile_Image = GameObject.Find("RobotKyle_Profile").GetComponent<Image>().sprite;
        for (int i = 0; i < 3; i++)
        {
            Character_Attack_Skill[i].GetComponent<Image>().sprite = Character_Attack_Skill_Zip[i + 6].GetComponent<Image>().sprite;
            Character_Attack_Skill_Value[i] = i+6;

        }
    }
    public void Select_GameblerCat_Character()
    {
        All_SetAtcive_False();
        All_OutLine_False();
        GameblerCat_Character_Profile.GetComponent<Outline>().enabled = true;
        Skill_Item_Manager.Instance.Skill_Item_Inventory_array = Skill_Item_Manager.Instance.Gamebler_Skill_Item_Inventory_array;
        Attack_Icon.SetActive(true);

        GameblerCat_Character.SetActive(true);
        Power_Star_1.fillAmount = 1f;
        Power_Star_2.fillAmount = 1f;
        Power_Star_3.fillAmount = 0f;
        Speed_Star_1.fillAmount = 1f;
        Speed_Star_2.fillAmount = 1f;
        Speed_Star_3.fillAmount = 0f;
        Potential_Star_1.fillAmount = 1f;
        Potential_Star_2.fillAmount = 1f;
        Potential_Star_3.fillAmount = 0f;
        Character_Job_Select_Name("Our_GamblerCat");
        Select_Character(GameblerCat_Character_Profile);
        Skill_Item_Manager.Instance.Inventory_Window_Profile_Image = GameObject.Find("Gamebler_Profile").GetComponent<Image>().sprite;
        for (int i = 0; i < 3; i++)
        {
            Character_Attack_Skill[i].GetComponent<Image>().sprite = Character_Attack_Skill_Zip[i + 9].GetComponent<Image>().sprite;
            Character_Attack_Skill_Value[i] = i+9;

        }
    }
    public void Select_Satomi_Character()
    {
        All_SetAtcive_False();
        All_OutLine_False();
        Satomi_Character_Profile.GetComponent<Outline>().enabled = true;
        Skill_Item_Manager.Instance.Skill_Item_Inventory_array = Skill_Item_Manager.Instance.Satomi_Skill_Item_Inventory_array;
        Attack_Icon.SetActive(true);

        Satomi_Character.SetActive(true);
        Power_Star_1.fillAmount = 1f;
        Power_Star_2.fillAmount = 1f;
        Power_Star_3.fillAmount = 1f;
        Speed_Star_1.fillAmount = 1f;
        Speed_Star_2.fillAmount = 1f;
        Speed_Star_3.fillAmount = 0f;
        Potential_Star_1.fillAmount = 1f;
        Potential_Star_2.fillAmount = 0f;
        Potential_Star_3.fillAmount = 0f;
        Character_Job_Select_Name("Our_Satomi");
        Select_Character(Satomi_Character_Profile);
        Skill_Item_Manager.Instance.Inventory_Window_Profile_Image = GameObject.Find("Satomi_Profile").GetComponent<Image>().sprite;
        for (int i = 0; i < 3; i++)
        {
            Character_Attack_Skill[i].GetComponent<Image>().sprite = Character_Attack_Skill_Zip[i + 12].GetComponent<Image>().sprite;
            Character_Attack_Skill_Value[i] = i+12;

        }
    }

    public void Select_SopphiARt_Character()
    {
        All_SetAtcive_False();
        All_OutLine_False();
        SopphiARt_Character_Profile.GetComponent<Outline>().enabled = true;
        Skill_Item_Manager.Instance.Skill_Item_Inventory_array = Skill_Item_Manager.Instance.SoppiARt_Skill_Item_Inventory_array;
        Attack_Icon.SetActive(true);

        SopphiARt_Character.SetActive(true);
        Power_Star_1.fillAmount = 1f;
        Power_Star_2.fillAmount = 1f;
        Power_Star_3.fillAmount = 0f;
        Speed_Star_1.fillAmount = 1f;
        Speed_Star_2.fillAmount = 1f;
        Speed_Star_3.fillAmount = 0f;
        Potential_Star_1.fillAmount = 1f;
        Potential_Star_2.fillAmount = 1f;
        Potential_Star_3.fillAmount = 0.5f;
        Character_Job_Select_Name("Our_SopphiArt");
        Select_Character(SopphiARt_Character_Profile);
        Skill_Item_Manager.Instance.Inventory_Window_Profile_Image = GameObject.Find("SoppiARt_Profile").GetComponent<Image>().sprite;
        for (int i = 0; i < 3; i++)
        {
            Character_Attack_Skill[i].GetComponent<Image>().sprite = Character_Attack_Skill_Zip[i + 15].GetComponent<Image>().sprite;
            Character_Attack_Skill_Value[i] = i+15;

        }
    }
    public void Select_Arisa_Character()
    {
        All_SetAtcive_False();
        All_OutLine_False();
        Arisa_Character_Profile.GetComponent<Outline>().enabled = true;
        Skill_Item_Manager.Instance.Skill_Item_Inventory_array = Skill_Item_Manager.Instance.Arisa_Skill_Item_Inventory_array;
        Attack_Icon.SetActive(true);

        Arisa_Character.SetActive(true);
        Power_Star_1.fillAmount = 1f;
        Power_Star_2.fillAmount = 1f;
        Power_Star_3.fillAmount = 0.5f;
        Speed_Star_1.fillAmount = 1f;
        Speed_Star_2.fillAmount = 1f;
        Speed_Star_3.fillAmount = 0.5f;
        Potential_Star_1.fillAmount = 1f;
        Potential_Star_2.fillAmount = 0f;
        Potential_Star_3.fillAmount = 0f;
        Character_Job_Select_Name("Our_Arisa");
        Select_Character(Arisa_Character_Profile);
        Skill_Item_Manager.Instance.Inventory_Window_Profile_Image = GameObject.Find("Arisa_Profile").GetComponent<Image>().sprite;
        for (int i = 0; i < 3; i++)
        {
            Character_Attack_Skill[i].GetComponent<Image>().sprite = Character_Attack_Skill_Zip[i + 18].GetComponent<Image>().sprite;
            Character_Attack_Skill_Value[i] = i+18;

        }
    }

    void Character_Job_Select_Name(string Select_Character_Name)
    {
        if (Select_Job_Top_Value == true)
        {
            Our_Top_Character = Select_Character_Name;
        }
        else if (Select_Job_Bottom_Value == true)
        {
            Our_Bottom_Character = Select_Character_Name;
        }
        else if (Select_Job_Middle_Value == true)
        {
            Our_Middle_Character = Select_Character_Name;
        }
        else if (Select_Job_Support_Value == true)
        {
            Our_Support_Character = Select_Character_Name;
        }
        else if (Select_Job_Jungle_Value == true)
        {
            Our_Jungle_Character = Select_Character_Name;
        }
    }
    void All_SetAtcive_False()
    {
        UnityChan_Character.SetActive(false);
        PBRCharacter_Character.SetActive(false);
        GameblerCat_Character.SetActive(false);
        RobotKyle_Character.SetActive(false);
        SopphiARt_Character.SetActive(false);
        Satomi_Character.SetActive(false);
        Arisa_Character.SetActive(false);
    }
    void All_Select_Job_Value_False()
    {
        Select_Job_Top_Value = false;
        Select_Job_Middle_Value = false;
        Select_Job_Jungle_Value = false;
        Select_Job_Support_Value = false;
        Select_Job_Bottom_Value = false;
    }

    void All_OutLine_False()
    {
        UnityChan_Character_Profile.GetComponent<Outline>().enabled = false;
        PBRCharacter_Character_Profile.GetComponent<Outline>().enabled = false;
        GameblerCat_Character_Profile.GetComponent<Outline>().enabled = false;
        RobotKyle_Character_Profile.GetComponent<Outline>().enabled = false;
        SopphiARt_Character_Profile.GetComponent<Outline>().enabled = false;
        Satomi_Character_Profile.GetComponent<Outline>().enabled = false;
        Arisa_Character_Profile.GetComponent<Outline>().enabled = false;
    }

    public void Select_Job_Top()
    {
        if(Select_Job_Top_Value == false)
            Select_Job_Top_Value = true;
        else if (Select_Job_Top_Value == true)
            Select_Job_Top_Value = false;
    }
    public void Select_Job_Middle()
    {
        if (Select_Job_Middle_Value == false)
            Select_Job_Middle_Value = true;
        else if (Select_Job_Middle_Value == true)
            Select_Job_Middle_Value = false;
    }
    public void Select_Job_Jungle()
    {
        if (Select_Job_Jungle_Value == false)
            Select_Job_Jungle_Value = true;
        else if (Select_Job_Jungle_Value == true)
            Select_Job_Jungle_Value = false;
    }
    public void Select_Job_Support()
    {
        if (Select_Job_Support_Value == false)
            Select_Job_Support_Value = true;
        else if (Select_Job_Support_Value == true)
            Select_Job_Support_Value = false;
    }
    public void Select_Job_Bottom()
    {
        if (Select_Job_Bottom_Value == false)
            Select_Job_Bottom_Value = true;
        else if (Select_Job_Bottom_Value == true)
            Select_Job_Bottom_Value = false;
    }

    void Select_Character(Image Select_Name)
    {
        if(Select_Job_Top_Value == true)
        {
            All_Select_Job_Value_False();
            Job_Top.rectTransform.position = Select_Name.rectTransform.position;
            Color color = Job_Top.GetComponent<Image>().color;
            color.a = (87f / 255f);
            Job_Top.GetComponent<Image>().color = color;
            Perfect_Select_Job_Top_Value = true;
            string Name = Select_Name.name;
            Player_Character = Name;


        }
        else if(Select_Job_Middle_Value == true)
        {
            All_Select_Job_Value_False();
            Job_Middle.rectTransform.position = Select_Name.rectTransform.position;
            Color color = Job_Middle.GetComponent<Image>().color;
            color.a = (87f / 255f);
            Job_Middle.GetComponent<Image>().color = color;
            Perfect_Select_Job_Middle_Value = true;
            string Name = Select_Name.name;
            Player_Character = Name;


        }
        else if (Select_Job_Jungle_Value == true)
        {
            All_Select_Job_Value_False();
            Job_Jungle.rectTransform.position = Select_Name.rectTransform.position;
            Color color = Job_Jungle.GetComponent<Image>().color;
            color.a = (87f / 255f);
            Job_Jungle.GetComponent<Image>().color = color;
            Perfect_Select_Job_Jungle_Value = true;
            string Name = Select_Name.name;
            Player_Character = Name;


        }
        else if (Select_Job_Support_Value == true)
        {
            All_Select_Job_Value_False();
            Job_Support.rectTransform.position = Select_Name.rectTransform.position;
            Color color = Job_Support.GetComponent<Image>().color;
            color.a = (87f / 255f);
            Job_Support.GetComponent<Image>().color = color;
            Perfect_Select_Job_Support_Value = true;
            string Name = Select_Name.name;
            Player_Character = Name;



        }
        else if (Select_Job_Bottom_Value == true)
        {
            All_Select_Job_Value_False();
            Job_Bottom.rectTransform.position = Select_Name.rectTransform.position;
            Color color = Job_Bottom.GetComponent<Image>().color;
            color.a = (87f/255f);
            Job_Bottom.GetComponent<Image>().color = color;
            Perfect_Select_Job_Bottom_Value = true;
            string Name = Select_Name.name;
            Player_Character = Name;

        }

        if (Player_Select_Character_Value == true)
        {
            Player_Select_Button.rectTransform.position = Select_Name.rectTransform.position;
            Color color = Player_Select_Button.GetComponent<Image>().color;
            color.a = (87f / 255f);
            Player_Select_Button.GetComponent<Image>().color = color;
            Perfect_Player_Select_Character_Value = true;
            string Name = Select_Name.name;
            Player_Character = Name;
           if(Player_Select_Button.rectTransform.position == Job_Middle.rectTransform.position)
                Player_Character_Tag = "Our_Middle";
            else if (Player_Select_Button.rectTransform.position == Job_Top.rectTransform.position)
                Player_Character_Tag = "Our_Top";
            else if (Player_Select_Button.rectTransform.position == Job_Bottom.rectTransform.position)
                Player_Character_Tag = "Our_Bottom";
            else if (Player_Select_Button.rectTransform.position == Job_Support.rectTransform.position)
                Player_Character_Tag = "Our_Support";
            else if (Player_Select_Button.rectTransform.position == Job_Jungle.rectTransform.position)
                Player_Character_Tag = "Our_Jungle";
        }

    }
    public void Select_Player_Button()
    {
        if(Player_Select_Character_Value == false)
            Player_Select_Character_Value = true;
        else if (Player_Select_Character_Value == true)
            Player_Select_Character_Value = false;
    }

    void All_Perfect_Select_Character()
    {
        if(Perfect_Select_Job_Top_Value == true &&
            Perfect_Select_Job_Middle_Value == true &&
            Perfect_Select_Job_Jungle_Value == true &&
            Perfect_Select_Job_Support_Value == true &&
            Perfect_Select_Job_Bottom_Value == true )
        {
            Player_Select_Button.gameObject.SetActive(true);

        }

        if (Perfect_Player_Select_Character_Value == true)
        {
            Game_Start.gameObject.SetActive(true);

        }


    }





}
