using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody myRb;
    public float moveSpeed;

    public EnemyHealthManager enemyHealthManager;
    public PlayerController thePlayer;
    public GameObject jerkyRack;

    void Start()
    {
        myRb = GetComponent<Rigidbody>();
        thePlayer = FindObjectOfType<PlayerController>();
        enemyHealthManager = GetComponent<EnemyHealthManager>();
    }

    private void FixedUpdate()
    {
        myRb.velocity = (transform.forward * moveSpeed);
    }

    void Update()
    {
        transform.LookAt(jerkyRack.transform.position);
        if(enemyHealthManager.currentHealth < enemyHealthManager.maxHealth)
        {
            transform.LookAt(thePlayer.transform.position);
        }
    }
}
