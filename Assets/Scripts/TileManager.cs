using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {

    public static int taken1 = 0;
    public static int taken2 = 0;
    public static int tile1;
    public static int tile2;
    public static int tile3;
    public static GameObject RedTile = GameObject.Find("RedTile");
    public static GameObject GreenTile = GameObject.Find("GreenTile");
    public static GameObject BlueTile = GameObject.Find("BlueTile");

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		if (Values.score >= 5)
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
