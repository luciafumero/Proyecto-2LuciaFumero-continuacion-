using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class caida : MonoBehaviour
{
    float tiempoDePartida = 0.0f;
    bool estaJugando = true;
    [SerializeField]
    GameObject mensajefall;

    private void Update()
    {
        if (estaJugando)
        {
            tiempoDePartida = Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fall"))
        {
            Time.timeScale = 0;
            estaJugando = false;
            mensajefall.SetActive(true);
        }
    }
}

