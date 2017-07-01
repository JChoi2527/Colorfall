using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{

    // Use this for initialization

    //GameObject myTextgameObject; // gameObject in Hierarchy
    public Text scoreText;

    void Start()
    {
        //GetComponent<Text>() = Values.score;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Best: " + PlayerPrefs.GetInt("High Score");
    }
}
