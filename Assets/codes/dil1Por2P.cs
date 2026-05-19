using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dil1Por2P : MonoBehaviour
{
    int hangidilaktif = 0;

    public GameObject turoneplayer;
    public GameObject turtwoplayers;
    public GameObject turback;

    public GameObject engoneplayer;
    public GameObject engtwoplayers;
    public GameObject engback;

    public GameObject fraoneplayer;
    public GameObject fratwoplayers;
    public GameObject fraback;

    public GameObject geroneplayer;
    public GameObject gertwoplayers;
    public GameObject gerback;

    public GameObject rusoneplayer;
    public GameObject rustwoplayers;
    public GameObject rusback;

    public GameObject itaoneplayer;
    public GameObject itatwoplayers;
    public GameObject itaback;

    public GameObject spaoneplayer;
    public GameObject spatwoplayers;
    public GameObject spaback;

    public GameObject poroneplayer;
    public GameObject portwoplayers;
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
        turoneplayer.SetActive(true);
        turtwoplayers.SetActive(true);
        turback.SetActive(true);

        engoneplayer.SetActive(false);
        engtwoplayers.SetActive(false);
        engback.SetActive(false);

        fraoneplayer.SetActive(false);
        fratwoplayers.SetActive(false);
        fraback.SetActive(false);

        geroneplayer.SetActive(false);
        gertwoplayers.SetActive(false);
        gerback.SetActive(false);

        rusoneplayer.SetActive(false);
        rustwoplayers.SetActive(false);
        rusback.SetActive(false);

        itaoneplayer.SetActive(false);
        itatwoplayers.SetActive(false);
        itaback.SetActive(false);

        spaoneplayer.SetActive(false);
        spatwoplayers.SetActive(false);
        spaback.SetActive(false);

        poroneplayer.SetActive(false);
        portwoplayers.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void engbayrak()
    {
        turoneplayer.SetActive(false);
        turtwoplayers.SetActive(false);
        turback.SetActive(false);

        engoneplayer.SetActive(true);
        engtwoplayers.SetActive(true);
        engback.SetActive(true);

        fraoneplayer.SetActive(false);
        fratwoplayers.SetActive(false);
        fraback.SetActive(false);

        geroneplayer.SetActive(false);
        gertwoplayers.SetActive(false);
        gerback.SetActive(false);

        rusoneplayer.SetActive(false);
        rustwoplayers.SetActive(false);
        rusback.SetActive(false);

        itaoneplayer.SetActive(false);
        itatwoplayers.SetActive(false);
        itaback.SetActive(false);

        spaoneplayer.SetActive(false);
        spatwoplayers.SetActive(false);
        spaback.SetActive(false);

        poroneplayer.SetActive(false);
        portwoplayers.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void frabayrak()
    {
        turoneplayer.SetActive(false);
        turtwoplayers.SetActive(false);
        turback.SetActive(false);

        engoneplayer.SetActive(false);
        engtwoplayers.SetActive(false);
        engback.SetActive(false);

        fraoneplayer.SetActive(true);
        fratwoplayers.SetActive(true);
        fraback.SetActive(true);

        geroneplayer.SetActive(false);
        gertwoplayers.SetActive(false);
        gerback.SetActive(false);

        rusoneplayer.SetActive(false);
        rustwoplayers.SetActive(false);
        rusback.SetActive(false);

        itaoneplayer.SetActive(false);
        itatwoplayers.SetActive(false);
        itaback.SetActive(false);

        spaoneplayer.SetActive(false);
        spatwoplayers.SetActive(false);
        spaback.SetActive(false);

        poroneplayer.SetActive(false);
        portwoplayers.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 2;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void gerbayrak()
    {
        turoneplayer.SetActive(false);
        turtwoplayers.SetActive(false);
        turback.SetActive(false);

        engoneplayer.SetActive(false);
        engtwoplayers.SetActive(false);
        engback.SetActive(false);

        fraoneplayer.SetActive(false);
        fratwoplayers.SetActive(false);
        fraback.SetActive(false);

        geroneplayer.SetActive(true);
        gertwoplayers.SetActive(true);
        gerback.SetActive(true);

        rusoneplayer.SetActive(false);
        rustwoplayers.SetActive(false);
        rusback.SetActive(false);

        itaoneplayer.SetActive(false);
        itatwoplayers.SetActive(false);
        itaback.SetActive(false);

        spaoneplayer.SetActive(false);
        spatwoplayers.SetActive(false);
        spaback.SetActive(false);

        poroneplayer.SetActive(false);
        portwoplayers.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 3;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void rusbayrak()
    {
        turoneplayer.SetActive(false);
        turtwoplayers.SetActive(false);
        turback.SetActive(false);

        engoneplayer.SetActive(false);
        engtwoplayers.SetActive(false);
        engback.SetActive(false);

        fraoneplayer.SetActive(false);
        fratwoplayers.SetActive(false);
        fraback.SetActive(false);

        geroneplayer.SetActive(false);
        gertwoplayers.SetActive(false);
        gerback.SetActive(false);

        rusoneplayer.SetActive(true);
        rustwoplayers.SetActive(true);
        rusback.SetActive(true);

        itaoneplayer.SetActive(false);
        itatwoplayers.SetActive(false);
        itaback.SetActive(false);

        spaoneplayer.SetActive(false);
        spatwoplayers.SetActive(false);
        spaback.SetActive(false);

        poroneplayer.SetActive(false);
        portwoplayers.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 4;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void itabayrak()
    {
        turoneplayer.SetActive(false);
        turtwoplayers.SetActive(false);
        turback.SetActive(false);

        engoneplayer.SetActive(false);
        engtwoplayers.SetActive(false);
        engback.SetActive(false);

        fraoneplayer.SetActive(false);
        fratwoplayers.SetActive(false);
        fraback.SetActive(false);

        geroneplayer.SetActive(false);
        gertwoplayers.SetActive(false);
        gerback.SetActive(false);

        rusoneplayer.SetActive(false);
        rustwoplayers.SetActive(false);
        rusback.SetActive(false);

        itaoneplayer.SetActive(true);
        itatwoplayers.SetActive(true);
        itaback.SetActive(true);

        spaoneplayer.SetActive(false);
        spatwoplayers.SetActive(false);
        spaback.SetActive(false);

        poroneplayer.SetActive(false);
        portwoplayers.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 5;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void spabayrak()
    {
        turoneplayer.SetActive(false);
        turtwoplayers.SetActive(false);
        turback.SetActive(false);

        engoneplayer.SetActive(false);
        engtwoplayers.SetActive(false);
        engback.SetActive(false);

        fraoneplayer.SetActive(false);
        fratwoplayers.SetActive(false);
        fraback.SetActive(false);

        geroneplayer.SetActive(false);
        gertwoplayers.SetActive(false);
        gerback.SetActive(false);

        rusoneplayer.SetActive(false);
        rustwoplayers.SetActive(false);
        rusback.SetActive(false);

        itaoneplayer.SetActive(false);
        itatwoplayers.SetActive(false);
        itaback.SetActive(false);

        spaoneplayer.SetActive(true);
        spatwoplayers.SetActive(true);
        spaback.SetActive(true);

        poroneplayer.SetActive(false);
        portwoplayers.SetActive(false);
        porback.SetActive(false);

        hangidilaktif = 6;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }

    public void porbayrak()
    {
        turoneplayer.SetActive(false);
        turtwoplayers.SetActive(false);
        turback.SetActive(false);

        engoneplayer.SetActive(false);
        engtwoplayers.SetActive(false);
        engback.SetActive(false);

        fraoneplayer.SetActive(false);
        fratwoplayers.SetActive(false);
        fraback.SetActive(false);

        geroneplayer.SetActive(false);
        gertwoplayers.SetActive(false);
        gerback.SetActive(false);

        rusoneplayer.SetActive(false);
        rustwoplayers.SetActive(false);
        rusback.SetActive(false);

        itaoneplayer.SetActive(false);
        itatwoplayers.SetActive(false);
        itaback.SetActive(false);

        spaoneplayer.SetActive(false);
        spatwoplayers.SetActive(false);
        spaback.SetActive(false);

        poroneplayer.SetActive(true);
        portwoplayers.SetActive(true);
        porback.SetActive(true);

        hangidilaktif = 7;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}
