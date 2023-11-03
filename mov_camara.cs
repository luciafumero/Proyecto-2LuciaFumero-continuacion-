using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_camara : MonoBehaviour
{
    public float speed;
    private Transform objetivo;

    void Start()
    {
        objetivo = GameObject.FindGameObjectWithTag("jugador").GetComponent<Transform>(); 
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position + new Vector3(0f, 4.59f, -8.2f), speed * Time.deltaTime);
    }
}
