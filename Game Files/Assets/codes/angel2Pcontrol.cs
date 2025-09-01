using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class angel2Pcontrol : MonoBehaviour
{
    public GameObject otherangel;
    public BoxCollider otherangelboxcollider;

    public TextMeshProUGUI timetext;
    float time = 0;

    public GameObject fireball1;
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

    public GameObject buttonback;
    public GameObject buttonpause;
    public GameObject buttonreplay;
    public GameObject buttonlight;
    public GameObject buttonrollP1;
    public GameObject buttonrollP2;
    public BoxCollider angel1boxcollider; // meleklerden biri öldüðünde kýrmýzý rollbutton u açmak için lazým
    public BoxCollider angel2boxcollider; // meleklerden biri öldüðünde mavi rollbutton u açmak için lazým
    public GameObject floatingjoystickP1; // meleklerden biri öldüðünde soldaki joystick i tüm alana yaymak için lazým
    public GameObject floatingjoystickP2; // meleklerden biri öldüðünde saðdaki joystick i tüm alana yaymak için lazým


    public AudioSource death;
    public AudioSource roll;
    public GameObject gamemusic;

    public bool angelisdeath;

    [SerializeField] private GameObject angel;
    [SerializeField] private Rigidbody angelrigidbody;
    [SerializeField] private BoxCollider angelboxcollider;
    [SerializeField] private Transform angeltransform;
    [SerializeField] private FloatingJoystick floatingjoystick;
    [SerializeField] private float movespeed;
    [SerializeField] private Animator angelanimator;

    public GameObject endscene;
    public GameObject endsceneplayer1win;
    public GameObject endsceneplayer2win;
    public GameObject endscenedraw;
    public int whoiswin = 0; // buradaki sayýya göre endscenedeki kimin kazandýðý veya berabere bitti yazýsýný çýkartýcam. 0 ise berabere, 1 ise player1 kazandý, 2 ise player2 kazandý.
    // bu arada whoiswindeki mantýk nede yapsam çalýþmadý fakat angel2 nin içersine endsceneplayer1win ile endsceneplayer2win i ters atýnca çalýþtý o nedenle sorgulamadan devam ettim :)
    // !!! berabere gözükmüyor ona bak.

    private float horizontal;
    private float vertical;

    public void Start()
    {
        Time.timeScale = 1f;
    }

    private void Update()
    {
        movementinputs();

        if (angelisdeath == true)
        {
            angelanimator.SetTrigger("death");
            angelboxcollider.enabled = false;

            if (otherangelboxcollider.enabled == false)
            {
                gamemusic.SetActive(false);
            }
        }
        else
        {
            time += Time.deltaTime;
            timetext.text = "" + (int)time;

            if (angelrigidbody.velocity.x != 0 || angelrigidbody.velocity.z != 0)
            {
                angelanimator.SetTrigger("run");
            }
            else
            {
                angelanimator.SetTrigger("idle");
            }
        }
    }

    private void FixedUpdate()
    {
        if (angelisdeath == true)
        {
            angelrigidbody.velocity = new Vector3(0, 0, 0);
        }
        else
        {
            if (angeltransform.position.x > 9.5 || angeltransform.position.x < -9.5 || angeltransform.position.z > 3.6 || angeltransform.position.z < -3.6)
            {
                if (time > 100)
                {
                    death.Play();
                    angelisdeath = true;
                }
            }
            if (angeltransform.position.x < 1 && angeltransform.position.x > -1)
            {
                if (time > 200)
                {
                    death.Play();
                    angelisdeath = true;
                }
            }
            movement();
            rotation();
        }
    }

    private void movement()
    {
        angelrigidbody.velocity = new Vector3(horizontal, angelrigidbody.velocity.y, vertical) * movespeed * Time.fixedDeltaTime;
    }

    private void movementinputs()
    {
        horizontal = floatingjoystick.Horizontal;
        vertical = floatingjoystick.Vertical;
    }

    private void rotation()
    {
        if (horizontal != 0 || vertical != 0)
        {
            angeltransform.rotation = Quaternion.LookRotation(angelrigidbody.velocity);
        }
    }

    public void rollbutton()
    {
        angelanimator.SetTrigger("roll");
        roll.Play();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "fireball" || collision.collider.tag == "fireball2" || collision.collider.tag == "fireball3" || collision.collider.tag == "fireball4" || collision.collider.tag == "fireball5" || collision.collider.tag == "fireball6" || collision.collider.tag == "fireball7" || collision.collider.tag == "fireball8" || collision.collider.tag == "fireball9" || collision.collider.tag == "fireball10" || collision.collider.tag == "fireball11" || collision.collider.tag == "fireball12" || collision.collider.tag == "fireball13" || collision.collider.tag == "fireball14")
        {
            if (angel1boxcollider == true && angelisdeath == false)
            {
                whoiswin = 1;
            }
            else if (angel2boxcollider == true && angelisdeath == false)
            {
                whoiswin = 2;
            }

            death.Play();
            angelisdeath = true;

            Invoke("angelsaredeath", 0.1f); // bu þekilde 0.1 sn sonra çaðýrýyorum direkt buraya yazmak yerine metodlarý çünkü o þekilde yapýnca iki melekte ayný anda öldüðünde meteor yaðmaya devam ediyor.

                if (collision.collider.tag == "fireball")
                {
                    Invoke("callfireball", 0f);
                }
                if (collision.collider.tag == "fireball2")
                {
                    Invoke("callfireball2", 0f);
                }
                if (collision.collider.tag == "fireball3")
                {
                    Invoke("callfireball3", 0f);
                }
                if (collision.collider.tag == "fireball4")
                {
                    Invoke("callfireball4", 0f);
                }
                if (collision.collider.tag == "fireball5")
                {
                    Invoke("callfireball5", 0f);
                }
                if (collision.collider.tag == "fireball6")
                {
                    Invoke("callfireball6", 0f);
                }
                if (collision.collider.tag == "fireball7")
                {
                    Invoke("callfireball7", 0f);
                }
                if (collision.collider.tag == "fireball8")
                {
                    Invoke("callfireball8", 0f);
                }
                if (collision.collider.tag == "fireball9")
                {
                    Invoke("callfireball9", 0f);
                }
                if (collision.collider.tag == "fireball10")
                {
                    Invoke("callfireball10", 0f);
                }
                if (collision.collider.tag == "fireball11")
                {
                    Invoke("callfireball11", 0f);
                }
                if (collision.collider.tag == "fireball12")
                {
                    Invoke("callfireball12", 0f);
                }
                if (collision.collider.tag == "fireball13")
                {
                    Invoke("callfireball13", 0f);
                }
                if (collision.collider.tag == "fireball14")
                {
                    Invoke("callfireball14", 0f);
                }
        }
    }

    public void callfireball()
    {
        fireball1.SetActive(true);
        float rastgelesoldansaga = Random.Range(-10.40f, 10.40f);
        float rastgeleyukaridanasagiya = Random.Range(-4.45f, 4.45f);
        fireball1.transform.position = new Vector3(rastgelesoldansaga, 11, rastgeleyukaridanasagiya);
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

    public void angelsaredeath()
    {
        if (otherangelboxcollider.enabled == false)
        {
            Invoke("timepaused", 2f);
        }
        else
        {
            if (angel1boxcollider.enabled == false)
            {
                buttonrollP2.SetActive(true);
                floatingjoystickP1.SetActive(false);
                floatingjoystickP2.transform.position = new Vector3(-5000,floatingjoystickP2.transform.position.y, floatingjoystickP2.transform.position.z);
            }
            else if (angel2boxcollider.enabled == false)
            {
                floatingjoystickP2.SetActive(false);
                buttonrollP1.SetActive(true);
            }
        }
    }

    public void timepaused()
    {
        Time.timeScale = 0f;

        if(whoiswin == 1)
        {
            endsceneplayer1win.SetActive(true);
        }
        else if (whoiswin == 2)
        {
            endsceneplayer2win.SetActive(true);
        }
        if(endsceneplayer1win.activeSelf == true && endsceneplayer2win.activeSelf == true)
        {
            endsceneplayer1win.SetActive(false);
            endsceneplayer2win.SetActive(false);
            endscenedraw.SetActive(true);

        }


        endscene.SetActive(true);
        buttonback.SetActive(false);
        buttonpause.SetActive(false);
        buttonreplay.SetActive(false);
        buttonlight.SetActive(false);
        buttonrollP1.SetActive(false);
        buttonrollP2.SetActive(false);
        floatingjoystickP1.SetActive(false);
        floatingjoystickP2.SetActive(false);

        fireball1.SetActive(false);
        fireball2.SetActive(false);
        fireball3.SetActive(false);
        fireball4.SetActive(false);
        fireball5.SetActive(false);
        fireball6.SetActive(false);
        fireball7.SetActive(false);
        fireball8.SetActive(false);
        fireball9.SetActive(false);
        fireball10.SetActive(false);
        fireball11.SetActive(false);
        fireball12.SetActive(false);
        fireball13.SetActive(false);
        fireball14.SetActive(false);
    }
}
