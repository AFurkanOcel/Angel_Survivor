using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dilfrom : MonoBehaviour
{
    int hangidilaktif = 0;

    public GameObject turgamemaker;
    public GameObject turthanks;
    public GameObject turback;

    public GameObject enggamemaker;
    public GameObject engthanks;
    public GameObject engback;

    public GameObject fragamemaker;
    public GameObject frathanks;
    public GameObject fraback;

    public GameObject gergamemaker;
    public GameObject gerthanks;
    public GameObject gerback;

    public GameObject rusgamemaker;
    public GameObject rusthanks;
    public GameObject rusback;

    public GameObject itagamemaker;
    public GameObject itathanks;
    public GameObject itaback;

    public GameObject spagamemaker;
    public GameObject spathanks;
    public GameObject spaback;

    public GameObject porgamemaker;
    public GameObject porthanks;
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
        turgamemaker.SetActive(true);
        turthanks.SetActive(true);
        turback.SetActive(true);

        enggamemaker.SetActive(false);
        engthanks.SetActive(false);
        engback.SetActive(false);

        fragamemaker.SetActive(false);
        frathanks.SetActive(false);
        fraback.SetActive(false);

        gergamemaker.SetActive(false);
        gerthanks.SetActive(false);
        gerback.SetActive(false);

        rusgamemaker.SetActive(false);
        rusthanks.SetActive(false);
        rusback.SetActive(false);

        itagamemaker.SetActive(false);
        itathanks.SetActive(false);
        itaback.SetActive(false);

        spagamemaker.SetActive(false);
        spathanks.SetActive(false);
        spaback.SetActive(false);

        porgamemaker.SetActive(false);
        porthanks.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void engbayrak()
    {
        turgamemaker.SetActive(false);
        turthanks.SetActive(false);
        turback.SetActive(false);

        enggamemaker.SetActive(true);
        engthanks.SetActive(true);
        engback.SetActive(true);

        fragamemaker.SetActive(false);
        frathanks.SetActive(false);
        fraback.SetActive(false);

        gergamemaker.SetActive(false);
        gerthanks.SetActive(false);
        gerback.SetActive(false);

        rusgamemaker.SetActive(false);
        rusthanks.SetActive(false);
        rusback.SetActive(false);

        itagamemaker.SetActive(false);
        itathanks.SetActive(false);
        itaback.SetActive(false);

        spagamemaker.SetActive(false);
        spathanks.SetActive(false);
        spaback.SetActive(false);

        porgamemaker.SetActive(false);
        porthanks.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void frabayrak()
    {
        turgamemaker.SetActive(false);
        turthanks.SetActive(false);
        turback.SetActive(false);

        enggamemaker.SetActive(false);
        engthanks.SetActive(false);
        engback.SetActive(false);

        fragamemaker.SetActive(true);
        frathanks.SetActive(true);
        fraback.SetActive(true);

        gergamemaker.SetActive(false);
        gerthanks.SetActive(false);
        gerback.SetActive(false);

        rusgamemaker.SetActive(false);
        rusthanks.SetActive(false);
        rusback.SetActive(false);

        itagamemaker.SetActive(false);
        itathanks.SetActive(false);
        itaback.SetActive(false);

        spagamemaker.SetActive(false);
        spathanks.SetActive(false);
        spaback.SetActive(false);

        porgamemaker.SetActive(false);
        porthanks.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 2;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void gerbayrak()
    {
        turgamemaker.SetActive(false);
        turthanks.SetActive(false);
        turback.SetActive(false);

        enggamemaker.SetActive(false);
        engthanks.SetActive(false);
        engback.SetActive(false);

        fragamemaker.SetActive(false);
        frathanks.SetActive(false);
        fraback.SetActive(false);

        gergamemaker.SetActive(true);
        gerthanks.SetActive(true);
        gerback.SetActive(true);

        rusgamemaker.SetActive(false);
        rusthanks.SetActive(false);
        rusback.SetActive(false);

        itagamemaker.SetActive(false);
        itathanks.SetActive(false);
        itaback.SetActive(false);

        spagamemaker.SetActive(false);
        spathanks.SetActive(false);
        spaback.SetActive(false);

        porgamemaker.SetActive(false);
        porthanks.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 3;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void rusbayrak()
    {
        turgamemaker.SetActive(false);
        turthanks.SetActive(false);
        turback.SetActive(false);

        enggamemaker.SetActive(false);
        engthanks.SetActive(false);
        engback.SetActive(false);

        fragamemaker.SetActive(false);
        frathanks.SetActive(false);
        fraback.SetActive(false);

        gergamemaker.SetActive(false);
        gerthanks.SetActive(false);
        gerback.SetActive(false);

        rusgamemaker.SetActive(true);
        rusthanks.SetActive(true);
        rusback.SetActive(true);

        itagamemaker.SetActive(false);
        itathanks.SetActive(false);
        itaback.SetActive(false);

        spagamemaker.SetActive(false);
        spathanks.SetActive(false);
        spaback.SetActive(false);

        porgamemaker.SetActive(false);
        porthanks.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 4;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void itabayrak()
    {
        turgamemaker.SetActive(false);
        turthanks.SetActive(false);
        turback.SetActive(false);

        enggamemaker.SetActive(false);
        engthanks.SetActive(false);
        engback.SetActive(false);

        fragamemaker.SetActive(false);
        frathanks.SetActive(false);
        fraback.SetActive(false);

        gergamemaker.SetActive(false);
        gerthanks.SetActive(false);
        gerback.SetActive(false);

        rusgamemaker.SetActive(false);
        rusthanks.SetActive(false);
        rusback.SetActive(false);

        itagamemaker.SetActive(true);
        itathanks.SetActive(true);
        itaback.SetActive(true);

        spagamemaker.SetActive(false);
        spathanks.SetActive(false);
        spaback.SetActive(false);

        porgamemaker.SetActive(false);
        porthanks.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 5;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void spabayrak()
    {
        turgamemaker.SetActive(false);
        turthanks.SetActive(false);
        turback.SetActive(false);

        enggamemaker.SetActive(false);
        engthanks.SetActive(false);
        engback.SetActive(false);

        fragamemaker.SetActive(false);
        frathanks.SetActive(false);
        fraback.SetActive(false);

        gergamemaker.SetActive(false);
        gerthanks.SetActive(false);
        gerback.SetActive(false);

        rusgamemaker.SetActive(false);
        rusthanks.SetActive(false);
        rusback.SetActive(false);

        itagamemaker.SetActive(false);
        itathanks.SetActive(false);
        itaback.SetActive(false);

        spagamemaker.SetActive(true);
        spathanks.SetActive(true);
        spaback.SetActive(true);

        porgamemaker.SetActive(false);
        porthanks.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 6;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void porbayrak()
    {
        turgamemaker.SetActive(false);
        turthanks.SetActive(false);
        turback.SetActive(false);

        enggamemaker.SetActive(false);
        engthanks.SetActive(false);
        engback.SetActive(false);

        fragamemaker.SetActive(false);
        frathanks.SetActive(false);
        fraback.SetActive(false);

        gergamemaker.SetActive(false);
        gerthanks.SetActive(false);
        gerback.SetActive(false);

        rusgamemaker.SetActive(false);
        rusthanks.SetActive(false);
        rusback.SetActive(false);

        itagamemaker.SetActive(false);
        itathanks.SetActive(false);
        itaback.SetActive(false);

        spagamemaker.SetActive(false);
        spathanks.SetActive(false);
        spaback.SetActive(false);

        porgamemaker.SetActive(true);
        porthanks.SetActive(true);
        porback.SetActive(true);

        hangidilaktif = 7;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}
