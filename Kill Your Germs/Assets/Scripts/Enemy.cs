using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float health = 100f;
    public GameObject player;
    public float speed = 0.01f;
    public Image healthbar;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(player.transform);

        transform.position += transform.forward * speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, 1.0f, transform.position.z);
        //transform.position.Set(transform.position.x, 2.0f, transform.position.z);

        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1.0f, player.transform.position.z), speed * Time.deltaTime);
        //Vector3.MoveTowards()
    }

    public void Damage(float damage)
    {
        health = health - damage;
        healthbar.fillAmount = health / 100f;
        if(health <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
