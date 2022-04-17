using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Master_Volume_Toggle : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Toggle>().isOn = SoundManager.Instance.MASTER_IsOn;

        Toggle toggle = gameObject.GetComponent<Toggle>();
        toggle.onValueChanged.AddListener(delegate { MAsterToggleAudioVolume(); });

    }

    public void MAsterToggleAudioVolume()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }



}
