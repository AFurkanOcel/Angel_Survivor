using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dilsettings : MonoBehaviour
{
    int hangidilaktif = 0;

    public GameObject turgamemusic;
    public GameObject turlanguages;
    public GameObject tursounds;
    public GameObject turback;

    public GameObject enggamemusic;
    public GameObject englanguages;
    public GameObject engsounds;
    public GameObject engback;

    public GameObject fragamemusic;
    public GameObject fralanguages;
    public GameObject frasounds;
    public GameObject fraback;

    public GameObject gergamemusic;
    public GameObject gerlanguages;
    public GameObject gersounds;
    public GameObject gerback;

    public GameObject rusgamemusic;
    public GameObject ruslanguages;
    public GameObject russounds;
    public GameObject rusback;

    public GameObject itagamemusic;
    public GameObject italanguages;
    public GameObject itasounds;
    public GameObject itaback;

    public GameObject spagamemusic;
    public GameObject spalanguages;
    public GameObject spasounds;
    public GameObject spaback;

    public GameObject porgamemusic;
    public GameObject porlanguages;
    public GameObject porsounds;
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
        turgamemusic.SetActive(true);
        turlanguages.SetActive(true);
        tursounds.SetActive(true);
        turback.SetActive(true);

        enggamemusic.SetActive(false);
        englanguages.SetActive(false);
        engsounds.SetActive(false);
        engback.SetActive(false);

        fragamemusic.SetActive(false);
        fralanguages.SetActive(false);
        frasounds.SetActive(false);
        fraback.SetActive(false);

        gergamemusic.SetActive(false);
        gerlanguages.SetActive(false);
        gersounds.SetActive(false);
        gerback.SetActive(false);

        rusgamemusic.SetActive(false);
        ruslanguages.SetActive(false);
        russounds.SetActive(false);
        rusback.SetActive(false);

        itagamemusic.SetActive(false);
        italanguages.SetActive(false);
        itasounds.SetActive(false);
        itaback.SetActive(false);

        spagamemusic.SetActive(false);
        spalanguages.SetActive(false);
        spasounds.SetActive(false);
        spaback.SetActive(false);

        porgamemusic.SetActive(false);
        porlanguages.SetActive(false);
        porsounds.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void engbayrak()
    {
        turgamemusic.SetActive(false);
        turlanguages.SetActive(false);
        tursounds.SetActive(false);
        turback.SetActive(false);

        enggamemusic.SetActive(true);
        englanguages.SetActive(true);
        engsounds.SetActive(true);
        engback.SetActive(true);

        fragamemusic.SetActive(false);
        fralanguages.SetActive(false);
        frasounds.SetActive(false);
        fraback.SetActive(false);

        gergamemusic.SetActive(false);
        gerlanguages.SetActive(false);
        gersounds.SetActive(false);
        gerback.SetActive(false);

        rusgamemusic.SetActive(false);
        ruslanguages.SetActive(false);
        russounds.SetActive(false);
        rusback.SetActive(false);

        itagamemusic.SetActive(false);
        italanguages.SetActive(false);
        itasounds.SetActive(false);
        itaback.SetActive(false);

        spagamemusic.SetActive(false);
        spalanguages.SetActive(false);
        spasounds.SetActive(false);
        spaback.SetActive(false);

        porgamemusic.SetActive(false);
        porlanguages.SetActive(false);
        porsounds.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void frabayrak()
    {
        turgamemusic.SetActive(false);
        turlanguages.SetActive(false);
        tursounds.SetActive(false);
        turback.SetActive(false);

        enggamemusic.SetActive(false);
        englanguages.SetActive(false);
        engsounds.SetActive(false);
        engback.SetActive(false);

        fragamemusic.SetActive(true);
        fralanguages.SetActive(true);
        frasounds.SetActive(true);
        fraback.SetActive(true);

        gergamemusic.SetActive(false);
        gerlanguages.SetActive(false);
        gersounds.SetActive(false);
        gerback.SetActive(false);

        rusgamemusic.SetActive(false);
        ruslanguages.SetActive(false);
        russounds.SetActive(false);
        rusback.SetActive(false);

        itagamemusic.SetActive(false);
        italanguages.SetActive(false);
        itasounds.SetActive(false);
        itaback.SetActive(false);

        spagamemusic.SetActive(false);
        spalanguages.SetActive(false);
        spasounds.SetActive(false);
        spaback.SetActive(false);

        porgamemusic.SetActive(false);
        porlanguages.SetActive(false);
        porsounds.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 2;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void gerbayrak()
    {
        turgamemusic.SetActive(false);
        turlanguages.SetActive(false);
        tursounds.SetActive(false);
        turback.SetActive(false);

        enggamemusic.SetActive(false);
        englanguages.SetActive(false);
        engsounds.SetActive(false);
        engback.SetActive(false);

        fragamemusic.SetActive(false);
        fralanguages.SetActive(false);
        frasounds.SetActive(false);
        fraback.SetActive(false);

        gergamemusic.SetActive(true);
        gerlanguages.SetActive(true);
        gersounds.SetActive(true);
        gerback.SetActive(true);

        rusgamemusic.SetActive(false);
        ruslanguages.SetActive(false);
        russounds.SetActive(false);
        rusback.SetActive(false);

        itagamemusic.SetActive(false);
        italanguages.SetActive(false);
        itasounds.SetActive(false);
        itaback.SetActive(false);

        spagamemusic.SetActive(false);
        spalanguages.SetActive(false);
        spasounds.SetActive(false);
        spaback.SetActive(false);

        porgamemusic.SetActive(false);
        porlanguages.SetActive(false);
        porsounds.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 3;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void rusbayrak()
    {
        turgamemusic.SetActive(false);
        turlanguages.SetActive(false);
        tursounds.SetActive(false);
        turback.SetActive(false);

        enggamemusic.SetActive(false);
        englanguages.SetActive(false);
        engsounds.SetActive(false);
        engback.SetActive(false);

        fragamemusic.SetActive(false);
        fralanguages.SetActive(false);
        frasounds.SetActive(false);
        fraback.SetActive(false);

        gergamemusic.SetActive(false);
        gerlanguages.SetActive(false);
        gersounds.SetActive(false);
        gerback.SetActive(false);

        rusgamemusic.SetActive(true);
        ruslanguages.SetActive(true);
        russounds.SetActive(true);
        rusback.SetActive(true);

        itagamemusic.SetActive(false);
        italanguages.SetActive(false);
        itasounds.SetActive(false);
        itaback.SetActive(false);

        spagamemusic.SetActive(false);
        spalanguages.SetActive(false);
        spasounds.SetActive(false);
        spaback.SetActive(false);

        porgamemusic.SetActive(false);
        porlanguages.SetActive(false);
        porsounds.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 4;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void itabayrak()
    {
        turgamemusic.SetActive(false);
        turlanguages.SetActive(false);
        tursounds.SetActive(false);
        turback.SetActive(false);

        enggamemusic.SetActive(false);
        englanguages.SetActive(false);
        engsounds.SetActive(false);
        engback.SetActive(false);

        fragamemusic.SetActive(false);
        fralanguages.SetActive(false);
        frasounds.SetActive(false);
        fraback.SetActive(false);

        gergamemusic.SetActive(false);
        gerlanguages.SetActive(false);
        gersounds.SetActive(false);
        gerback.SetActive(false);

        rusgamemusic.SetActive(false);
        ruslanguages.SetActive(false);
        russounds.SetActive(false);
        rusback.SetActive(false);

        itagamemusic.SetActive(true);
        italanguages.SetActive(true);
        itasounds.SetActive(true);
        itaback.SetActive(true);

        spagamemusic.SetActive(false);
        spalanguages.SetActive(false);
        spasounds.SetActive(false);
        spaback.SetActive(false);

        porgamemusic.SetActive(false);
        porlanguages.SetActive(false);
        porsounds.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 5;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void spabayrak()
    {
        turgamemusic.SetActive(false);
        turlanguages.SetActive(false);
        tursounds.SetActive(false);
        turback.SetActive(false);

        enggamemusic.SetActive(false);
        englanguages.SetActive(false);
        engsounds.SetActive(false);
        engback.SetActive(false);

        fragamemusic.SetActive(false);
        fralanguages.SetActive(false);
        frasounds.SetActive(false);
        fraback.SetActive(false);

        gergamemusic.SetActive(false);
        gerlanguages.SetActive(false);
        gersounds.SetActive(false);
        gerback.SetActive(false);

        rusgamemusic.SetActive(false);
        ruslanguages.SetActive(false);
        russounds.SetActive(false);
        rusback.SetActive(false);

        itagamemusic.SetActive(false);
        italanguages.SetActive(false);
        itasounds.SetActive(false);
        itaback.SetActive(false);

        spagamemusic.SetActive(true);
        spalanguages.SetActive(true);
        spasounds.SetActive(true);
        spaback.SetActive(true);

        porgamemusic.SetActive(false);
        porlanguages.SetActive(false);
        porsounds.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 6;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void porbayrak()
    {
        turgamemusic.SetActive(false);
        turlanguages.SetActive(false);
        tursounds.SetActive(false);
        turback.SetActive(false);

        enggamemusic.SetActive(false);
        englanguages.SetActive(false);
        engsounds.SetActive(false);
        engback.SetActive(false);

        fragamemusic.SetActive(false);
        fralanguages.SetActive(false);
        frasounds.SetActive(false);
        fraback.SetActive(false);

        gergamemusic.SetActive(false);
        gerlanguages.SetActive(false);
        gersounds.SetActive(false);
        gerback.SetActive(false);

        rusgamemusic.SetActive(false);
        ruslanguages.SetActive(false);
        russounds.SetActive(false);
        rusback.SetActive(false);

        itagamemusic.SetActive(false);
        italanguages.SetActive(false);
        itasounds.SetActive(false);
        itaback.SetActive(false);

        spagamemusic.SetActive(false);
        spalanguages.SetActive(false);
        spasounds.SetActive(false);
        spaback.SetActive(false);

        porgamemusic.SetActive(true);
        porlanguages.SetActive(true);
        porsounds.SetActive(true);
        porback.SetActive(true);

        hangidilaktif = 7;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}
