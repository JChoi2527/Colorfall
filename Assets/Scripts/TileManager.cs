using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

    public static int taken1 = 0;
    public static int taken2 = 0;
    public static int tile1;
    public static int tile2;
    public static int tile3;
    public static GameObject RedTile;
    public static GameObject GreenTile;
    public static GameObject BlueTile;

    // Use this for initialization
    void Start () {
        RedTile = GameObject.Find("RedTile");
        GreenTile = GameObject.Find("GreenTile");
        BlueTile = GameObject.Find("BlueTile");
    }
	
	// Update is called once per frame
	void Update () {
		if (Values.score == -1)
        {
            tile1 = Random.Range(1, 4);
            taken1 = tile1;
            tile2 = taken1;
            while (tile2 == taken1)
            {
                tile2 = Random.Range(1, 4);
            }
            taken2 = tile2;
            tile3 = taken1;
            while (tile3 == taken1 || tile3 == taken2)
            {
                tile3 = Random.Range(1, 4);
            }
            RedTile.GetComponent<RedTile>().externalSwap(Values.slidingSpeed, new Vector3(Values.spawn[tile1 - 1], 0, 0));
            GreenTile.GetComponent<GreenTile>().externalSwap(Values.slidingSpeed, new Vector3(Values.spawn[tile2 - 1], 0, 0));
            BlueTile.GetComponent<BlueTile>().externalSwap(Values.slidingSpeed, new Vector3(Values.spawn[tile3 - 1], 0, 0));
        }
	}
}
