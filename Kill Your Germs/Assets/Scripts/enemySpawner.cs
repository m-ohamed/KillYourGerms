using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;

    private float timer = 5.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;


        if (timer <= 0.0f)
        {
            float randX = Random.Range(-30.0f, 30.0f);
            float randZ = Random.Range(-30.0f, 30.0f);

          
            if(Mathf.Abs(randX - player.transform.position.x) <= 4.0f)
            {
                if (randX < player.transform.position.x)
                    randX -= 5.0f;
                else
                    randX += 5.0f;
            }
        
            if(Mathf.Abs(randZ - player.transform.position.z) <= 4.0f)
            {
                if(randZ < player.transform.position.z)
                    randZ -= 5.0f;
                else
                    randZ += 5.0f;
            }
        
            

            GameObject newEnemy = Instantiate(enemy, new Vector3(randX, 1.0f, randZ), transform.rotation);
            newEnemy.SetActive(true);
            timer = 5.0f;
        }
	}
}
