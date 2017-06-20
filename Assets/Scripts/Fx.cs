using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fx : MonoBehaviour {

    public AudioClip move;
    public AudioClip combine;
    public AudioClip score;
    AudioSource audio;
    public bool volume;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	public void Move() {
        if (audio == true)
        {
            audio.PlayOneShot(move, 1.0f);
        }
    }

    public void Combine ()
    {
        if (audio == true)
        {
            audio.PlayOneShot(combine, 1.0f);
        }
    }

    public void Score()
    {
        if (audio == true)
        {
        audio.PlayOneShot(score, 1.0f);
        }
    }
}
