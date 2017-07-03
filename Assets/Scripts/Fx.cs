using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fx : MonoBehaviour
{

    public AudioClip move;
    public AudioClip combine;
    public AudioClip score;
    public AudioClip switcharoo;
    public AudioClip gameoverboo;
    public AudioSource audio;


    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Update()
    {
    }

    public void Move()
    {
         if (PlayerPrefs.GetInt("Volume") == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(move, 1.0f);
        }
    }

    public void Combine()
    {
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(combine, 1.0f);
        }
    }

    public void Score()
    {
        if (PlayerPrefs.GetInt("Volume") == 1 && Values.gameIsOver == false)
        {
            GetComponent<AudioSource>().PlayOneShot(score, 1.0f);
        }
    }

    public void Switch()
    {
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(switcharoo, 1.0f);
        }
    }

    public void gameOver()
    {
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(gameoverboo, 0.8f);
        }
    }
}
