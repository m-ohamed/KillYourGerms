using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f;
    public GameObject player;
    public float speed = 0.01f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, player.transform.position.y + 1.0f, player.transform.position.z), speed * Time.deltaTime);
        //Vector3.MoveTowards()
	}

    public void Damage(float damage)
    {
        health = health - damage;

        if(health <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
