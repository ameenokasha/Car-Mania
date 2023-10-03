using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightView : MonoBehaviour
{
    public Material mySkyMaterial;
    public Material myDefaultSkyMaterial;

    private void Start()
    {
        mySkyMaterial = GetComponent<Renderer>().material;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            RenderSettings.ambientIntensity = 0.0f;
            RenderSettings.skybox = mySkyMaterial;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            RenderSettings.ambientIntensity = 1.0f;
            RenderSettings.skybox = myDefaultSkyMaterial;
        }

    }
}
