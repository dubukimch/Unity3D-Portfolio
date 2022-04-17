using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager_1 : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject Game_Logo_Canvas;
    public GameObject Game_Option_Canvas;
    public GameObject Game_Ready_Canvas;
 
    public bool GameOption_Value = false;

    public void Click_Return()
    {
        Game_Option_Canvas.SetActive(false);


    }

    public void Click_Game_Option()
    {
        if(GameOption_Value == false)
            Game_Option_Canvas.SetActive(true);
        else if (GameOption_Value == true)
            Game_Option_Canvas.SetActive(false);
    }


    public void Start_Click()
    {
        Game_Logo_Canvas.SetActive(false);
        Game_Ready_Canvas.SetActive(true);

    }


    public void Game_Exit()
    {
        Application.Quit();
    }

}
