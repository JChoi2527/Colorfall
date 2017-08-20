using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Combo : MonoBehaviour {

    public Slider comboBar;
    public Button comboButton;

    // Use this for initialization
    void Start () {
        comboBar.maxValue = 1;
        comboBar.minValue = 0;
    }
	
	// Update is called once per frame
	void Update () {
        comboBar.value = Values.combine;

        if (Values.combine >= comboBar.maxValue)
        {
            comboBar.enabled = false;
            comboBar.transform.localScale = new Vector3(0, 0, 0);
            comboButton.enabled = true;
            comboButton.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            comboBar.enabled = true;
            comboBar.transform.localScale = new Vector3(1, 1, 1);
            comboButton.enabled = false;
            comboButton.transform.localScale = new Vector3(0, 0, 0);
        }

        if (Values.isComboing == true)
        {
            if (Values.comboed >= 12)
            {
                Values.isComboing = false;
                Values.combine = 0;
                Values.comboed = 0;
            }
        }
	}

    public void StartCombo()
    {
        Values.spawnSinceCombo = Values.spawned;
        Values.isComboing = true;
    }
}
