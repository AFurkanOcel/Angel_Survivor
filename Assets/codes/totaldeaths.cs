using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class totaldeaths : MonoBehaviour
{
    public TextMeshProUGUI totaldeathtext;

    public void Start()
    {
        totaldeathtext.text = PlayerPrefs.GetInt("totaldeaths").ToString();
    }
}
