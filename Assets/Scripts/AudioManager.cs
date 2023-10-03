using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource aud;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            aud.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            aud.Stop();
    }
}
