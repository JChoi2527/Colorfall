using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    // Use this for initialization

    //GameObject myTextgameObject; // gameObject in Hierarchy
    public Text scoreText;
    public int score = Values.score;

    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + Values.score;
    }
}
