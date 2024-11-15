using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class soundcode : MonoBehaviour
{
    public AudioMixer audiomixersound;
    public Slider sliderkayitsound;
    public GameObject meteorsound;

    void Start()
    {
        sliderkayitsound.value = PlayerPrefs.GetFloat("sesdegeri2");
    }

    public void FixedUpdate()
    {
        if (sliderkayitsound.value <= -40)
        {
            meteorsound.SetActive(false);
        }
        else
        {
            meteorsound.SetActive(true);
        }
    }

    public void sesdegeri2(float Volume)
    {
        audiomixersound.SetFloat("soundvolume", Volume);
        PlayerPrefs.SetFloat("sesdegeri2", sliderkayitsound.value);
    }
}
