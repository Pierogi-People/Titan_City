using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speech_Trigger1 : MonoBehaviour
{
    public AudioSource audioSource;
    void OnTriggerEnterSectionOne2D(Collider2D other) 
    {
        if (other.tag == "Player" && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}