using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class you_win : MonoBehaviour
{
    float tiempoDePartida = 0.0f;
    bool estaJugando = true;
    [SerializeField]
    GameObject mensajeWin;
    int moneda = 0;

    private void Update()
    {
        tiempoDePartida = tiempoDePartida + Time.deltaTime;
        if (estaJugando)
        {
            tiempoDePartida = Time.deltaTime;
            if(moneda >= 5)
            {
                mensajeWin.SetActive(true);
                Time.timeScale = 0;
                estaJugando = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            moneda++;
        }
    }
}
