using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class muteScript : MonoBehaviour
{
    public AudioMixer audio;
    private bool isMute = false;

	public void muteSound()
    {
        if(isMute)
        {
            audio.SetFloat("mainVolume", 0);
            isMute = false;
        }
        else
        {
            audio.SetFloat("mainVolume", -80);
            isMute = true;
        }
        
    }
}
