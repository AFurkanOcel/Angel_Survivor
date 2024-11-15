using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public int totaldeathscount;

    public TextMeshProUGUI timetext;
    public TextMeshProUGUI timetextforendscene;
    public TextMeshProUGUI recordtimetextforendscene;
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
    public GameObject buttonroll;

    public AudioSource death;
    public AudioSource roll;
    public GameObject gamemusic;

    public bool angelisdeath;

    [SerializeField] private GameObject angel;
    [SerializeField] private Rigidbody angelrigidbody;
    [SerializeField] private Transform angeltransform;
    [SerializeField] private FloatingJoystick floatingjoystick;
    [SerializeField] private float movespeed;
    [SerializeField] private Animator angelanimator;

    public GameObject endscene;

    private float horizontal;
    private float vertical;

    public void Start()
    {
        Time.timeScale = 1f;

        totaldeathscount = PlayerPrefs.GetInt("totaldeaths");
    }

    private void Update()
    {
        movementinputs();

        if (angelisdeath == true)
        {
            gamemusic.SetActive(false);

            angelanimator.SetTrigger("death");

            Invoke("timepaused", 2f);

            PlayerPrefs.SetInt("totaldeaths", totaldeathscount + 1);
        }
        else
        {
            time += Time.deltaTime;
            timetext.text = "" + (int)time;
            timetextforendscene.text = "" + (int)time;

            if (time > PlayerPrefs.GetInt("hightime"))
            {
                recordtimetextforendscene.text = "" + (int)time;
                PlayerPrefs.SetInt("hightime", (int)time);
            }

;
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
            if(angeltransform.position.x > 9.5 || angeltransform.position.x < -9.5 || angeltransform.position.z > 3.6)
            {
                if(time > 300)
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
        angelrigidbody.velocity = new Vector3(horizontal,angelrigidbody.velocity.y,vertical)*movespeed*Time.fixedDeltaTime;
    }

    private void movementinputs()
    {
        horizontal = floatingjoystick.Horizontal;
        vertical = floatingjoystick.Vertical;
    }

    private void rotation()
    {
        if(horizontal !=0 || vertical !=0)
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
            gamemusic.SetActive(false);

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

            death.Play();
            angelisdeath = true;
        }
    }

    public void timepaused()
    {
        Time.timeScale = 0f;
        endscene.SetActive(true);

        buttonback.SetActive(false);
        buttonpause.SetActive(false);
        buttonreplay.SetActive(false);
        buttonlight.SetActive(false);
        buttonroll.SetActive(false);
        floatingjoystick.enabled = false;
    }
}
