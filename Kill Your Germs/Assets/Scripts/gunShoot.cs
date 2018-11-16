﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunShoot : MonoBehaviour
{
    public float damage = 5.0f;
    public float range = 100.0f;

    public Camera mainCamera;

    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetButtonDown("Fire1"))
        {
            RaycastHit bullet;
            if(Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out bullet))
            {
                Enemy enemy = bullet.transform.GetComponent<Enemy>();

                if(enemy != null)
                {
                    enemy.Damage(20.0f);
                }
            }
        }
	}
}