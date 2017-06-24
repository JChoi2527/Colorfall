using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fx : MonoBehaviour
{

    public AudioClip move;
    public AudioClip combine;
    public AudioClip score;
    public AudioSource audio;
    public static bool volume;


    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Update()
    {
        Debug.Log(volume);
    }

    public void Move()
    {
         if (PlayerPrefs.GetInt("Volume") == 1)
        {
            audio.PlayOneShot(move, 1.0f);
        }
    }

    public void Combine()
    {
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            audio.PlayOneShot(combine, 1.0f);
        }
    }

    public void Score()
    {
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            audio.PlayOneShot(score, 1.0f);
        }
    }

    public void ChangeVolume(bool newValue)
    {
        //volume = newValue;
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            PlayerPrefs.SetInt("Volume", 0);
            volume = false;
        }
        else
        {
            PlayerPrefs.SetInt("Volume", 1);
            volume = true;
        }
    }
}