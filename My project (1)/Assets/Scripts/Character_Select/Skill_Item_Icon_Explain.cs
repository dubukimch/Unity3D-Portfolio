using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill_Item_Icon_Explain : MonoBehaviour
{
    public Image Skill_Item_Icon_Explain_Image;
    public Text Skill_Item_Icon_Explain_Text;
    public void Skill_Item_Icon_Explain_True()
    {
        Skill_Item_Icon_Explain_Image.gameObject.SetActive(true);
        Skill_Item_Icon_Explain_Image.rectTransform.position =  gameObject.transform.position - new Vector3(-50,99,0);
       this.GetComponent<Outline>().enabled = true;
        Skill_Item_Icon_Explain_Content();
    }

    public void Skill_Item_Icon_Explain_False()
    {
        Skill_Item_Icon_Explain_Image.gameObject.SetActive(false);
        this.GetComponent<Outline>().enabled = false;

    }

    void Skill_Item_Icon_Explain_Content()
    {
        if (GameObject.Find("Skill_Item(1)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "���� ���� ���� : +5";
        else if (GameObject.Find("Skill_Item(2)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�μ� ���� ���� : +5";
        else if (GameObject.Find("Skill_Item(3)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "��ô ���� ���� : +5";
        else if (GameObject.Find("Skill_Item(4)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�Ѽ� ���� ���� : +5";
        else if (GameObject.Find("Skill_Item(5)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�Ѽ� ��� ��� : +5";
        else if (GameObject.Find("Skill_Item(6)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�μ� ��� ��� : +5";
        else if (GameObject.Find("Skill_Item(7)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "��ô ��� ��� : +5";
        else if (GameObject.Find("Skill_Item(8)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "���� ��� ��� : +5";
        else if (GameObject.Find("Skill_Item(9)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�Ѽ� ���� ȿ�� : +5";
        else if (GameObject.Find("Skill_Item(10)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�μ� ���� ȿ�� : +5";
        else if (GameObject.Find("Skill_Item(11)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "��ô ���� ȿ�� : +5";
        else if (GameObject.Find("Skill_Item(12)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "���� ���� ȿ�� : +5";
        else if (GameObject.Find("Skill_Item(13)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�Ѽ� �ӵ� ȿ�� : +5";
        else if (GameObject.Find("Skill_Item(14)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�μ� �ӵ� ȿ�� : +5";
        else if (GameObject.Find("Skill_Item(15)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "��ô �ӵ� ȿ�� : +5";
        else if (GameObject.Find("Skill_Item(16)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "���� �ӵ� ȿ�� : +5";

        else if (GameObject.Find("Skill_Item(17)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "���� ���� ���� : +30";
        else if (GameObject.Find("Skill_Item(18)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�μ� ���� ���� : +30";
        else if (GameObject.Find("Skill_Item(19)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "��ô ���� ���� : +30";
        else if (GameObject.Find("Skill_Item(20)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�Ѽ� ���� ���� : +30";
        else if (GameObject.Find("Skill_Item(21)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�Ѽ� ��� ��� : +30";
        else if (GameObject.Find("Skill_Item(22)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�μ� ��� ��� : +30";
        else if (GameObject.Find("Skill_Item(23)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "��ô ��� ��� : +30";
        else if (GameObject.Find("Skill_Item(24)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "���� ��� ��� : +30";
        else if (GameObject.Find("Skill_Item(25)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�Ѽ� ���� ȿ�� : +30";
        else if (GameObject.Find("Skill_Item(26)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�μ� ���� ȿ�� : +30";
        else if (GameObject.Find("Skill_Item(27)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "��ô ���� ȿ�� : +30";
        else if (GameObject.Find("Skill_Item(28)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "���� ���� ȿ�� : +30";
        else if (GameObject.Find("Skill_Item(29)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�Ѽ� �ӵ� ȿ�� : +30";
        else if (GameObject.Find("Skill_Item(30)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "�μ� �ӵ� ȿ�� : +30";
        else if (GameObject.Find("Skill_Item(31)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "��ô �ӵ� ȿ�� : +30";
        else if (GameObject.Find("Skill_Item(32)").GetComponent<Outline>().enabled == true)
            Skill_Item_Icon_Explain_Text.text = "���� �ӵ� ȿ�� : +30";

    }
}
