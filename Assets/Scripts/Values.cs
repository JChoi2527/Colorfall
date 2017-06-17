using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Values : MonoBehaviour {

    public static float fallingSpeed;
    public static float spawnTime;
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
    public static float fallingSpeedRef;


    // Use this for initialization
    void Start () {
        cam = Camera.main;
        fallingSpeed = .05f / Time.deltaTime;
        spawnTime = (.05f / Time.deltaTime) / fallingSpeed;
        spawn = new float[3];
        spawn[0] = width / 6;
        spawn[1] = width / 2;
        spawn[2] = (width * 5) / 6;
        //Time.timeScale = 1;
    }

	// Update is called once per frame
	void Update () {
        Debug.Log(spawned);
        Debug.Log(scanned);
    }

	public static void addOne()
	{
        score++;
	}

    public static void restart()
    {
        gameIsOver = false;
        DestroyAll = true;
        fallingSpeed = .05f / Time.deltaTime;
        fallingSpeedRef = .05f / Time.deltaTime;
        spawnTime = (.05f / Time.deltaTime) / fallingSpeed;
    }

    public static void stopBlock()
    {
        fallingSpeedRef = fallingSpeed;
        fallingSpeed = 0;
    }

    public static void continueBlock()
    {
        fallingSpeed = .03f / Time.deltaTime;
    }

    public static void stopSpawn()
    {
        spawnTime = 0;
    }

    public static void continueSpawn()
    {
        spawnTime = (.05f / Time.deltaTime) / fallingSpeed;
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
        gameIsOver = true;
        fallingSpeed = 0;
        spawnTime = 0;
    }

    public static void faster()
    {
        fallingSpeed += .5f;
    }
}
