using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool Our_Game_Battle_Win = false;
    public Camera Win_Lose_Camera;
    public GameObject Win_Lose_Celebration;
    public Transform Win_Lose_Celebration_pos;
    public GameObject Win_Lose_Canvas;
    public Text Win_Text;
    public GameObject Player_Status;
    public GameObject Player_MiniMap;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
    }

    void Start()
    {
        Win_Lose_Camera.gameObject.SetActive(false);
        Win_Lose_Canvas.gameObject.SetActive(false);
        Win_Text.gameObject.SetActive(false);
    }

    void Update()
    {
        if(Our_Game_Battle_Win == true)
        {
            GameObject.FindGameObjectWithTag("MainCamera").SetActive(false);
            SoundManager.Instance.Game_Win_BGM = true;
            Win_Lose_Camera.gameObject.SetActive(true);
            Win_Lose_Canvas.gameObject.SetActive(true);
            Win_Text.gameObject.SetActive(true);
            StartCoroutine(Win_Lose_Effect());
            Player_Status.SetActive(false);
            Player_MiniMap.SetActive(false);

            Our_Game_Battle_Win = false;
        }
    }

    IEnumerator Win_Lose_Effect()
    {
        Instantiate(Win_Lose_Celebration, Win_Lose_Celebration_pos.position, Quaternion.identity);
        SoundManager.Instance.PlaySFXSound("Game_Win_FireWork", 2f);

        yield return new WaitForSeconds(2f);
        Instantiate(Win_Lose_Celebration, Win_Lose_Celebration_pos.position, Quaternion.identity);
        SoundManager.Instance.PlaySFXSound("Game_Win_FireWork", 2f);

        yield return new WaitForSeconds(2f);
        Instantiate(Win_Lose_Celebration, Win_Lose_Celebration_pos.position, Quaternion.identity);
        SoundManager.Instance.PlaySFXSound("Game_Win_FireWork", 2f);

        yield return new WaitForSeconds(2f);
        Instantiate(Win_Lose_Celebration, Win_Lose_Celebration_pos.position, Quaternion.identity);
        SoundManager.Instance.PlaySFXSound("Game_Win_FireWork", 2f);
        yield return new WaitForSeconds(5f);

        LoadingSceneManager.LoadScene("Game_Logo");

    }

}
