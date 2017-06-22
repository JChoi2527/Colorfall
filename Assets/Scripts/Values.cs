using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Values : MonoBehaviour {

    public static float fallingSpeed = 0f;
    public static float fallingSpeedRef = 2f;
    public static float spawnTime = 0f;
    public static float slidingSpeed = .2f;
    //public static float width = Screen.width;
    //public static float height = Screen.height;
    public static Camera cam;
	public static float height = 16f;
	public static float width = 10f;
	public static float border1 = width / 3;
	public static float border2 = (width / 3) * 2;
    public static float[] spawn;
	public static int score = 0;
    public static int spawned = 0;
    public static int scanned = 0;
    public static bool gameIsOver = false;
    public static bool DestroyAll = false;
    public static bool startGame = true;
    public static int highScore;
    public static bool newHighScore;
    public static bool backMenu;


    // Use this for initialization
    void Start () {
        cam = Camera.main;
        spawn = new float[3];
        spawn[0] = width / 6;
        spawn[1] = width / 2;
        spawn[2] = (width * 5) / 6;
        //Time.timeScale = 1;
        highScore = PlayerPrefs.GetInt("High Score");
    }

	// Update is called once per frame
	void Update () {
        Debug.Log(spawned);
    }

	public static void addOne()
	{
        score++;
	}

    public static void stopBlock()
    {
        fallingSpeedRef = fallingSpeed;
        fallingSpeed = 0;
    }

    public static void continueBlock()
    {
        fallingSpeed = fallingSpeedRef;
    }

    public static void stopSpawn()
    {
        spawnTime = 0;
    }

    public static void continueSpawn()
    {
        spawnTime = 1.66f;
    }

    public static void spawnAddOne()
    {
        spawned += 1;
    }

    public static void scannedPlusOne()
    {
        scanned += 1;
    }

    public static void gameOver()
    {
        fallingSpeed = 0;
        spawnTime = 0;
        backMenu = false;
        if (score > highScore)
        {
            PlayerPrefs.SetInt("High Score", score);
        }
        gameIsOver = true;
    }

    public static void faster()
    {
        fallingSpeed += .5f;
    }

    public static void resetStats()
    {
        cam = Camera.main;
        score = 0;
        fallingSpeed = 2f;
        fallingSpeedRef = 2f;
        spawnTime = 1.66f;
        spawned = 0;
        scanned = 0;
    }
}
