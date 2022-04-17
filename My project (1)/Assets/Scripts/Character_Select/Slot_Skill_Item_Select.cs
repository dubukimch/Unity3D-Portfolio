using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_Skill_Item_Select : MonoBehaviour
{
    public void Slot()
    {
            
            this.GetComponent<Image>().sprite = Skill_Item_Manager.Instance.Skill_Item_Change_Image;
        if (gameObject.name == "Slot(0)")
        {
            Skill_Item_Manager.Instance.Skill_Item_Inventory_array[0] = Skill_Item_Manager.Instance.Skill_Item_Value;
            Skill_Item_Manager.Instance.Skill_Item_Change_Image = GameObject.Find("Skill_Item("+Skill_Item_Manager.Instance.Skill_Item_Value+")").GetComponent<Image>().sprite;
            Change_Skill_Value();
        }
        else if(gameObject.name == "Slot(1)")
        {
            Skill_Item_Manager.Instance.Skill_Item_Inventory_array[1] = Skill_Item_Manager.Instance.Skill_Item_Value;
            Skill_Item_Manager.Instance.Skill_Item_Change_Image = GameObject.Find("Skill_Item("+Skill_Item_Manager.Instance.Skill_Item_Value+")").GetComponent<Image>().sprite;
            Change_Skill_Value();
        }
        else if (gameObject.name == "Slot(2)")
        {
            Skill_Item_Manager.Instance.Skill_Item_Inventory_array[2] = Skill_Item_Manager.Instance.Skill_Item_Value;
            Skill_Item_Manager.Instance.Skill_Item_Change_Image = GameObject.Find("Skill_Item("+Skill_Item_Manager.Instance.Skill_Item_Value+")").GetComponent<Image>().sprite;
            Change_Skill_Value();
        }
        else if (gameObject.name == "Slot(3)")
        {
            Skill_Item_Manager.Instance.Skill_Item_Inventory_array[3] = Skill_Item_Manager.Instance.Skill_Item_Value;
            Skill_Item_Manager.Instance.Skill_Item_Change_Image = GameObject.Find("Skill_Item("+Skill_Item_Manager.Instance.Skill_Item_Value+")").GetComponent<Image>().sprite;
            Change_Skill_Value();
        }

    }
   void Change_Skill_Value()
    {
        if (GameObject.Find("UnityChan_Profile").GetComponent<Outline>().enabled == true)
        {
            for (int i = 0; i < 4; i++)
            {
                int j;
                Skill_Item_Manager.Instance.UnityChan_Skill_Item_Inventory_array[i] = Skill_Item_Manager.Instance.Skill_Item_Inventory_array[i];
                for (j = 1; j < 33; j++)
                {
                    if (Skill_Item_Manager.Instance.UnityChan_Skill_Item_Inventory_array[i] == j)
                    {
                        Skill_Item_Manager.Instance.Skill_Item_Value = j;
                        GameObject.Find("Slot(" + i + ")").GetComponent<Image>().sprite = GameObject.Find("Skill_Item(" + j + ")").GetComponent<Image>().sprite;
                    }
                }

            }
        }
        else if (GameObject.Find("PBRCharacter_Profile").GetComponent<Outline>().enabled == true)
        {
            for (int i = 0; i < 4; i++)
            {
                int j;
                Skill_Item_Manager.Instance.PBRCharacter_Skill_Item_Inventory_array[i] = Skill_Item_Manager.Instance.Skill_Item_Inventory_array[i];
                for (j = 1; j < 33; j++)
                {
                    if (Skill_Item_Manager.Instance.PBRCharacter_Skill_Item_Inventory_array[i] == j)
                    {
                        Skill_Item_Manager.Instance.Skill_Item_Value = j;
                        GameObject.Find("Slot(" + i + ")").GetComponent<Image>().sprite = GameObject.Find("Skill_Item(" + j + ")").GetComponent<Image>().sprite;
                    }
                }

            }
        }
    }
    public void Skill_Item_Select()
    {
        Skill_Item_Manager.Instance.Skill_Item_Change_Value = true;

        for (int k = 1; k < 33; k++)
        {
            if (gameObject.name == "Skill_Item("+k+")")
                Skill_Item_Manager.Instance.Skill_Item_Value = k;
        }
    }

    public void Item_Kind_Select()
    {
        this.GetComponent<Outline>().enabled = true;
    }


}
