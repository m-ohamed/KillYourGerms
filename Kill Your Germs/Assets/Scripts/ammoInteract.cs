﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ammoInteract : MonoBehaviour

{

    public GameObject interactpanel;
    // Use this for initialization
    void Start()
    {
        interactpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (interactpanel.activeSelf)
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (gunShoot.ammo < 100)
                {
                    gunShoot.ammo = 100;
                }
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            interactpanel.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            interactpanel.SetActive(false);
        }
    }
}
