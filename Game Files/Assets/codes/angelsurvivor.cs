using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class angelsurvivor : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("Coutdown");
    }

    private IEnumerator Coutdown()
    {
        yield return new WaitForSeconds(4.9f);
        SceneManager.LoadScene(1);
    }
}
