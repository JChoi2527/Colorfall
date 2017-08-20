using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Values : MonoBehaviour {

    public Camera mainCamera;
    public static float fallingSpeed = 0f;
    public static float fallingSpeedRef = 2f;
    public static float spawnTime = 0f;
    public static float slidingSpeed = .1f;
    public static Camera cam;
	public static float height;
	public static float width;
	public static float border1;
	public static float border2;
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
    public static int combine;
    public static int spawnSinceCombo;
    public static bool isComboing;
    public static int comboed;
    public static bool justComboed;
    // Use this for initialization
    void Start () {
        cam = Camera.main;



        height = 19;
        width = 10;



        //width = mainCamera.pixelWidth;
        //height = mainCamera.pixelHeight;



        border1 = width / 3;
        border2 = (width / 3) * 2;
        spawn = new float[3];
        spawn[0] = width / 6;
        spawn[1] = width / 2;
        spawn[2] = (width * 5) / 6;
        highScore = PlayerPrefs.GetInt("High Score");
        combine = 0;
        comboed = 0;
        justComboed = false;
        score = 0;
    }

	// Update is called once per frame
	void Update () {
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
        GameObject.Find("Audio Source").GetComponent<Fx>().gameOver();
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
        spawnTime -= .5f;
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
        combine = 0;
        isComboing = false;
        comboed = 0;
        justComboed = false;
    }
}
