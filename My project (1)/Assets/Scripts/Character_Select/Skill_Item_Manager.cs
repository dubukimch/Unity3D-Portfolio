using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill_Item_Manager : MonoBehaviour
{
    public static Skill_Item_Manager Instance;


    public Sprite Skill_Item_Change_Image = null;

    public Sprite Inventory_Window_Profile_Image = null;

    public int[] UnityChan_Skill_Item_Inventory_array;
    public int[] PBRCharacter_Skill_Item_Inventory_array;
    public int[] RobotKyle_Skill_Item_Inventory_array;
    public int[] Satomi_Skill_Item_Inventory_array;
    public int[] Arisa_Skill_Item_Inventory_array;
    public int[] Gamebler_Skill_Item_Inventory_array;
    public int[] SoppiARt_Skill_Item_Inventory_array;


    public int[] Skill_Item_Inventory_array = new int[4];
    public int Skill_Item_Inventory_array_Value=0;
    public int Skill_Item_Value = 0;

    public bool Skill_Item_Change_Value = false;

    public GameObject Inventory;

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

    void Start()
    {

        UnityChan_Skill_Item_Inventory_array = new int[4] { 1, 2, 3, 4 };
        PBRCharacter_Skill_Item_Inventory_array = new int[4] { 5, 6, 7, 8 };
        RobotKyle_Skill_Item_Inventory_array = new int[4] { 9, 10, 11, 12 };
        Satomi_Skill_Item_Inventory_array = new int[4] { 13, 14, 15, 16 };
        Arisa_Skill_Item_Inventory_array = new int[4] { 17, 18, 19, 20 };
        Gamebler_Skill_Item_Inventory_array = new int[4] { 21, 22, 23, 24 };
        SoppiARt_Skill_Item_Inventory_array = new int[4] { 25, 26, 27, 28 };
        Inventory_Character_Choose();
    }

    public void Inventory_Character_Choose()
    {
        if(GameObject.Find("UnityChan_Profile").GetComponent<Outline>().enabled == true)
        {

            if (Inventory.activeSelf == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    int j;
                    Skill_Item_Inventory_array[i] = UnityChan_Skill_Item_Inventory_array[i];
                    for (j = 1; j < 33; j++)
                    {
                        if (UnityChan_Skill_Item_Inventory_array[i] == j)
                        {
                            Skill_Item_Manager.Instance.Skill_Item_Value = j;
                            GameObject.Find("Slot(" + i + ")").GetComponent<Image>().sprite = GameObject.Find("Skill_Item(" + j + ")").GetComponent<Image>().sprite;
                        }
                    }
                }
            }
        }
        else if (GameObject.Find("PBRCharacter_Profile").GetComponent<Outline>().enabled == true)
        {
            if (Inventory.activeSelf == true)
            {
                for (int i = 0; i < 4; i++)
                {
                    int j;
                    Skill_Item_Inventory_array[i] = PBRCharacter_Skill_Item_Inventory_array[i];
                    for (j = 1; j < 33; j++)
                    {
                        if (PBRCharacter_Skill_Item_Inventory_array[i] == j)
                        {
                            Skill_Item_Manager.Instance.Skill_Item_Value = j;
                            GameObject.Find("Slot(" + i + ")").GetComponent<Image>().sprite = GameObject.Find("Skill_Item(" + j + ")").GetComponent<Image>().sprite;
                        }
                    }

                }
            }
        }
        else if (GameObject.Find("RobotKyle_Profile").GetComponent<Outline>().enabled == true)
        {
            for (int i = 0; i < 4; i++)
                RobotKyle_Skill_Item_Inventory_array[i] = Skill_Item_Inventory_array[i];

        }
        else if (GameObject.Find("Satomi_Profile").GetComponent<Outline>().enabled == true)
        {
            for (int i = 0; i < 4; i++)
                Satomi_Skill_Item_Inventory_array[i] = Skill_Item_Inventory_array[i];

        }
        else if (GameObject.Find("Arisa_Profile").GetComponent<Outline>().enabled == true)
        {
            for (int i = 0; i < 4; i++)
                Arisa_Skill_Item_Inventory_array[i] = Skill_Item_Inventory_array[i];

        }
        else if (GameObject.Find("Gamebler_Profile").GetComponent<Outline>().enabled == true)
        {
            for (int i = 0; i < 4; i++)
                Gamebler_Skill_Item_Inventory_array[i] = Skill_Item_Inventory_array[i];

        }
        else if (GameObject.Find("SoppiARt_Profile").GetComponent<Outline>().enabled == true)
        {
            for(int i =0; i<4;i++)
            SoppiARt_Skill_Item_Inventory_array[i] = Skill_Item_Inventory_array[i];
        }
        
    }

}
