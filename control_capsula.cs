using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_capsula : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    private bool isInsideCapsule = false;
    private Vector3 originalPlayerPosition;
    private bool isKinematic = false;
    private Rigidbody enemyRigidbody;
    private Vector3 originalEnemyVelocity;
    private int collectiblesCollected = 0;

    private void Start()
    {
        originalPlayerPosition = player.transform.position;
        enemyRigidbody = enemy.GetComponent<Rigidbody>();
        originalEnemyVelocity = enemyRigidbody.velocity;
    }

    private void Update()
    {
        if (isInsideCapsule)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ExitCapsule();
            }
            else
            {
                float moveSpeed = 10f;
                float horizontalInput = Input.GetAxis("Horizontal");
                float verticalInput = Input.GetAxis("Vertical");

                Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
                player.GetComponent<Rigidbody>().velocity = moveDirection * moveSpeed;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("jugador"))
        {
            if (collectiblesCollected >= 3)
            {
                isInsideCapsule = true;
                isKinematic = player.GetComponent<Rigidbody>().isKinematic;
                player.GetComponent<Rigidbody>().isKinematic = true;
                originalPlayerPosition = player.transform.position;
                enemyRigidbody.velocity = Vector3.zero;
            }
        }

        if (other.CompareTag("Coleccionable"))
        {
            collectiblesCollected++;
        }
    }

    private void ExitCapsule()
    {
        isInsideCapsule = false;
        player.GetComponent<Rigidbody>().isKinematic = isKinematic;
        player.transform.position = originalPlayerPosition;
        enemyRigidbody.velocity = originalEnemyVelocity;
    }
}
