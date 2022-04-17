using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status_Icon_Click : MonoBehaviour
{
    public void Status_Icon_Window_OnClick()
    {
        if (gameObject.activeSelf == false)
            gameObject.SetActive(true);
        else if (gameObject.activeSelf == true)
            gameObject.SetActive(false);
    }

}
