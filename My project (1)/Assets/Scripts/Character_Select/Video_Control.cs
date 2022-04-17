using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Control : MonoBehaviour
{
    public GameObject myVideo;
    public VideoPlayer PBRCharacter_Skill_Video;

    public VideoClip[] Skill1_Video_Data;
    public VideoClip[] Skill2_Video_Data;
    public VideoClip[] Skill3_Video_Data;
    bool Video_On = false;
    void Start()
    {
        myVideo.SetActive(false);
        PBRCharacter_Skill_Video.gameObject.SetActive(false);

    }

    public void Skill1_Video()
    {
        Debug.Log("Player_Character :" +Character_Select.Instance.Player_Character);
        if (Character_Select.Instance.Video_Character_Target_Name == "PBRCharacter")
        {
            if (Video_On == false)
            {
                myVideo.SetActive(true);
                PBRCharacter_Skill_Video.gameObject.SetActive(true);
                PBRCharacter_Skill_Video.clip = Skill1_Video_Data[0];
                PBRCharacter_Skill_Video.Play();
                Video_On = true;

            }
            else if (Video_On == true)
            {
                myVideo.SetActive(false);
                PBRCharacter_Skill_Video.gameObject.SetActive(false);
                Video_On = false;

            }
        }
    }

    public void Skill2_Video()
    {
        if (Character_Select.Instance.Video_Character_Target_Name == "PBRCharacter")
        {
            if (Video_On == false)
            {
                myVideo.SetActive(true);
                PBRCharacter_Skill_Video.gameObject.SetActive(true);

                PBRCharacter_Skill_Video.clip = Skill2_Video_Data[0];
                PBRCharacter_Skill_Video.Play();
                Video_On = true;
            }
            else if(Video_On == true)
            {
                myVideo.SetActive(false);
                PBRCharacter_Skill_Video.gameObject.SetActive(false);
                Video_On = false;

            }
        }
    }

    public void Skill3_Video()
    {

        if (Character_Select.Instance.Video_Character_Target_Name == "PBRCharacter")
        {
            if (Video_On == false)
            {
                myVideo.SetActive(true);
                PBRCharacter_Skill_Video.gameObject.SetActive(true);

                PBRCharacter_Skill_Video.clip = Skill3_Video_Data[0];
                PBRCharacter_Skill_Video.Play();
                Video_On = true;

            }
            else if (Video_On == true)
            {
                myVideo.SetActive(false);
                PBRCharacter_Skill_Video.gameObject.SetActive(false);
                Video_On = false;

            }


        }
    }
}
