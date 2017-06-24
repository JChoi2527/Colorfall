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
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            volume = true;
        }
        else
        {
            volume = false;
        }
    }

    // Update is called once per frame
    public void Update()
    {
    }

    public void Move()
    {
         if (volume == true && PlayerPrefs.GetInt("Volume") == 1)
        {
            audio.PlayOneShot(move, 1.0f);
        }
    }

    public void Combine()
    {
        if (volume == true && PlayerPrefs.GetInt("Volume") == 1)
        {
            audio.PlayOneShot(combine, 1.0f);
        }
    }

    public void Score()
    {
        if (volume == true && PlayerPrefs.GetInt("Volume") == 1)
        {
            audio.PlayOneShot(score, 1.0f);
        }
    }

    public void ChangeVolume(bool newValue)
    {
        //volume = newValue;
        if (volume == true)
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