using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM_Volume_Toggle : MonoBehaviour
{


    void Start()
    {

        gameObject.GetComponent<Toggle>().isOn = SoundManager.Instance.BGM_IsOn;

        Toggle toggle = gameObject.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate { BGMToggleAudioVolume(); });

    }

    public void BGMToggleAudioVolume()
    {
        GameObject.FindWithTag("BGMSoundPlayer").GetComponent<AudioSource>().mute
            = GameObject.FindWithTag("BGMSoundPlayer").GetComponent<AudioSource>().mute == false ? true : false;

    }
}
