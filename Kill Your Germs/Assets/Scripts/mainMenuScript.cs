using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenuScript : MonoBehaviour
{

	public void startGame()
    {
        SceneManager.LoadScene("kitchenScene");
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
