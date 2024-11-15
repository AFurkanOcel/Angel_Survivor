using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class highscore : MonoBehaviour
{
    public TextMeshProUGUI hightimetext;

    public void Start()
    {
        hightimetext.text = PlayerPrefs.GetInt("hightime").ToString();

    }
}
