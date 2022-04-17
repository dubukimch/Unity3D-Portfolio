using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadingTest : MonoBehaviour
{
    public void Battle_Load()
    {
        LoadingSceneManager.LoadScene("Battle_Background");        
    }
    public void Game_Select_Character_Load()
    {
        LoadingSceneManager.LoadScene("Game_Character_Select");
    }

    public void Game_Win_Return_Home_Load()
    {
        LoadingSceneManager.LoadScene("Game_Logo");
    }

}
