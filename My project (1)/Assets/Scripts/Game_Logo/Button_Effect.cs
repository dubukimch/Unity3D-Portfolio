using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Effect : MonoBehaviour
{


    public Sprite Before_Image;
    public Sprite After_Image;


    public void Click_Before()
    {

        gameObject.GetComponent<Image>().sprite = Before_Image;

    }
    public void Click_After()
    {
        gameObject.GetComponent<Image>().sprite = After_Image;



    }


}
