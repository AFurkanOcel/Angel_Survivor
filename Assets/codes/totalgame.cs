using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class totalgame : MonoBehaviour
{
    public TextMeshProUGUI totalgametext;

    public void Start()
    {
        totalgametext.text = PlayerPrefs.GetInt("totalgame").ToString();
    }
}
