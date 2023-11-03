using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugador_mov : MonoBehaviour
{
    float movementspeed;
    Rigidbody rb;
    public Vector3 rotacionfija = new Vector3(0, 90, 0);
    float fuerzasalto;
    float fuerzagravedad;
    public int coinsCollected = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementspeed = 10f;
        fuerzasalto = 25f;
        fuerzagravedad = 30f;
    }

    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal") * Time.deltaTime * movementspeed;
        float verticalinput = Input.GetAxis("Vertical") * Time.deltaTime * movementspeed;
        transform.Translate(horizontalinput, 0, verticalinput);
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * fuerzasalto, ForceMode.Impulse);
        }

        rb.useGravity = true;
        rb.mass = 1.0f;
        rb.AddForce(Vector3.down * rb.mass * fuerzagravedad, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coleccionable"))
        {
            other.gameObject.SetActive(false);
            coinsCollected++;
        }
    }
}
