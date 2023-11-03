using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido_moneda : MonoBehaviour
{
    public AudioClip coleccionableSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable")) 
        {
            PlayColeccionableSound();
        }
    }

    private void PlayColeccionableSound()
    {
        if (coleccionableSound != null)
        {
            audioSource.PlayOneShot(coleccionableSound);
        }
    }
}

