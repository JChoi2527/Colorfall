using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeToggle : MonoBehaviour {

    public Toggle volume_StartMenu;
    public Toggle volume_MainMenu;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("Volume") == 1)
        {
			volume_StartMenu.isOn = true;
			volume_MainMenu.isOn = true;
        }
        else
        {
			volume_StartMenu.isOn = false;
			volume_MainMenu.isOn = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
    }

    public void updateStatus()
    {

    }

	public void ChangeVolume_StartMenu(bool newValue)
	{
		//volume = newValue;
		if (volume_StartMenu.isOn == true)
		{
			PlayerPrefs.SetInt("Volume", 1);
			volume_MainMenu.isOn = true;
		}
		else
		{
			PlayerPrefs.SetInt("Volume", 0);
			volume_MainMenu.isOn = false;
		}
	}

	public void ChangeVolume_MainMenu(bool newValue)
	{
		//volume = newValue;
		if (volume_MainMenu.isOn == true)
		{
			PlayerPrefs.SetInt("Volume", 1);
			volume_StartMenu.isOn = true;
		}
		else
		{
			PlayerPrefs.SetInt("Volume", 0);
			volume_StartMenu.isOn = false;
		}
	}
}
