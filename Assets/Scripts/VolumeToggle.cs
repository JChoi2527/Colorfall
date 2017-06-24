using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeToggle : MonoBehaviour {

    public Toggle volume;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        volume = GetComponent<Toggle>();
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
            volume.isOn = true;
        }
        else
        {
            volume.isOn = false;
        }
    }
}
