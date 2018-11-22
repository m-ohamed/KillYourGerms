using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScript : MonoBehaviour {

    public GameObject ingamepanel;
    public GameObject gameoverpanel;
    public AudioSource ingamemusic;
    public AudioSource menumusic;
    public Text killstxt;
    public Text timertxt;
    public GameObject player;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void endgame()
    {
        ingamemusic.Pause();
        menumusic.Play(0);
        gameoverpanel.SetActive(true);
        ingamepanel.SetActive(false);
        killstxt.text = player.GetComponent<playerController>().killstext.text;
        timertxt.text = player.GetComponent<playerController>().timertext.text+"Seconds";
        Time.timeScale = 0f;
    }
}
