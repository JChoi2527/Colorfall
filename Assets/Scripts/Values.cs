using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


	// Use this for initialization
	void Start () {
        cam = Camera.main;
        fallingSpeed = .03f / Time.deltaTime; ;
        spawnTime = (.05f / Time.deltaTime) / fallingSpeed;
        spawn = new float[3];
        spawn[0] = width / 6;
        spawn[1] = width / 2;
        spawn[2] = (width * 5) / 6;
        //Time.timeScale = 1;

    }

	// Update is called once per frame
	void Update () {
        if (MenuManager.mainMenuIsOpen == true)
        {
            fallingSpeed = 0;
            spawnTime = 0;
        }
        else
        {
            fallingSpeed = .03f / Time.deltaTime; ;
            spawnTime = (.05f / Time.deltaTime) / fallingSpeed;
        }
        Debug.Log(score);
    }

	public static void addOne()
	{
        score++;
	}

    public static void restart()
    {
        Application.LoadLevel(0);
    }
}
