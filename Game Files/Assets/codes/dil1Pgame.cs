using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dil1Pgame : MonoBehaviour
{
    int hangidilaktif = 0;

    public GameObject turlight;
    public GameObject turback;
    public GameObject turpause;
    public GameObject turreplay;
    public GameObject turplayer;
    public GameObject turrecordtime;
    public GameObject turtime;
    public GameObject turbackendscene;
    public GameObject turreplayendscene;

    public GameObject englight;
    public GameObject engback;
    public GameObject engpause;
    public GameObject engreplay;
    public GameObject engplayer;
    public GameObject engrecordtime;
    public GameObject engtime;
    public GameObject engbackendscene;
    public GameObject engreplayendscene;

    public GameObject fralight;
    public GameObject fraback;
    public GameObject frapause;
    public GameObject frareplay;
    public GameObject fraplayer;
    public GameObject frarecordtime;
    public GameObject fratime;
    public GameObject frabackendscene;
    public GameObject frareplayendscene;

    public GameObject gerlight;
    public GameObject gerback;
    public GameObject gerpause;
    public GameObject gerreplay;
    public GameObject gerplayer;
    public GameObject gerrecordtime;
    public GameObject gertime;
    public GameObject gerbackendscene;
    public GameObject gerreplayendscene;

    public GameObject ruslight;
    public GameObject rusback;
    public GameObject ruspause;
    public GameObject rusreplay;
    public GameObject rusplayer;
    public GameObject rusrecordtime;
    public GameObject rustime;
    public GameObject rusbackendscene;
    public GameObject rusreplayendscene;

    public GameObject italight;
    public GameObject itaback;
    public GameObject itapause;
    public GameObject itareplay;
    public GameObject itaplayer;
    public GameObject itarecordtime;
    public GameObject itatime;
    public GameObject itabackendscene;
    public GameObject itareplayendscene;

    public GameObject spalight;
    public GameObject spaback;
    public GameObject spapause;
    public GameObject spareplay;
    public GameObject spaplayer;
    public GameObject sparecordtime;
    public GameObject spatime;
    public GameObject spabackendscene;
    public GameObject spareplayendscene;

    public GameObject porlight;
    public GameObject porback;
    public GameObject porpause;
    public GameObject porreplay;
    public GameObject porplayer;
    public GameObject porrecordtime;
    public GameObject portime;
    public GameObject porbackendscene;
    public GameObject porreplayendscene;

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
        turlight.SetActive(true);
        turback.SetActive(true);
        turpause.SetActive(true);
        turreplay.SetActive(true);
        turplayer.SetActive(true);
        turrecordtime.SetActive(true);
        turtime.SetActive(true);
        turbackendscene.SetActive(true);
        turreplayendscene.SetActive(true);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer.SetActive(false);
        engrecordtime.SetActive(false);
        engtime.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer.SetActive(false);
        frarecordtime.SetActive(false);
        fratime.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer.SetActive(false);
        gerrecordtime.SetActive(false);
        gertime.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer.SetActive(false);
        rusrecordtime.SetActive(false);
        rustime.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer.SetActive(false);
        itarecordtime.SetActive(false);
        itatime.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer.SetActive(false);
        sparecordtime.SetActive(false);
        spatime.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer.SetActive(false);
        porrecordtime.SetActive(false);
        portime.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void engbayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer.SetActive(false);
        turrecordtime.SetActive(false);
        turtime.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);

        englight.SetActive(true);
        engback.SetActive(true);
        engpause.SetActive(true);
        engreplay.SetActive(true);
        engplayer.SetActive(true);
        engrecordtime.SetActive(true);
        engtime.SetActive(true);
        engbackendscene.SetActive(true);
        engreplayendscene.SetActive(true);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer.SetActive(false);
        frarecordtime.SetActive(false);
        fratime.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer.SetActive(false);
        gerrecordtime.SetActive(false);
        gertime.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer.SetActive(false);
        rusrecordtime.SetActive(false);
        rustime.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer.SetActive(false);
        itarecordtime.SetActive(false);
        itatime.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer.SetActive(false);
        sparecordtime.SetActive(false);
        spatime.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer.SetActive(false);
        porrecordtime.SetActive(false);
        portime.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void frabayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer.SetActive(false);
        turrecordtime.SetActive(false);
        turtime.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer.SetActive(false);
        engrecordtime.SetActive(false);
        engtime.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);

        fralight.SetActive(true);
        fraback.SetActive(true);
        frapause.SetActive(true);
        frareplay.SetActive(true);
        fraplayer.SetActive(true);
        frarecordtime.SetActive(true);
        fratime.SetActive(true);
        frabackendscene.SetActive(true);
        frareplayendscene.SetActive(true);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer.SetActive(false);
        gerrecordtime.SetActive(false);
        gertime.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer.SetActive(false);
        rusrecordtime.SetActive(false);
        rustime.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer.SetActive(false);
        itarecordtime.SetActive(false);
        itatime.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer.SetActive(false);
        sparecordtime.SetActive(false);
        spatime.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer.SetActive(false);
        porrecordtime.SetActive(false);
        portime.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);

        hangidilaktif = 2;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void gerbayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer.SetActive(false);
        turrecordtime.SetActive(false);
        turtime.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer.SetActive(false);
        engrecordtime.SetActive(false);
        engtime.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer.SetActive(false);
        frarecordtime.SetActive(false);
        fratime.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);

        gerlight.SetActive(true);
        gerback.SetActive(true);
        gerpause.SetActive(true);
        gerreplay.SetActive(true);
        gerplayer.SetActive(true);
        gerrecordtime.SetActive(true);
        gertime.SetActive(true);
        gerbackendscene.SetActive(true);
        gerreplayendscene.SetActive(true);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer.SetActive(false);
        rusrecordtime.SetActive(false);
        rustime.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer.SetActive(false);
        itarecordtime.SetActive(false);
        itatime.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer.SetActive(false);
        sparecordtime.SetActive(false);
        spatime.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer.SetActive(false);
        porrecordtime.SetActive(false);
        portime.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);

        hangidilaktif = 3;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void rusbayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer.SetActive(false);
        turrecordtime.SetActive(false);
        turtime.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer.SetActive(false);
        engrecordtime.SetActive(false);
        engtime.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer.SetActive(false);
        frarecordtime.SetActive(false);
        fratime.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer.SetActive(false);
        gerrecordtime.SetActive(false);
        gertime.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);

        ruslight.SetActive(true);
        rusback.SetActive(true);
        ruspause.SetActive(true);
        rusreplay.SetActive(true);
        rusplayer.SetActive(true);
        rusrecordtime.SetActive(true);
        rustime.SetActive(true);
        rusbackendscene.SetActive(true);
        rusreplayendscene.SetActive(true);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer.SetActive(false);
        itarecordtime.SetActive(false);
        itatime.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer.SetActive(false);
        sparecordtime.SetActive(false);
        spatime.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer.SetActive(false);
        porrecordtime.SetActive(false);
        portime.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);

        hangidilaktif = 4;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void itabayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer.SetActive(false);
        turrecordtime.SetActive(false);
        turtime.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer.SetActive(false);
        engrecordtime.SetActive(false);
        engtime.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer.SetActive(false);
        frarecordtime.SetActive(false);
        fratime.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer.SetActive(false);
        gerrecordtime.SetActive(false);
        gertime.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer.SetActive(false);
        rusrecordtime.SetActive(false);
        rustime.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);

        italight.SetActive(true);
        itaback.SetActive(true);
        itapause.SetActive(true);
        itareplay.SetActive(true);
        itaplayer.SetActive(true);
        itarecordtime.SetActive(true);
        itatime.SetActive(true);
        itabackendscene.SetActive(true);
        itareplayendscene.SetActive(true);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer.SetActive(false);
        sparecordtime.SetActive(false);
        spatime.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer.SetActive(false);
        porrecordtime.SetActive(false);
        portime.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);

        hangidilaktif = 5;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void spabayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer.SetActive(false);
        turrecordtime.SetActive(false);
        turtime.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer.SetActive(false);
        engrecordtime.SetActive(false);
        engtime.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer.SetActive(false);
        frarecordtime.SetActive(false);
        fratime.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer.SetActive(false);
        gerrecordtime.SetActive(false);
        gertime.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer.SetActive(false);
        rusrecordtime.SetActive(false);
        rustime.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer.SetActive(false);
        itarecordtime.SetActive(false);
        itatime.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);

        spalight.SetActive(true);
        spaback.SetActive(true);
        spapause.SetActive(true);
        spareplay.SetActive(true);
        spaplayer.SetActive(true);
        sparecordtime.SetActive(true);
        spatime.SetActive(true);
        spabackendscene.SetActive(true);
        spareplayendscene.SetActive(true);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer.SetActive(false);
        porrecordtime.SetActive(false);
        portime.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);

        hangidilaktif = 6;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void porbayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer.SetActive(false);
        turrecordtime.SetActive(false);
        turtime.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer.SetActive(false);
        engrecordtime.SetActive(false);
        engtime.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer.SetActive(false);
        frarecordtime.SetActive(false);
        fratime.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer.SetActive(false);
        gerrecordtime.SetActive(false);
        gertime.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer.SetActive(false);
        rusrecordtime.SetActive(false);
        rustime.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer.SetActive(false);
        itarecordtime.SetActive(false);
        itatime.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer.SetActive(false);
        sparecordtime.SetActive(false);
        spatime.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);

        porlight.SetActive(true);
        porback.SetActive(true);
        porpause.SetActive(true);
        porreplay.SetActive(true);
        porplayer.SetActive(true);
        porrecordtime.SetActive(true);
        portime.SetActive(true);
        porbackendscene.SetActive(true);
        porreplayendscene.SetActive(true);

        hangidilaktif = 7;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}
