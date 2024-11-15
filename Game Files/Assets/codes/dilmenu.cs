using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dilmenu : MonoBehaviour
{
    int hangidilaktif = 0;

    public GameObject turplay;
    public GameObject turstatistics;
    public GameObject tursettings;
    public GameObject turexit;
    public GameObject turplayer;

    public GameObject engplay;
    public GameObject engstatistics;
    public GameObject engsettings;
    public GameObject engexit;
    public GameObject engplayer;

    public GameObject fraplay;
    public GameObject frastatistics;
    public GameObject frasettings;
    public GameObject fraexit;
    public GameObject fraplayer;

    public GameObject gerplay;
    public GameObject gerstatistics;
    public GameObject gersettings;
    public GameObject gerexit;
    public GameObject gerplayer;

    public GameObject rusplay;
    public GameObject russtatistics;
    public GameObject russettings;
    public GameObject rusexit;
    public GameObject rusplayer;

    public GameObject itaplay;
    public GameObject itastatistics;
    public GameObject itasettings;
    public GameObject itaexit;
    public GameObject itaplayer;

    public GameObject spaplay;
    public GameObject spastatistics;
    public GameObject spasettings;
    public GameObject spaexit;
    public GameObject spaplayer;

    public GameObject porplay;
    public GameObject porstatistics;
    public GameObject porsettings;
    public GameObject porexit;
    public GameObject porplayer;


    void Start()
    {
        Time.timeScale = 1f;

        hangidilaktif = PlayerPrefs.GetInt(nameof(hangidilaktif));

        if (hangidilaktif == 0)
        {
            engbayrak();
        }
        else if (hangidilaktif == 1)
        {
            turbayrak();
        }
        else if (hangidilaktif == 2)
        {
            frabayrak();

        }
        else if (hangidilaktif == 3)
        {
            gerbayrak();
        }
        else if (hangidilaktif == 4)
        {
            rusbayrak();
        }
        else if (hangidilaktif == 5)
        {
            itabayrak();
        }
        else if (hangidilaktif == 6)
        {
            spabayrak();
        }
        else
        {
            porbayrak();
        }
    }

    public void turbayrak()
    {
        turplay.SetActive(true);
        turstatistics.SetActive(true);
        tursettings.SetActive(true);
        turexit.SetActive(true);
        turplayer.SetActive(true);

        engplay.SetActive(false);
        engstatistics.SetActive(false);
        engsettings.SetActive(false);
        engexit.SetActive(false);
        engplayer.SetActive(false);

        fraplay.SetActive(false);
        frastatistics.SetActive(false);
        frasettings.SetActive(false);
        fraexit.SetActive(false);
        fraplayer.SetActive(false);

        gerplay.SetActive(false);
        gerstatistics.SetActive(false);
        gersettings.SetActive(false);
        gerexit.SetActive(false);
        gerplayer.SetActive(false);

        rusplay.SetActive(false);
        russtatistics.SetActive(false);
        russettings.SetActive(false);
        rusexit.SetActive(false);
        rusplayer.SetActive(false);

        itaplay.SetActive(false);
        itastatistics.SetActive(false);
        itasettings.SetActive(false);
        itaexit.SetActive(false);
        itaplayer.SetActive(false);

        spaplay.SetActive(false);
        spastatistics.SetActive(false);
        spasettings.SetActive(false);
        spaexit.SetActive(false);
        spaplayer.SetActive(false);

        porplay.SetActive(false);
        porstatistics.SetActive(false);
        porsettings.SetActive(false);
        porexit.SetActive(false);
        porplayer.SetActive(false);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void engbayrak()
    {
        turplay.SetActive(false);
        turstatistics.SetActive(false);
        tursettings.SetActive(false);
        turexit.SetActive(false);
        turplayer.SetActive(false);

        engplay.SetActive(true);
        engstatistics.SetActive(true);
        engsettings.SetActive(true);
        engexit.SetActive(true);
        engplayer.SetActive(true);

        fraplay.SetActive(false);
        frastatistics.SetActive(false);
        frasettings.SetActive(false);
        fraexit.SetActive(false);
        fraplayer.SetActive(false);

        gerplay.SetActive(false);
        gerstatistics.SetActive(false);
        gersettings.SetActive(false);
        gerexit.SetActive(false);
        gerplayer.SetActive(false);

        rusplay.SetActive(false);
        russtatistics.SetActive(false);
        russettings.SetActive(false);
        rusexit.SetActive(false);
        rusplayer.SetActive(false);

        itaplay.SetActive(false);
        itastatistics.SetActive(false);
        itasettings.SetActive(false);
        itaexit.SetActive(false);
        itaplayer.SetActive(false);

        spaplay.SetActive(false);
        spastatistics.SetActive(false);
        spasettings.SetActive(false);
        spaexit.SetActive(false);
        spaplayer.SetActive(false);

        porplay.SetActive(false);
        porstatistics.SetActive(false);
        porsettings.SetActive(false);
        porexit.SetActive(false);
        porplayer.SetActive(false);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void frabayrak()
    {
        turplay.SetActive(false);
        turstatistics.SetActive(false);
        tursettings.SetActive(false);
        turexit.SetActive(false);
        turplayer.SetActive(false);

        engplay.SetActive(false);
        engstatistics.SetActive(false);
        engsettings.SetActive(false);
        engexit.SetActive(false);
        engplayer.SetActive(false);

        fraplay.SetActive(true);
        frastatistics.SetActive(true);
        frasettings.SetActive(true);
        fraexit.SetActive(true);
        fraplayer.SetActive(true);

        gerplay.SetActive(false);
        gerstatistics.SetActive(false);
        gersettings.SetActive(false);
        gerexit.SetActive(false);
        gerplayer.SetActive(false);

        rusplay.SetActive(false);
        russtatistics.SetActive(false);
        russettings.SetActive(false);
        rusexit.SetActive(false);
        rusplayer.SetActive(false);

        itaplay.SetActive(false);
        itastatistics.SetActive(false);
        itasettings.SetActive(false);
        itaexit.SetActive(false);
        itaplayer.SetActive(false);

        spaplay.SetActive(false);
        spastatistics.SetActive(false);
        spasettings.SetActive(false);
        spaexit.SetActive(false);
        spaplayer.SetActive(false);

        porplay.SetActive(false);
        porstatistics.SetActive(false);
        porsettings.SetActive(false);
        porexit.SetActive(false);
        porplayer.SetActive(false);

        hangidilaktif = 2;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void gerbayrak()
    {
        turplay.SetActive(false);
        turstatistics.SetActive(false);
        tursettings.SetActive(false);
        turexit.SetActive(false);
        turplayer.SetActive(false);

        engplay.SetActive(false);
        engstatistics.SetActive(false);
        engsettings.SetActive(false);
        engexit.SetActive(false);
        engplayer.SetActive(false);

        fraplay.SetActive(false);
        frastatistics.SetActive(false);
        frasettings.SetActive(false);
        fraexit.SetActive(false);
        fraplayer.SetActive(false);

        gerplay.SetActive(true);
        gerstatistics.SetActive(true);
        gersettings.SetActive(true);
        gerexit.SetActive(true);
        gerplayer.SetActive(true);

        rusplay.SetActive(false);
        russtatistics.SetActive(false);
        russettings.SetActive(false);
        rusexit.SetActive(false);
        rusplayer.SetActive(false);

        itaplay.SetActive(false);
        itastatistics.SetActive(false);
        itasettings.SetActive(false);
        itaexit.SetActive(false);
        itaplayer.SetActive(false);

        spaplay.SetActive(false);
        spastatistics.SetActive(false);
        spasettings.SetActive(false);
        spaexit.SetActive(false);
        spaplayer.SetActive(false);

        porplay.SetActive(false);
        porstatistics.SetActive(false);
        porsettings.SetActive(false);
        porexit.SetActive(false);
        porplayer.SetActive(false);

        hangidilaktif = 3;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void rusbayrak()
    {
        turplay.SetActive(false);
        turstatistics.SetActive(false);
        tursettings.SetActive(false);
        turexit.SetActive(false);
        turplayer.SetActive(false);

        engplay.SetActive(false);
        engstatistics.SetActive(false);
        engsettings.SetActive(false);
        engexit.SetActive(false);
        engplayer.SetActive(false);

        fraplay.SetActive(false);
        frastatistics.SetActive(false);
        frasettings.SetActive(false);
        fraexit.SetActive(false);
        fraplayer.SetActive(false);

        gerplay.SetActive(false);
        gerstatistics.SetActive(false);
        gersettings.SetActive(false);
        gerexit.SetActive(false);
        gerplayer.SetActive(false);

        rusplay.SetActive(true);
        russtatistics.SetActive(true);
        russettings.SetActive(true);
        rusexit.SetActive(true);
        rusplayer.SetActive(true);

        itaplay.SetActive(false);
        itastatistics.SetActive(false);
        itasettings.SetActive(false);
        itaexit.SetActive(false);
        itaplayer.SetActive(false);

        spaplay.SetActive(false);
        spastatistics.SetActive(false);
        spasettings.SetActive(false);
        spaexit.SetActive(false);
        spaplayer.SetActive(false);

        porplay.SetActive(false);
        porstatistics.SetActive(false);
        porsettings.SetActive(false);
        porexit.SetActive(false);
        porplayer.SetActive(false);

        hangidilaktif = 4;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void itabayrak()
    {
        turplay.SetActive(false);
        turstatistics.SetActive(false);
        tursettings.SetActive(false);
        turexit.SetActive(false);
        turplayer.SetActive(false);

        engplay.SetActive(false);
        engstatistics.SetActive(false);
        engsettings.SetActive(false);
        engexit.SetActive(false);
        engplayer.SetActive(false);

        fraplay.SetActive(false);
        frastatistics.SetActive(false);
        frasettings.SetActive(false);
        fraexit.SetActive(false);
        fraplayer.SetActive(false);

        gerplay.SetActive(false);
        gerstatistics.SetActive(false);
        gersettings.SetActive(false);
        gerexit.SetActive(false);
        gerplayer.SetActive(false);

        rusplay.SetActive(false);
        russtatistics.SetActive(false);
        russettings.SetActive(false);
        rusexit.SetActive(false);
        rusplayer.SetActive(false);

        itaplay.SetActive(true);
        itastatistics.SetActive(true);
        itasettings.SetActive(true);
        itaexit.SetActive(true);
        itaplayer.SetActive(true);

        spaplay.SetActive(false);
        spastatistics.SetActive(false);
        spasettings.SetActive(false);
        spaexit.SetActive(false);
        spaplayer.SetActive(false);

        porplay.SetActive(false);
        porstatistics.SetActive(false);
        porsettings.SetActive(false);
        porexit.SetActive(false);
        porplayer.SetActive(false);

        hangidilaktif = 5;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void spabayrak()
    {
        turplay.SetActive(false);
        turstatistics.SetActive(false);
        tursettings.SetActive(false);
        turexit.SetActive(false);
        turplayer.SetActive(false);

        engplay.SetActive(false);
        engstatistics.SetActive(false);
        engsettings.SetActive(false);
        engexit.SetActive(false);
        engplayer.SetActive(false);

        fraplay.SetActive(false);
        frastatistics.SetActive(false);
        frasettings.SetActive(false);
        fraexit.SetActive(false);
        fraplayer.SetActive(false);

        gerplay.SetActive(false);
        gerstatistics.SetActive(false);
        gersettings.SetActive(false);
        gerexit.SetActive(false);
        gerplayer.SetActive(false);

        rusplay.SetActive(false);
        russtatistics.SetActive(false);
        russettings.SetActive(false);
        rusexit.SetActive(false);
        rusplayer.SetActive(false);

        itaplay.SetActive(false);
        itastatistics.SetActive(false);
        itasettings.SetActive(false);
        itaexit.SetActive(false);
        itaplayer.SetActive(false);

        spaplay.SetActive(true);
        spastatistics.SetActive(true);
        spasettings.SetActive(true);
        spaexit.SetActive(true);
        spaplayer.SetActive(true);

        porplay.SetActive(false);
        porstatistics.SetActive(false);
        porsettings.SetActive(false);
        porexit.SetActive(false);
        porplayer.SetActive(false);

        hangidilaktif = 6;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void porbayrak()
    {
        turplay.SetActive(false);
        turstatistics.SetActive(false);
        tursettings.SetActive(false);
        turexit.SetActive(false);
        turplayer.SetActive(false);

        engplay.SetActive(false);
        engstatistics.SetActive(false);
        engsettings.SetActive(false);
        engexit.SetActive(false);
        engplayer.SetActive(false);

        fraplay.SetActive(false);
        frastatistics.SetActive(false);
        frasettings.SetActive(false);
        fraexit.SetActive(false);
        fraplayer.SetActive(false);

        gerplay.SetActive(false);
        gerstatistics.SetActive(false);
        gersettings.SetActive(false);
        gerexit.SetActive(false);
        gerplayer.SetActive(false);

        rusplay.SetActive(false);
        russtatistics.SetActive(false);
        russettings.SetActive(false);
        rusexit.SetActive(false);
        rusplayer.SetActive(false);

        itaplay.SetActive(false);
        itastatistics.SetActive(false);
        itasettings.SetActive(false);
        itaexit.SetActive(false);
        itaplayer.SetActive(false);

        spaplay.SetActive(false);
        spastatistics.SetActive(false);
        spasettings.SetActive(false);
        spaexit.SetActive(false);
        spaplayer.SetActive(false);

        porplay.SetActive(true);
        porstatistics.SetActive(true);
        porsettings.SetActive(true);
        porexit.SetActive(true);
        porplayer.SetActive(true);

        hangidilaktif = 7;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}
