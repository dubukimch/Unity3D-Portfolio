using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BGM_Volume_Slider : MonoBehaviour
{
    AudioSource audio;

    void Start()
    {
        gameObject.GetComponent<Slider>().value = SoundManager.Instance.BGMsound;

        EventTrigger eventTrigger = gameObject.GetComponent<EventTrigger>();

        EventTrigger.Entry entry_PointerDown = new EventTrigger.Entry();

        entry_PointerDown.eventID = EventTriggerType.PointerDown;

        eventTrigger.triggers.Add(entry_PointerDown);

        EventTrigger.Entry entry_PointerUp = new EventTrigger.Entry();

        entry_PointerUp.eventID = EventTriggerType.PointerUp;

        eventTrigger.triggers.Add(entry_PointerUp);

        Slider slider = gameObject.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { OnValueChanged(); });
    }






    void OnValueChanged()
    {
        GameObject.FindWithTag("SoundManager").GetComponent<SoundManager>().AudioControl();

    }
}
