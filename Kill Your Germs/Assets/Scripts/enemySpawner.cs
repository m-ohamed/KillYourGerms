using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player;
    public GameObject pickUp;
    public static bool noPickUp = false;

    private float timer = 5.0f;

	// Use this for initialization
	void Start ()
    {
        float pickUpRandX = Random.Range(-66f, 0f);
        float pickUpRandZ = Random.Range(-66f, 0f);

        GameObject newPickUp = Instantiate(pickUp, new Vector3(pickUpRandX, 1.0f, pickUpRandZ), transform.rotation);
        newPickUp.SetActive(true);
        newPickUp.transform.position = new Vector3(pickUpRandX, 1.0f, pickUpRandZ);
        //print("spawned at x:" + newPickUp.transform.position.x + "and z:" + newPickUp.transform.position.z);
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;

        if (noPickUp)
        {
            spawnPickUp();
            noPickUp = false;
        }

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

            timer = (5.0f - (((int)Time.timeSinceLevelLoad) / 30.0f) <= 1.0f) ? 1.0f : 5.0f - (((int)Time.timeSinceLevelLoad) / 30.0f);
        }
	}

    public void spawnPickUp()
    {
        float pickUpRandX = Random.Range(-66f, 0f);
        float pickUpRandZ = Random.Range(-66f, 0f);

        GameObject newPickUp = Instantiate(pickUp, new Vector3(pickUpRandX, 1.0f, pickUpRandZ), transform.rotation);
        newPickUp.SetActive(true);
        newPickUp.transform.position = new Vector3(pickUpRandX, 1.0f, pickUpRandZ);
    }
}
