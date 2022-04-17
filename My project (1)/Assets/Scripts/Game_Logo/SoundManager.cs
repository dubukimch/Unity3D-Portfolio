using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class SoundManager : MonoBehaviour
{

    public static SoundManager Instance;

    int count = 0;

    public AudioMixer masterMixer;
    public Slider MASTERaudioSlider;
    public Slider BGMaudioSlider;
    public Slider SFXaudioSlider;

    private AudioSource bgmPlayer;
    private AudioSource sfxplayer;

    public float masterVolumeMASTER = 1f;
    public float masterVolumeSFX = 1f;
    public float masterVolumeBGM = 1f;

    [SerializeField]
    public AudioClip Game_Win_BgmAudioClip;

    [SerializeField]
    public AudioClip LogoBgmAudioClip;
    [SerializeField]
    public AudioClip Battle_Background_BgmAudioClip;
    [SerializeField]
    public AudioClip Character_Select_BgmAudioClip;
    [SerializeField]
    private AudioClip[] sfxAudioClips;

    Dictionary<string, AudioClip> audioClipsDic = new Dictionary<string, AudioClip>();


    bool sfxPlayer_Value = false;

    public float MASTERsound = 1f;
    public float BGMsound = 1f;
    public float SFXsound = 1f;
    public bool MASTER_IsOn = true;
    public bool BGM_IsOn = true;
    public bool SFX_IsOn = true;

    public bool Game_Win_BGM = false;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;

        DontDestroyOnLoad(this.gameObject);

        bgmPlayer = GameObject.FindWithTag("BGMSoundPlayer").GetComponent<AudioSource>();
        sfxplayer = GameObject.FindWithTag("SFXSoundPlayer").GetComponent<AudioSource>();

        foreach (AudioClip audioclip in sfxAudioClips)
        {
            audioClipsDic.Add(audioclip.name, audioclip);
        }
    }
    public void bgmSoundStop()
    {
        bgmPlayer.Stop();
    }
    public void PlaySFXSound(string name, float volume = 1f)
    {
        if (audioClipsDic.ContainsKey(name) == false)
        {
            return;
        }
        sfxplayer.PlayOneShot(audioClipsDic[name], volume * masterVolumeSFX);
    }

    public void PlayerBGMSound(float volume = 1f)
    {
        bgmPlayer.loop = true;
        bgmPlayer.volume = volume * masterVolumeBGM;
        if (Game_Win_BGM == false && SceneManager.GetActiveScene().name == "Battle_Background")
        {
            if (bgmPlayer.clip == Battle_Background_BgmAudioClip)
            {
                return;
            }
            else
            {
                sfxplayer.enabled = true;
                sfxplayer.clip = null;

                bgmPlayer.clip = Battle_Background_BgmAudioClip;
                bgmPlayer.Play();
            }
        }
        if (Game_Win_BGM == false && SceneManager.GetActiveScene().name == "Game_Character_Select")
        {
            if (bgmPlayer.clip == Character_Select_BgmAudioClip)
            {
                return;
            }
            else
            {
                bgmPlayer.clip = Character_Select_BgmAudioClip;
                bgmPlayer.Play();
            }
        }
        if ((SceneManager.GetActiveScene().name == "Game_Logo"))
        {
            if (bgmPlayer.clip == LogoBgmAudioClip)
            {
                return;
            }
            else
            {
                bgmPlayer.clip = LogoBgmAudioClip;
                bgmPlayer.Play();
               sfxplayer.enabled = false;

            }


        }
        if (Game_Win_BGM == true && SceneManager.GetActiveScene().name == "Battle_Background")
        {
            if (bgmPlayer.clip == Game_Win_BgmAudioClip)
            {
                return;
            }
            else
            {
                bgmPlayer.clip = Game_Win_BgmAudioClip;
                bgmPlayer.Play();


            }
        }
    }
    void Start()
    {
        PlaySFXSound("UI_Click_Sound", 1f);
        sfxplayer.loop = true;

    }
    private void Update()
    {

        try
        {
            MASTERaudioSlider = GameObject.Find("Whole_Sound_Slider").GetComponent<Slider>();
            BGMaudioSlider = GameObject.Find("BGM_Sound_Slider").GetComponent<Slider>();
            SFXaudioSlider = GameObject.Find("Effect_Sound_Slider").GetComponent<Slider>();
            MASTER_IsOn = GameObject.Find("Whole_Sound_Toggle").GetComponent<Toggle>().isOn;
            BGM_IsOn = GameObject.Find("BGM_Sound_Toggle").GetComponent<Toggle>().isOn;
            SFX_IsOn = GameObject.Find("Effect_Sound_Toggle").GetComponent<Toggle>().isOn;


        }
        catch (NullReferenceException ex)
        {

        }

        PlayerBGMSound();
    }


    public void AudioControl()
    {
        MASTERsound = MASTERaudioSlider.value;
        BGMsound = BGMaudioSlider.value;
        SFXsound = SFXaudioSlider.value;


        if (MASTERsound == -40f)
            masterMixer.SetFloat("Master", -80);
        else
            masterMixer.SetFloat("Master", MASTERsound);

        if (SFXsound == -40f)
            masterMixer.SetFloat("BGM", -80);
        else
            masterMixer.SetFloat("BGM", BGMsound);

        if (BGMsound == -40f)
            masterMixer.SetFloat("SFX", -80);
        else
            masterMixer.SetFloat("SFX", SFXsound);
    }
    public void MasteronPointerDown()
    {
        sfxplayer.clip = sfxAudioClips[0];
        sfxplayer.Play();
        sfxplayer.enabled = true;
        sfxplayer.loop = true;


    }

    public void MasteronPointerUp()
    {


        sfxplayer.enabled = false;


    }

    public void SFXonPointerDown()
    {

        sfxplayer.clip = sfxAudioClips[0];
        sfxplayer.Play();
        sfxplayer.enabled = true;


    }
    public void SFXonPointerUp()
    {
        sfxplayer.enabled = false;

    }

}
