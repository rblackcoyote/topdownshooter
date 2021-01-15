using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody myRb;
    public float moveSpeed;

    public PlayerController thePlayer;
    public GameObject jerkyRack;

    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
    }

    private void FixedUpdate()
    {
        myRb.velocity = (transform.forward * moveSpeed);
    }

    void Update()
    {
        transform.LookAt(jerkyRack.transform.position);
        if(EnemyHealthManager.currentHealth < EnemyHealthManager.maxHealth)
        {
            transform.LookAt(thePlayer.transform.position);
        }
    }
}
