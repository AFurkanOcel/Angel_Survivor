using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dilstatistics : MonoBehaviour
{
    int hangidilaktif = 0;

    public GameObject turstatistics;
    public GameObject turrecordtime;
    public GameObject turtotalgames;
    public GameObject turtotaldeaths;
    public GameObject turback;

    public GameObject engstatistics;
    public GameObject engrecordtime;
    public GameObject engtotalgames;
    public GameObject engtotaldeaths;
    public GameObject engback;

    public GameObject frastatistics;
    public GameObject frarecordtime;
    public GameObject fratotalgames;
    public GameObject fratotaldeaths;
    public GameObject fraback;

    public GameObject gerstatistics;
    public GameObject gerrecordtime;
    public GameObject gertotalgames;
    public GameObject gertotaldeaths;
    public GameObject gerback;

    public GameObject russtatistics;
    public GameObject rusrecordtime;
    public GameObject rustotalgames;
    public GameObject rustotaldeaths;
    public GameObject rusback;

    public GameObject itastatistics;
    public GameObject itarecordtime;
    public GameObject itatotalgames;
    public GameObject itatotaldeaths;
    public GameObject itaback;

    public GameObject spastatistics;
    public GameObject sparecordtime;
    public GameObject spatotalgames;
    public GameObject spatotaldeaths;
    public GameObject spaback;

    public GameObject porstatistics;
    public GameObject porrecordtime;
    public GameObject portotalgames;
    public GameObject portotaldeaths;
    public GameObject porback;

    void Start()
    {
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
        turstatistics.SetActive(true);
        turrecordtime.SetActive(true);
        turtotalgames.SetActive(true);
        turtotaldeaths.SetActive(true);
        turback.SetActive(true);

        engstatistics.SetActive(false);
        engrecordtime.SetActive(false);
        engtotalgames.SetActive(false);
        engtotaldeaths.SetActive(false);
        engback.SetActive(false);

        frastatistics.SetActive(false);
        frarecordtime.SetActive(false);
        fratotalgames.SetActive(false);
        fratotaldeaths.SetActive(false);
        fraback.SetActive(false);

        gerstatistics.SetActive(false);
        gerrecordtime.SetActive(false);
        gertotalgames.SetActive(false);
        gertotaldeaths.SetActive(false);
        gerback.SetActive(false);

        russtatistics.SetActive(false);
        rusrecordtime.SetActive(false);
        rustotalgames.SetActive(false);
        rustotaldeaths.SetActive(false);
        rusback.SetActive(false);

        itastatistics.SetActive(false);
        itarecordtime.SetActive(false);
        itatotalgames.SetActive(false);
        itatotaldeaths.SetActive(false);
        itaback.SetActive(false);

        spastatistics.SetActive(false);
        sparecordtime.SetActive(false);
        spatotalgames.SetActive(false);
        spatotaldeaths.SetActive(false);
        spaback.SetActive(false);

        porstatistics.SetActive(false);
        porrecordtime.SetActive(false);
        portotalgames.SetActive(false);
        portotaldeaths.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void engbayrak()
    {
        turstatistics.SetActive(false);
        turrecordtime.SetActive(false);
        turtotalgames.SetActive(false);
        turtotaldeaths.SetActive(false);
        turback.SetActive(false);

        engstatistics.SetActive(true);
        engrecordtime.SetActive(true);
        engtotalgames.SetActive(true);
        engtotaldeaths.SetActive(true);
        engback.SetActive(true);

        frastatistics.SetActive(false);
        frarecordtime.SetActive(false);
        fratotalgames.SetActive(false);
        fratotaldeaths.SetActive(false);
        fraback.SetActive(false);

        gerstatistics.SetActive(false);
        gerrecordtime.SetActive(false);
        gertotalgames.SetActive(false);
        gertotaldeaths.SetActive(false);
        gerback.SetActive(false);

        russtatistics.SetActive(false);
        rusrecordtime.SetActive(false);
        rustotalgames.SetActive(false);
        rustotaldeaths.SetActive(false);
        rusback.SetActive(false);

        itastatistics.SetActive(false);
        itarecordtime.SetActive(false);
        itatotalgames.SetActive(false);
        itatotaldeaths.SetActive(false);
        itaback.SetActive(false);

        spastatistics.SetActive(false);
        sparecordtime.SetActive(false);
        spatotalgames.SetActive(false);
        spatotaldeaths.SetActive(false);
        spaback.SetActive(false);

        porstatistics.SetActive(false);
        porrecordtime.SetActive(false);
        portotalgames.SetActive(false);
        portotaldeaths.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void frabayrak()
    {
        turstatistics.SetActive(false);
        turrecordtime.SetActive(false);
        turtotalgames.SetActive(false);
        turtotaldeaths.SetActive(false);
        turback.SetActive(false);

        engstatistics.SetActive(false);
        engrecordtime.SetActive(false);
        engtotalgames.SetActive(false);
        engtotaldeaths.SetActive(false);
        engback.SetActive(false);

        frastatistics.SetActive(true);
        frarecordtime.SetActive(true);
        fratotalgames.SetActive(true);
        fratotaldeaths.SetActive(true);
        fraback.SetActive(true);

        gerstatistics.SetActive(false);
        gerrecordtime.SetActive(false);
        gertotalgames.SetActive(false);
        gertotaldeaths.SetActive(false);
        gerback.SetActive(false);

        russtatistics.SetActive(false);
        rusrecordtime.SetActive(false);
        rustotalgames.SetActive(false);
        rustotaldeaths.SetActive(false);
        rusback.SetActive(false);

        itastatistics.SetActive(false);
        itarecordtime.SetActive(false);
        itatotalgames.SetActive(false);
        itatotaldeaths.SetActive(false);
        itaback.SetActive(false);

        spastatistics.SetActive(false);
        sparecordtime.SetActive(false);
        spatotalgames.SetActive(false);
        spatotaldeaths.SetActive(false);
        spaback.SetActive(false);

        porstatistics.SetActive(false);
        porrecordtime.SetActive(false);
        portotalgames.SetActive(false);
        portotaldeaths.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 2;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void gerbayrak()
    {
        turstatistics.SetActive(false);
        turrecordtime.SetActive(false);
        turtotalgames.SetActive(false);
        turtotaldeaths.SetActive(false);
        turback.SetActive(false);

        engstatistics.SetActive(false);
        engrecordtime.SetActive(false);
        engtotalgames.SetActive(false);
        engtotaldeaths.SetActive(false);
        engback.SetActive(false);

        frastatistics.SetActive(false);
        frarecordtime.SetActive(false);
        fratotalgames.SetActive(false);
        fratotaldeaths.SetActive(false);
        fraback.SetActive(false);

        gerstatistics.SetActive(true);
        gerrecordtime.SetActive(true);
        gertotalgames.SetActive(true);
        gertotaldeaths.SetActive(true);
        gerback.SetActive(true);

        russtatistics.SetActive(false);
        rusrecordtime.SetActive(false);
        rustotalgames.SetActive(false);
        rustotaldeaths.SetActive(false);
        rusback.SetActive(false);

        itastatistics.SetActive(false);
        itarecordtime.SetActive(false);
        itatotalgames.SetActive(false);
        itatotaldeaths.SetActive(false);
        itaback.SetActive(false);

        spastatistics.SetActive(false);
        sparecordtime.SetActive(false);
        spatotalgames.SetActive(false);
        spatotaldeaths.SetActive(false);
        spaback.SetActive(false);

        porstatistics.SetActive(false);
        porrecordtime.SetActive(false);
        portotalgames.SetActive(false);
        portotaldeaths.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 3;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void rusbayrak()
    {
        turstatistics.SetActive(false);
        turrecordtime.SetActive(false);
        turtotalgames.SetActive(false);
        turtotaldeaths.SetActive(false);
        turback.SetActive(false);

        engstatistics.SetActive(false);
        engrecordtime.SetActive(false);
        engtotalgames.SetActive(false);
        engtotaldeaths.SetActive(false);
        engback.SetActive(false);

        frastatistics.SetActive(false);
        frarecordtime.SetActive(false);
        fratotalgames.SetActive(false);
        fratotaldeaths.SetActive(false);
        fraback.SetActive(false);

        gerstatistics.SetActive(false);
        gerrecordtime.SetActive(false);
        gertotalgames.SetActive(false);
        gertotaldeaths.SetActive(false);
        gerback.SetActive(false);

        russtatistics.SetActive(true);
        rusrecordtime.SetActive(true);
        rustotalgames.SetActive(true);
        rustotaldeaths.SetActive(true);
        rusback.SetActive(true);

        itastatistics.SetActive(false);
        itarecordtime.SetActive(false);
        itatotalgames.SetActive(false);
        itatotaldeaths.SetActive(false);
        itaback.SetActive(false);

        spastatistics.SetActive(false);
        sparecordtime.SetActive(false);
        spatotalgames.SetActive(false);
        spatotaldeaths.SetActive(false);
        spaback.SetActive(false);

        porstatistics.SetActive(false);
        porrecordtime.SetActive(false);
        portotalgames.SetActive(false);
        portotaldeaths.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 4;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void itabayrak()
    {
        turstatistics.SetActive(false);
        turrecordtime.SetActive(false);
        turtotalgames.SetActive(false);
        turtotaldeaths.SetActive(false);
        turback.SetActive(false);

        engstatistics.SetActive(false);
        engrecordtime.SetActive(false);
        engtotalgames.SetActive(false);
        engtotaldeaths.SetActive(false);
        engback.SetActive(false);

        frastatistics.SetActive(false);
        frarecordtime.SetActive(false);
        fratotalgames.SetActive(false);
        fratotaldeaths.SetActive(false);
        fraback.SetActive(false);

        gerstatistics.SetActive(false);
        gerrecordtime.SetActive(false);
        gertotalgames.SetActive(false);
        gertotaldeaths.SetActive(false);
        gerback.SetActive(false);

        russtatistics.SetActive(false);
        rusrecordtime.SetActive(false);
        rustotalgames.SetActive(false);
        rustotaldeaths.SetActive(false);
        rusback.SetActive(false);

        itastatistics.SetActive(true);
        itarecordtime.SetActive(true);
        itatotalgames.SetActive(true);
        itatotaldeaths.SetActive(true);
        itaback.SetActive(true);

        spastatistics.SetActive(false);
        sparecordtime.SetActive(false);
        spatotalgames.SetActive(false);
        spatotaldeaths.SetActive(false);
        spaback.SetActive(false);

        porstatistics.SetActive(false);
        porrecordtime.SetActive(false);
        portotalgames.SetActive(false);
        portotaldeaths.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 5;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void spabayrak()
    {
        turstatistics.SetActive(false);
        turrecordtime.SetActive(false);
        turtotalgames.SetActive(false);
        turtotaldeaths.SetActive(false);
        turback.SetActive(false);

        engstatistics.SetActive(false);
        engrecordtime.SetActive(false);
        engtotalgames.SetActive(false);
        engtotaldeaths.SetActive(false);
        engback.SetActive(false);

        frastatistics.SetActive(false);
        frarecordtime.SetActive(false);
        fratotalgames.SetActive(false);
        fratotaldeaths.SetActive(false);
        fraback.SetActive(false);

        gerstatistics.SetActive(false);
        gerrecordtime.SetActive(false);
        gertotalgames.SetActive(false);
        gertotaldeaths.SetActive(false);
        gerback.SetActive(false);

        russtatistics.SetActive(false);
        rusrecordtime.SetActive(false);
        rustotalgames.SetActive(false);
        rustotaldeaths.SetActive(false);
        rusback.SetActive(false);

        itastatistics.SetActive(false);
        itarecordtime.SetActive(false);
        itatotalgames.SetActive(false);
        itatotaldeaths.SetActive(false);
        itaback.SetActive(false);

        spastatistics.SetActive(true);
        sparecordtime.SetActive(true);
        spatotalgames.SetActive(true);
        spatotaldeaths.SetActive(true);
        spaback.SetActive(true);

        porstatistics.SetActive(false);
        porrecordtime.SetActive(false);
        portotalgames.SetActive(false);
        portotaldeaths.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 6;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void porbayrak()
    {
        turstatistics.SetActive(false);
        turrecordtime.SetActive(false);
        turtotalgames.SetActive(false);
        turtotaldeaths.SetActive(false);
        turback.SetActive(false);

        engstatistics.SetActive(false);
        engrecordtime.SetActive(false);
        engtotalgames.SetActive(false);
        engtotaldeaths.SetActive(false);
        engback.SetActive(false);

        frastatistics.SetActive(false);
        frarecordtime.SetActive(false);
        fratotalgames.SetActive(false);
        fratotaldeaths.SetActive(false);
        fraback.SetActive(false);

        gerstatistics.SetActive(false);
        gerrecordtime.SetActive(false);
        gertotalgames.SetActive(false);
        gertotaldeaths.SetActive(false);
        gerback.SetActive(false);

        russtatistics.SetActive(false);
        rusrecordtime.SetActive(false);
        rustotalgames.SetActive(false);
        rustotaldeaths.SetActive(false);
        rusback.SetActive(false);

        itastatistics.SetActive(false);
        itarecordtime.SetActive(false);
        itatotalgames.SetActive(false);
        itatotaldeaths.SetActive(false);
        itaback.SetActive(false);

        spastatistics.SetActive(false);
        sparecordtime.SetActive(false);
        spatotalgames.SetActive(false);
        spatotaldeaths.SetActive(false);
        spaback.SetActive(false);

        porstatistics.SetActive(true);
        porrecordtime.SetActive(true);
        portotalgames.SetActive(true);
        portotaldeaths.SetActive(true);
        porback.SetActive(true);

        hangidilaktif = 7;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}