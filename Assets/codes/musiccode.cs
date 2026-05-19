using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class musiccode : MonoBehaviour
{
    public AudioMixer audiomixer;
    public Slider sliderkayit;
    public GameObject gamemusic;

    void Start()
    {
        sliderkayit.value = PlayerPrefs.GetFloat("sesdegeri");
    }

    public void FixedUpdate()
    {
        if (sliderkayit.value <= -40)
        {
            gamemusic.SetActive(false);
        }
        else
        {
            gamemusic.SetActive(true);
        }
    }

    public void sesdegeri(float Volume)
    {
        audiomixer.SetFloat("volume", Volume);
        PlayerPrefs.SetFloat("sesdegeri", sliderkayit.value);
    }
}
