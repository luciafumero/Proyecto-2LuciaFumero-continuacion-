using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particulas : MonoBehaviour
{
    public ParticleSystem particlesystema;

    private bool collecting = false;

    void Start()
    {
        particlesystema.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable") && !collecting)
        {
            ActivateParticles();
            collecting = true;
        }
    }

    void ActivateParticles()
    {
        particlesystema.Play();
        Invoke("StopParticles", 1.5f);
    }

    void StopParticles()
    {
        particlesystema.Stop();
        collecting = false;
    }
}
