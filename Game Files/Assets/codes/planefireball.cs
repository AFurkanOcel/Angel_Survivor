using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject fireball;
    public GameObject fireball2;
    public GameObject fireball3;
    public GameObject fireball4;
    public GameObject fireball5;
    public GameObject fireball6;
    public GameObject fireball7;
    public GameObject fireball8;
    public GameObject fireball9;
    public GameObject fireball10;
    public GameObject fireball11;
    public GameObject fireball12;
    public GameObject fireball13;
    public GameObject fireball14;

    public GameObject particalsystemfires;
    public GameObject particalsystemfires2;

    public AudioSource fall;

    public void Start()
    {
        Invoke("callfireball4", 30f);
        Invoke("callfireball5", 60f);
        Invoke("callfireball6", 90f);
        Invoke("callfireball7", 120f);
        Invoke("callfireball8", 150f);
        Invoke("callfireball9", 180f);
        Invoke("callfireball10", 240f);
        Invoke("callfireball11", 360f);
        Invoke("callfireball12", 420f);
        Invoke("callfireball13", 480f);
        Invoke("callfireball14", 540f);
        Invoke("particalsystems", 296);
        Invoke("particalsystems2", 595f);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "fireball")
        {
            fireball.SetActive(false);
            Invoke("callfireball", 0f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball2")
        {
            fireball2.SetActive(false);
            Invoke("callfireball2", 0.75f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball3")
        {
            fireball3.SetActive(false);
            Invoke("callfireball3", 1.05f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball4")
        {
            fireball4.SetActive(false);
            Invoke("callfireball4", 0.30f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball5")
        {
            fireball5.SetActive(false);
            Invoke("callfireball5", 0.90f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball6")
        {
            fireball6.SetActive(false);
            Invoke("callfireball6", 1.80f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball7")
        {
            fireball7.SetActive(false);
            Invoke("callfireball7", 0.45f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball8")
        {
            fireball8.SetActive(false);
            Invoke("callfireball8", 1.20f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball9")
        {
            fireball9.SetActive(false);
            Invoke("callfireball9", 0.15f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball10")
        {
            fireball10.SetActive(false);
            Invoke("callfireball10", 0.60f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball11")
        {
            fireball11.SetActive(false);
            Invoke("callfireball11", 1.50f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball12")
        {
            fireball12.SetActive(false);
            Invoke("callfireball12", 1.35f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball13")
        {
            fireball13.SetActive(false);
            Invoke("callfireball13", 1.65f);
            fall.Play();
        }
        if (collision.collider.tag == "fireball14")
        {
            fireball14.SetActive(false);
            Invoke("callfireball14", 2f);
            fall.Play();
        }
    }

    public void callfireball()
    {
        fireball.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball2()
    {
        fireball2.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball2.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball3()
    {
        fireball3.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball3.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball4()
    {
        fireball4.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball4.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball5()
    {
        fireball5.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball5.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball6()
    {
        fireball6.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball6.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball7()
    {
        fireball7.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball7.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball8()
    {
        fireball8.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball8.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball9()
    {
        fireball9.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball9.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball10()
    {
        fireball10.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball10.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball11()
    {
        fireball11.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball11.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball12()
    {
        fireball12.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball12.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball13()
    {
        fireball13.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball13.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void callfireball14()
    {
        fireball14.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball14.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
    }
    public void particalsystems()
    {
        particalsystemfires.SetActive(true);
    }
    public void particalsystems2()
    {
        particalsystemfires2.SetActive(true);
    }
}
