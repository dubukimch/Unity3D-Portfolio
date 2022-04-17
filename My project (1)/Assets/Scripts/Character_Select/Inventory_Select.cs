using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_Select : MonoBehaviour
{

    public Text Inventory_Text;
    public GameObject Inventory_Window;

    public Image Attack_Icon;
    public Image Defence_Icon;
    public Image Masic_Icon;
    public Image Speed_Icon;

    public ScrollRect Attack_Inventory_Window;
    public ScrollRect Defence_Inventory_Window;
    public ScrollRect Masic_Inventory_Window;
    public ScrollRect Speed_Inventory_Window;

    public Image Inventory_Window_Profile = null;


    bool Inventory_Window_Value = false;

    Image Skill_Item_Change_Image;

    bool Skill_Item_Change_Value = false;

    void Update()
    {
        if(Inventory_Window.gameObject.activeSelf ==true)
            Inventory_Text.text = "<color=yellow>Inventroy</color>";

        else if (Inventory_Window.gameObject.activeSelf == false)
            Inventory_Text.text = "<color=White>Inventroy</color>";


       
        if (Attack_Icon.GetComponent<Outline>().enabled == true)
        {
            Attack_Inventory_Window.GetComponent<RectTransform>().SetAsLastSibling();
        }
        else if (Defence_Icon.GetComponent<Outline>().enabled == true)
        {
            Defence_Inventory_Window.GetComponent<RectTransform>().SetAsLastSibling();

        }
        else if (Masic_Icon.GetComponent<Outline>().enabled == true)
        {
            Masic_Inventory_Window.GetComponent<RectTransform>().SetAsLastSibling();

        }
        else if (Speed_Icon.GetComponent<Outline>().enabled == true)
        {
            Speed_Inventory_Window.GetComponent<RectTransform>().SetAsLastSibling();

        }

        Inventory_Window_Profile.sprite = Skill_Item_Manager.Instance.Inventory_Window_Profile_Image;


    }

    public void Inventory_Enter_Effect()
    {
        Inventory_Text.text = "<color=yellow>Inventroy</color>";
    }
    public void Inventory_Exit_Effect()
    {
        Inventory_Text.text = "<color=White>Inventroy</color>";
    }

    public void Inventory_Onclick()
    {
        if (Inventory_Window_Value == false)
        {
            Inventory_Window.gameObject.SetActive(true);
            Inventory_Window_Value = true;
            Skill_Item_Manager.Instance.Inventory_Character_Choose();
            Inventory_Window_Profile.sprite = Skill_Item_Manager.Instance.Inventory_Window_Profile_Image;

        }
        else if (Inventory_Window_Value == true)
        {
            Inventory_Window.gameObject.SetActive(false);
            Inventory_Window_Value = false;

        }
    }

    public void Slot1()
    {
        if (Skill_Item_Change_Value == true)
        {
            this.GetComponent<Image>().sprite = Skill_Item_Change_Image.sprite;
            Skill_Item_Change_Value = false;
        }
    }

    public void Skill_Item_Select()
    {
        Skill_Item_Change_Value = true;
        Skill_Item_Change_Image.sprite  = this.GetComponent<Image>().sprite;
    }

    

    public void All_Kind_Outline_Off()
    {
        Attack_Icon.GetComponent<Outline>().enabled = false;
        Defence_Icon.GetComponent<Outline>().enabled = false;
        Masic_Icon.GetComponent<Outline>().enabled = false;
        Speed_Icon.GetComponent<Outline>().enabled = false;
    }

    public void Inventory_Window_List()
    {
        if(Attack_Icon.GetComponent<Outline>().enabled == true)
        {
            Attack_Inventory_Window.GetComponent<RectTransform>().SetAsLastSibling();
        }
        else if(Defence_Icon.GetComponent<Outline>().enabled == true)
        {
            Defence_Inventory_Window.GetComponent<RectTransform>().SetAsLastSibling();

        }
        else if (Masic_Icon.GetComponent<Outline>().enabled == true)
        {
            Masic_Inventory_Window.GetComponent<RectTransform>().SetAsLastSibling();

        }
        else if (Speed_Icon.GetComponent<Outline>().enabled == true)
        {
            Speed_Inventory_Window.GetComponent<RectTransform>().SetAsLastSibling();

        }

    }


   


}
