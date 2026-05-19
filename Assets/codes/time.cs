using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class time : MonoBehaviour
{
    public TextMeshProUGUI timetext;

    public void Start()
    {
        timetext.text = PlayerPrefs.GetInt("time").ToString();

    }
}
