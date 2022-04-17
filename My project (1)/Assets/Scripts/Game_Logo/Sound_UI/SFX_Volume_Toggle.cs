using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX_Volume_Toggle : MonoBehaviour
{
    void Start()
    {

        gameObject.GetComponent<Toggle>().isOn = SoundManager.Instance.SFX_IsOn;

        Toggle toggle = gameObject.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate { SFXToggleAudioVolume(); });

    }

    public void SFXToggleAudioVolume()
    {
        GameObject.FindWithTag("SFXSoundPlayer").GetComponent<AudioSource>().mute
            = GameObject.FindWithTag("SFXSoundPlayer").GetComponent<AudioSource>().mute == false ? true : false;

    }
}
