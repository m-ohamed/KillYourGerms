using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class pauseMenu : MonoBehaviour {
    public GameObject ingamepanel;
    public GameObject pausepanel;
    public AudioSource ingamemusic;
    public AudioSource menumusic;
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
        ingamemusic.Play(0);
        menumusic.Pause();
    }
    public void Pause()
    {
        print("pause");
        ingamepanel.SetActive(false);
        pausepanel.SetActive(true);
        Time.timeScale = 0f;
        ispaused = true;
        menumusic.Play(0);
        ingamemusic.Pause();
    }

    public void Quittomainmenu()
    {
        Resume();
        menumusic.Pause();
        ingamemusic.Pause();
        SceneManager.LoadScene("mainMenu");
    }
}
