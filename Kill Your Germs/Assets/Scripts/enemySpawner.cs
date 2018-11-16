using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    private float timer = 5.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;

        float randX = Random.Range(-30.0f, 30.0f);
        float randZ = Random.Range(-30.0f, 30.0f);

        if (timer <= 0.0f)
        {
            GameObject newEnemy = Instantiate(enemy, new Vector3(randX, 1.0f, randZ), transform.rotation);
            newEnemy.SetActive(true);
            timer = 5.0f;
        }
	}
}
