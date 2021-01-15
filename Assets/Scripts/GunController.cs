﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{

    public bool isFiring;
    public BulletController bullet;
    public float bulletSpeed;
    public float fireRate;
    public float shotCounter;
    public Transform firePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > shotCounter)
        {
                if (Input.GetMouseButtonDown(0))
                {
                    BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                    newBullet.speed = bulletSpeed;
                    shotCounter = Time.time + fireRate;
                }
        }
    }
}
