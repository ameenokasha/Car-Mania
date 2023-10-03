using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceSiren : MonoBehaviour
{
    public GameObject blueLight_0, blueLight_1;
    public GameObject redLight_0, redLight_1, redLight_2;
    private float waitTime = 0.3f;
    void Start()
    {
        StartCoroutine(Siren());
    }
    IEnumerator Siren()
    {
        yield return new WaitForSeconds(waitTime);

        redLight_0.SetActive(true);
        redLight_1.SetActive(true);
        redLight_2.SetActive(true);
        blueLight_0.SetActive(false);
        blueLight_1.SetActive(false);

        yield return new WaitForSeconds(waitTime);
        
        redLight_0.SetActive(false);
        redLight_1.SetActive(false);
        redLight_2.SetActive(false);
        blueLight_0.SetActive(true);
        blueLight_1.SetActive(true);

        StartCoroutine(Siren());
    }
}
