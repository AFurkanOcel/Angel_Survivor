using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dil2Pgame : MonoBehaviour
{
    int hangidilaktif = 0;

    public GameObject turlight;
    public GameObject turback;
    public GameObject turpause;
    public GameObject turreplay;
    public GameObject turplayer1;
    public GameObject turplayer2;
    public GameObject turbackendscene;
    public GameObject turreplayendscene;
    public GameObject turplayer1endscene;
    public GameObject turplayer2endscene;
    public GameObject turdrawendscene;

    public GameObject englight;
    public GameObject engback;
    public GameObject engpause;
    public GameObject engreplay;
    public GameObject engplayer1;
    public GameObject engplayer2;
    public GameObject engbackendscene;
    public GameObject engreplayendscene;
    public GameObject engplayer1endscene;
    public GameObject engplayer2endscene;
    public GameObject engdrawendscene;

    public GameObject fralight;
    public GameObject fraback;
    public GameObject frapause;
    public GameObject frareplay;
    public GameObject fraplayer1;
    public GameObject fraplayer2;
    public GameObject frabackendscene;
    public GameObject frareplayendscene;
    public GameObject fraplayer1endscene;
    public GameObject fraplayer2endscene;
    public GameObject fradrawendscene;

    public GameObject gerlight;
    public GameObject gerback;
    public GameObject gerpause;
    public GameObject gerreplay;
    public GameObject gerplayer1;
    public GameObject gerplayer2;
    public GameObject gerbackendscene;
    public GameObject gerreplayendscene;
    public GameObject gerplayer1endscene;
    public GameObject gerplayer2endscene;
    public GameObject gerdrawendscene;

    public GameObject ruslight;
    public GameObject rusback;
    public GameObject ruspause;
    public GameObject rusreplay;
    public GameObject rusplayer1;
    public GameObject rusplayer2;
    public GameObject rusbackendscene;
    public GameObject rusreplayendscene;
    public GameObject rusplayer1endscene;
    public GameObject rusplayer2endscene;
    public GameObject rusdrawendscene;

    public GameObject italight;
    public GameObject itaback;
    public GameObject itapause;
    public GameObject itareplay;
    public GameObject itaplayer1;
    public GameObject itaplayer2;
    public GameObject itabackendscene;
    public GameObject itareplayendscene;
    public GameObject itaplayer1endscene;
    public GameObject itaplayer2endscene;
    public GameObject itadrawendscene;

    public GameObject spalight;
    public GameObject spaback;
    public GameObject spapause;
    public GameObject spareplay;
    public GameObject spaplayer1;
    public GameObject spaplayer2;
    public GameObject spabackendscene;
    public GameObject spareplayendscene;
    public GameObject spaplayer1endscene;
    public GameObject spaplayer2endscene;
    public GameObject spadrawendscene;

    public GameObject porlight;
    public GameObject porback;
    public GameObject porpause;
    public GameObject porreplay;
    public GameObject porplayer1;
    public GameObject porplayer2;
    public GameObject porbackendscene;
    public GameObject porreplayendscene;
    public GameObject porplayer1endscene;
    public GameObject porplayer2endscene;
    public GameObject pordrawendscene;

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
        turplayer1.SetActive(true);
        turplayer2.SetActive(true);
        turbackendscene.SetActive(true);
        turreplayendscene.SetActive(true);
        turplayer1endscene.SetActive(true);
        turplayer2endscene.SetActive(true);
        turdrawendscene.SetActive(true);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer1.SetActive(false);
        engplayer2.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);
        engplayer1endscene.SetActive(false);
        engplayer2endscene.SetActive(false);
        engdrawendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer1.SetActive(false);
        fraplayer2.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);
        fraplayer1endscene.SetActive(false);
        fraplayer2endscene.SetActive(false);
        fradrawendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer1.SetActive(false);
        gerplayer2.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);
        gerplayer1endscene.SetActive(false);
        gerplayer2endscene.SetActive(false);
        gerdrawendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer1.SetActive(false);
        rusplayer2.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);
        rusplayer1endscene.SetActive(false);
        rusplayer2endscene.SetActive(false);
        rusdrawendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer1.SetActive(false);
        itaplayer2.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);
        itaplayer1endscene.SetActive(false);
        itaplayer2endscene.SetActive(false);
        itadrawendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer1.SetActive(false);
        spaplayer2.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);
        spaplayer1endscene.SetActive(false);
        spaplayer2endscene.SetActive(false);
        spadrawendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer1.SetActive(false);
        porplayer2.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);
        porplayer1endscene.SetActive(false);
        porplayer2endscene.SetActive(false);
        pordrawendscene.SetActive(false);

        hangidilaktif = 1;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void engbayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer1.SetActive(false);
        turplayer2.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);
        turplayer1endscene.SetActive(false);
        turplayer2endscene.SetActive(false);
        turdrawendscene.SetActive(false);

        englight.SetActive(true);
        engback.SetActive(true);
        engpause.SetActive(true);
        engreplay.SetActive(true);
        engplayer1.SetActive(true);
        engplayer2.SetActive(true);
        engbackendscene.SetActive(true);
        engreplayendscene.SetActive(true);
        engplayer1endscene.SetActive(true);
        engplayer2endscene.SetActive(true);
        engdrawendscene.SetActive(true);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer1.SetActive(false);
        fraplayer2.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);
        fraplayer1endscene.SetActive(false);
        fraplayer2endscene.SetActive(false);
        fradrawendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer1.SetActive(false);
        gerplayer2.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);
        gerplayer1endscene.SetActive(false);
        gerplayer2endscene.SetActive(false);
        gerdrawendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer1.SetActive(false);
        rusplayer2.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);
        rusplayer1endscene.SetActive(false);
        rusplayer2endscene.SetActive(false);
        rusdrawendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer1.SetActive(false);
        itaplayer2.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);
        itaplayer1endscene.SetActive(false);
        itaplayer2endscene.SetActive(false);
        itadrawendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer1.SetActive(false);
        spaplayer2.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);
        spaplayer1endscene.SetActive(false);
        spaplayer2endscene.SetActive(false);
        spadrawendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer1.SetActive(false);
        porplayer2.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);
        porplayer1endscene.SetActive(false);
        porplayer2endscene.SetActive(false);
        pordrawendscene.SetActive(false);

        hangidilaktif = 0;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void frabayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer1.SetActive(false);
        turplayer2.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);
        turplayer1endscene.SetActive(false);
        turplayer2endscene.SetActive(false);
        turdrawendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer1.SetActive(false);
        engplayer2.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);
        engplayer1endscene.SetActive(false);
        engplayer2endscene.SetActive(false);
        engdrawendscene.SetActive(false);

        fralight.SetActive(true);
        fraback.SetActive(true);
        frapause.SetActive(true);
        frareplay.SetActive(true);
        fraplayer1.SetActive(true);
        fraplayer2.SetActive(true);
        frabackendscene.SetActive(true);
        frareplayendscene.SetActive(true);
        fraplayer1endscene.SetActive(true);
        fraplayer2endscene.SetActive(true);
        fradrawendscene.SetActive(true);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer1.SetActive(false);
        gerplayer2.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);
        gerplayer1endscene.SetActive(false);
        gerplayer2endscene.SetActive(false);
        gerdrawendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer1.SetActive(false);
        rusplayer2.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);
        rusplayer1endscene.SetActive(false);
        rusplayer2endscene.SetActive(false);
        rusdrawendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer1.SetActive(false);
        itaplayer2.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);
        itaplayer1endscene.SetActive(false);
        itaplayer2endscene.SetActive(false);
        itadrawendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer1.SetActive(false);
        spaplayer2.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);
        spaplayer1endscene.SetActive(false);
        spaplayer2endscene.SetActive(false);
        spadrawendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer1.SetActive(false);
        porplayer2.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);
        porplayer1endscene.SetActive(false);
        porplayer2endscene.SetActive(false);
        pordrawendscene.SetActive(false);

        hangidilaktif = 2;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void gerbayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer1.SetActive(false);
        turplayer2.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);
        turplayer1endscene.SetActive(false);
        turplayer2endscene.SetActive(false);
        turdrawendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer1.SetActive(false);
        engplayer2.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);
        engplayer1endscene.SetActive(false);
        engplayer2endscene.SetActive(false);
        engdrawendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer1.SetActive(false);
        fraplayer2.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);
        fraplayer1endscene.SetActive(false);
        fraplayer2endscene.SetActive(false);
        fradrawendscene.SetActive(false);

        gerlight.SetActive(true);
        gerback.SetActive(true);
        gerpause.SetActive(true);
        gerreplay.SetActive(true);
        gerplayer1.SetActive(true);
        gerplayer2.SetActive(true);
        gerbackendscene.SetActive(true);
        gerreplayendscene.SetActive(true);
        gerplayer1endscene.SetActive(true);
        gerplayer2endscene.SetActive(true);
        gerdrawendscene.SetActive(true);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer1.SetActive(false);
        rusplayer2.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);
        rusplayer1endscene.SetActive(false);
        rusplayer2endscene.SetActive(false);
        rusdrawendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer1.SetActive(false);
        itaplayer2.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);
        itaplayer1endscene.SetActive(false);
        itaplayer2endscene.SetActive(false);
        itadrawendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer1.SetActive(false);
        spaplayer2.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);
        spaplayer1endscene.SetActive(false);
        spaplayer2endscene.SetActive(false);
        spadrawendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer1.SetActive(false);
        porplayer2.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);
        porplayer1endscene.SetActive(false);
        porplayer2endscene.SetActive(false);
        pordrawendscene.SetActive(false);

        hangidilaktif = 3;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void rusbayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer1.SetActive(false);
        turplayer2.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);
        turplayer1endscene.SetActive(false);
        turplayer2endscene.SetActive(false);
        turdrawendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer1.SetActive(false);
        engplayer2.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);
        engplayer1endscene.SetActive(false);
        engplayer2endscene.SetActive(false);
        engdrawendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer1.SetActive(false);
        fraplayer2.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);
        fraplayer1endscene.SetActive(false);
        fraplayer2endscene.SetActive(false);
        fradrawendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer1.SetActive(false);
        gerplayer2.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);
        gerplayer1endscene.SetActive(false);
        gerplayer2endscene.SetActive(false);
        gerdrawendscene.SetActive(false);

        ruslight.SetActive(true);
        rusback.SetActive(true);
        ruspause.SetActive(true);
        rusreplay.SetActive(true);
        rusplayer1.SetActive(true);
        rusplayer2.SetActive(true);
        rusbackendscene.SetActive(true);
        rusreplayendscene.SetActive(true);
        rusplayer1endscene.SetActive(true);
        rusplayer2endscene.SetActive(true);
        rusdrawendscene.SetActive(true);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer1.SetActive(false);
        itaplayer2.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);
        itaplayer1endscene.SetActive(false);
        itaplayer2endscene.SetActive(false);
        itadrawendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer1.SetActive(false);
        spaplayer2.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);
        spaplayer1endscene.SetActive(false);
        spaplayer2endscene.SetActive(false);
        spadrawendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer1.SetActive(false);
        porplayer2.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);
        porplayer1endscene.SetActive(false);
        porplayer2endscene.SetActive(false);
        pordrawendscene.SetActive(false);

        hangidilaktif = 4;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void itabayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer1.SetActive(false);
        turplayer2.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);
        turplayer1endscene.SetActive(false);
        turplayer2endscene.SetActive(false);
        turdrawendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer1.SetActive(false);
        engplayer2.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);
        engplayer1endscene.SetActive(false);
        engplayer2endscene.SetActive(false);
        engdrawendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer1.SetActive(false);
        fraplayer2.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);
        fraplayer1endscene.SetActive(false);
        fraplayer2endscene.SetActive(false);
        fradrawendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer1.SetActive(false);
        gerplayer2.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);
        gerplayer1endscene.SetActive(false);
        gerplayer2endscene.SetActive(false);
        gerdrawendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer1.SetActive(false);
        rusplayer2.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);
        rusplayer1endscene.SetActive(false);
        rusplayer2endscene.SetActive(false);
        rusdrawendscene.SetActive(false);

        italight.SetActive(true);
        itaback.SetActive(true);
        itapause.SetActive(true);
        itareplay.SetActive(true);
        itaplayer1.SetActive(true);
        itaplayer2.SetActive(true);
        itabackendscene.SetActive(true);
        itareplayendscene.SetActive(true);
        itaplayer1endscene.SetActive(true);
        itaplayer2endscene.SetActive(true);
        itadrawendscene.SetActive(true);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer1.SetActive(false);
        spaplayer2.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);
        spaplayer1endscene.SetActive(false);
        spaplayer2endscene.SetActive(false);
        spadrawendscene.SetActive(false);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer1.SetActive(false);
        porplayer2.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);
        porplayer1endscene.SetActive(false);
        porplayer2endscene.SetActive(false);
        pordrawendscene.SetActive(false);

        hangidilaktif = 5;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void spabayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer1.SetActive(false);
        turplayer2.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);
        turplayer1endscene.SetActive(false);
        turplayer2endscene.SetActive(false);
        turdrawendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer1.SetActive(false);
        engplayer2.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);
        engplayer1endscene.SetActive(false);
        engplayer2endscene.SetActive(false);
        engdrawendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer1.SetActive(false);
        fraplayer2.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);
        fraplayer1endscene.SetActive(false);
        fraplayer2endscene.SetActive(false);
        fradrawendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer1.SetActive(false);
        gerplayer2.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);
        gerplayer1endscene.SetActive(false);
        gerplayer2endscene.SetActive(false);
        gerdrawendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer1.SetActive(false);
        rusplayer2.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);
        rusplayer1endscene.SetActive(false);
        rusplayer2endscene.SetActive(false);
        rusdrawendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer1.SetActive(false);
        itaplayer2.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);
        itaplayer1endscene.SetActive(false);
        itaplayer2endscene.SetActive(false);
        itadrawendscene.SetActive(false);

        spalight.SetActive(true);
        spaback.SetActive(true);
        spapause.SetActive(true);
        spareplay.SetActive(true);
        spaplayer1.SetActive(true);
        spaplayer2.SetActive(true);
        spabackendscene.SetActive(true);
        spareplayendscene.SetActive(true);
        spaplayer1endscene.SetActive(true);
        spaplayer2endscene.SetActive(true);
        spadrawendscene.SetActive(true);

        porlight.SetActive(false);
        porback.SetActive(false);
        porpause.SetActive(false);
        porreplay.SetActive(false);
        porplayer1.SetActive(false);
        porplayer2.SetActive(false);
        porbackendscene.SetActive(false);
        porreplayendscene.SetActive(false);
        porplayer1endscene.SetActive(false);
        porplayer2endscene.SetActive(false);
        pordrawendscene.SetActive(false);

        hangidilaktif = 6;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
    public void porbayrak()
    {
        turlight.SetActive(false);
        turback.SetActive(false);
        turpause.SetActive(false);
        turreplay.SetActive(false);
        turplayer1.SetActive(false);
        turplayer2.SetActive(false);
        turbackendscene.SetActive(false);
        turreplayendscene.SetActive(false);
        turplayer1endscene.SetActive(false);
        turplayer2endscene.SetActive(false);
        turdrawendscene.SetActive(false);

        englight.SetActive(false);
        engback.SetActive(false);
        engpause.SetActive(false);
        engreplay.SetActive(false);
        engplayer1.SetActive(false);
        engplayer2.SetActive(false);
        engbackendscene.SetActive(false);
        engreplayendscene.SetActive(false);
        engplayer1endscene.SetActive(false);
        engplayer2endscene.SetActive(false);
        engdrawendscene.SetActive(false);

        fralight.SetActive(false);
        fraback.SetActive(false);
        frapause.SetActive(false);
        frareplay.SetActive(false);
        fraplayer1.SetActive(false);
        fraplayer2.SetActive(false);
        frabackendscene.SetActive(false);
        frareplayendscene.SetActive(false);
        fraplayer1endscene.SetActive(false);
        fraplayer2endscene.SetActive(false);
        fradrawendscene.SetActive(false);

        gerlight.SetActive(false);
        gerback.SetActive(false);
        gerpause.SetActive(false);
        gerreplay.SetActive(false);
        gerplayer1.SetActive(false);
        gerplayer2.SetActive(false);
        gerbackendscene.SetActive(false);
        gerreplayendscene.SetActive(false);
        gerplayer1endscene.SetActive(false);
        gerplayer2endscene.SetActive(false);
        gerdrawendscene.SetActive(false);

        ruslight.SetActive(false);
        rusback.SetActive(false);
        ruspause.SetActive(false);
        rusreplay.SetActive(false);
        rusplayer1.SetActive(false);
        rusplayer2.SetActive(false);
        rusbackendscene.SetActive(false);
        rusreplayendscene.SetActive(false);
        rusplayer1endscene.SetActive(false);
        rusplayer2endscene.SetActive(false);
        rusdrawendscene.SetActive(false);

        italight.SetActive(false);
        itaback.SetActive(false);
        itapause.SetActive(false);
        itareplay.SetActive(false);
        itaplayer1.SetActive(false);
        itaplayer2.SetActive(false);
        itabackendscene.SetActive(false);
        itareplayendscene.SetActive(false);
        itaplayer1endscene.SetActive(false);
        itaplayer2endscene.SetActive(false);
        itadrawendscene.SetActive(false);

        spalight.SetActive(false);
        spaback.SetActive(false);
        spapause.SetActive(false);
        spareplay.SetActive(false);
        spaplayer1.SetActive(false);
        spaplayer2.SetActive(false);
        spabackendscene.SetActive(false);
        spareplayendscene.SetActive(false);
        spaplayer1endscene.SetActive(false);
        spaplayer2endscene.SetActive(false);
        spadrawendscene.SetActive(false);

        porlight.SetActive(true);
        porback.SetActive(true);
        porpause.SetActive(true);
        porreplay.SetActive(true);
        porplayer1.SetActive(true);
        porplayer2.SetActive(true);
        porbackendscene.SetActive(true);
        porreplayendscene.SetActive(true);
        porplayer1endscene.SetActive(true);
        porplayer2endscene.SetActive(true);
        pordrawendscene.SetActive(true);

        hangidilaktif = 7;
        PlayerPrefs.SetInt(nameof(hangidilaktif), hangidilaktif);
    }
}