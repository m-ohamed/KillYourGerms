using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerKitchenControl : MonoBehaviour

{

    public float speed = 5.0f;
    private float mouseSen = 2.0f;
    private Rigidbody rb;
    Animator anim;
    public Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, 0.1f, this.gameObject.transform.position.z);
        if (x != 0f || z != 0f)
        {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetFloat("speed", 2.0f);
        }
        else
        {
            anim.SetFloat("speed", 0.0f);
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        Vector3 movX = transform.right * movement.x;
        Vector3 movZ = transform.forward * movement.z;

        //Vector3 finalMov = movement.normalized * speed;
        Vector3 finalMov = (movX + movZ) * speed;

        rb.MovePosition(rb.position + (finalMov * Time.deltaTime));

        Vector3 rotY = new Vector3(0.0f, Input.GetAxis("Mouse X"), 0.0f) * mouseSen;
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotY));

        Vector3 rotX = new Vector3(Input.GetAxis("Mouse Y"), 0.0f, 0.0f) * mouseSen;
        mainCamera.transform.Rotate(-1 * rotX);


    }
}

