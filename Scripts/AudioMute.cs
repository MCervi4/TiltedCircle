using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioMute : MonoBehaviour
{

    public AudioSource audioSource;
    public TMP_Text text;

    public void Switch()
    {
        if (audioSource.mute) //muted
        {
            audioSource.mute = false;
            text.text = "audio on";
        }
        else
        {
            audioSource.mute = true;
            text.text = "audio off";
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
