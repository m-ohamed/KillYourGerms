using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {
    public GameObject ingamepanel;
    public GameObject pausepanel;
    public static bool ispaused = false;
    // Use this for initialization
    void Start () {
        ispaused = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        print("continue");
        pausepanel.SetActive(false);
        ingamepanel.SetActive(true);
        Time.timeScale = 1f;
        ispaused = false;
    }
    public void Pause()
    {
        print("pause");
        ingamepanel.SetActive(false);
        pausepanel.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
    }

    public void Quittomainmenu()
    {
        Resume();
        SceneManager.LoadScene("mainMenu");
    }
}
