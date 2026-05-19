using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class babagame : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Coutdown");
    }

    private IEnumerator Coutdown()
    {
        yield return new WaitForSeconds(7.4f);
        SceneManager.LoadScene(8);
    }
}
