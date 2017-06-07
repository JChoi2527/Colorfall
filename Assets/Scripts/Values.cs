using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Values : MonoBehaviour {

    public static float fallingSpeed = .03f / Time.deltaTime;
    public static float spawnTime = (.04f / Time.deltaTime)/fallingSpeed;
    public static float slidingSpeed = .2f;
	//public static float width = Screen.width;
	//public static float height = Screen.height;
	public static Camera cam = Camera.main;
	public static float height = 16f;
	public static float width = 10f;
	public static float border1 = width / 3;
	public static float border2 = (width / 3) * 2;
    public static float[] spawn;
	public static int score = 0;


	// Use this for initialization
	void Start () {
        spawn = new float[3];
        spawn[0] = width / 6;
        spawn[1] = width / 2;
        spawn[2] = (width * 5) / 6;

    }

	// Update is called once per frame
	void Update () {
		
	}

	public static void addOne()
	{
		score++;
	}
}
