using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttoncode : MonoBehaviour
{
    bool gamepaused = false;
    bool lighton = true;

    public string discordurl;
    public AudioSource buttonclick;

    public Animator menuangelanimator;
    public Animator menudemonanimator;
    public Animator menu2Pangel1animator;
    public Animator menu2Pangel2animator;

    public void playbutton()
    {
        buttonclick.Play();
        Invoke("play2button", 0.1f);
    }
    public void statisticsbutton()
    {
        buttonclick.Play();
        Invoke("statistics2button", 0.1f);
    }
    public void settingsbutton()
    {
        buttonclick.Play();
        Invoke("settings2button", 0.1f);
    }
    public void exitbutton()
    {
        buttonclick.Play();
        Invoke("exit2button", 0.1f);
    }
    public void frombutton()
    {
        buttonclick.Play();
        Invoke("from2button", 0.1f);
    }
    public void oneplayerbutton()
    {
        buttonclick.Play();
        Invoke("oneplayer2button", 0.1f);

        PlayerPrefs.SetInt("totalgame", PlayerPrefs.GetInt("totalgame")+1);
    }
    public void twoplayerbutton()
    {
        buttonclick.Play();
        Invoke("twoplayer2button", 0.1f);
    }
    public void backbutton()
    {
        buttonclick.Play();
        SceneManager.LoadScene(1);
    }
    public void lightbutton()
    {
        buttonclick.Play();
        if (lighton == true)
        {
            GameObject.FindWithTag("light").GetComponent<Light>().enabled = false;
            lighton = false;
        }
        else
        {
            GameObject.FindWithTag("light").GetComponent<Light>().enabled = true;
            lighton = true;
        }
    }
    public void pausebutton()
    {
        buttonclick.Play();
        if (gamepaused == false)
        {
            Time.timeScale = 0f;
            gamepaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            gamepaused = false;
        }
    }
    public void oneplayerreplaybutton()
    {
        buttonclick.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        PlayerPrefs.SetInt("totalgame", PlayerPrefs.GetInt("totalgame") + 1);
    }
    public void twoplayerreplaybutton()
    {
        buttonclick.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void discordbutton()
    {
        buttonclick.Play();
        Invoke("discord2button", 0.1f);
    }
    public void menuangelbutton()
    {
        menuangelanimator.SetBool("roll",true);
        Invoke("menuangel2button", 0.3f);
    }
    public void menu2Pangel1button()
    {
        menu2Pangel1animator.SetBool("roll", true);
        Invoke("menuangel2button", 0.3f);
    }
    public void menu2Pangel2button()
    {
        menu2Pangel2animator.SetBool("roll", true);
        Invoke("menuangel2button", 0.3f);
    }
    public void menuangel2button()
    {
        menuangelanimator.SetBool("roll", false);
        menu2Pangel1animator.SetBool("roll", false);
        menu2Pangel2animator.SetBool("roll", false);
    }
    public void menudemonbutton()
    {
        menudemonanimator.SetBool("roll", true);
        Invoke("menudemon2button", 0.3f);
    }
    public void menudemon2button()
    {
        menudemonanimator.SetBool("roll", false);
    }

    //bu kýsmý yazarak kodu uzatmamýn sebebi, bu þekide 0.1 sn sonra çaðýrmayýnca buton týklama sesi düzgün duyulmuyor
    public void play2button()
    {
        SceneManager.LoadScene(2);
    }
    public void statistics2button()
    {
        SceneManager.LoadScene(5);
    }
    public void settings2button()
    {
        SceneManager.LoadScene(6);
    }
    public void exit2button()
    {
        Application.Quit();
    }
    public void from2button()
    {
        SceneManager.LoadScene(7);
    }
    public void oneplayer2button()
    {
        SceneManager.LoadScene(3);
    }
    public void twoplayer2button()
    {
        SceneManager.LoadScene(4);
    }
    public void discord2button()
    {
        Application.OpenURL(discordurl);
    }
}
