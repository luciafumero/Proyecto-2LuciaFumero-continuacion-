using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambio_camara : MonoBehaviour
{
    public Camera primeraCamara;
    public Camera segundaCamara;

    private bool primeraCamaraActiva = true;

    private void Start()
    {
        primeraCamara.enabled = true;
        segundaCamara.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            CambiarCamara();
        }
    }

    private void CambiarCamara()
    {
        primeraCamaraActiva = !primeraCamaraActiva;
        primeraCamara.enabled = primeraCamaraActiva;
        segundaCamara.enabled = !primeraCamaraActiva;
    }
}
