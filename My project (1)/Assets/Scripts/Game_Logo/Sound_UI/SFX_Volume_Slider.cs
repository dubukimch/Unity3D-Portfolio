using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SFX_Volume_Slider : MonoBehaviour
{
    AudioSource audio;



    void Start()
    {
        gameObject.GetComponent<Slider>().value = SoundManager.Instance.SFXsound;

        EventTrigger eventTrigger = gameObject.GetComponent<EventTrigger>();

        EventTrigger.Entry entry_PointerDown = new EventTrigger.Entry();

        entry_PointerDown.eventID = EventTriggerType.PointerDown;

        entry_PointerDown.callback.AddListener((data) => { OnPointerDown((PointerEventData)data); });
        eventTrigger.triggers.Add(entry_PointerDown);

        EventTrigger.Entry entry_PointerUp = new EventTrigger.Entry();

        entry_PointerUp.eventID = EventTriggerType.PointerUp;

        entry_PointerUp.callback.AddListener((data) => { OnPointerUp((PointerEventData)data); });
        eventTrigger.triggers.Add(entry_PointerUp);



        Slider slider = gameObject.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { OnValueChanged(); });


    }


    void OnPointerDown(PointerEventData data)
    {
        GameObject.FindWithTag("SoundManager").GetComponent<SoundManager>().SFXonPointerDown();
    }
    void OnPointerUp(PointerEventData data)
    {
        GameObject.FindWithTag("SoundManager").GetComponent<SoundManager>().SFXonPointerUp();
    }

    void OnValueChanged()
    {
        GameObject.FindWithTag("SoundManager").GetComponent<SoundManager>().AudioControl();

    }
}
