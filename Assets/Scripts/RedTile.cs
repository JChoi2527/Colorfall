using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTile : MonoBehaviour {

    public static bool moving = false;
    public static bool colliding = true;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(Values.spawn[0], .5f, 0);
		transform.localScale = new Vector2 (Values.width/3, 1);
	}
	
	// Update is called once per frame
	void Update () {
    }

	void OnTriggerEnter2D (Collider2D collided)
	{
        colliding = true;
        if (collided.gameObject.GetComponent<Block>().GetColor() == 0 || collided.gameObject.GetComponent<Block>().GetColor() == 4)
        {
            if (Values.justComboed == false)
            {
                Values.addOne();
            }
        }
        else if (collided.gameObject.GetComponent<Block>().GetColor() != 3)
        {
            Values.gameOver();
        }
        GameObject.Find("Audio Source").GetComponent<Fx>().Score();
    }

    void OnTriggerExit2D(Collider2D collided)
    {
        int collidedColor = collided.gameObject.GetComponent<Block>().GetColor();
        if (collidedColor == 0 || collidedColor == 1 || collidedColor == 2 || collidedColor == 3 || collidedColor == 4)
        {
            Values.scannedPlusOne();
        }
        colliding = false;
    }

    public bool Colliding()
    {
        return colliding;
    }

    public void externalSwap(float time, Vector3 targetPosition)
    {
        StartCoroutine(Swap(time, targetPosition));
    }

    IEnumerator Swap(float time, Vector3 targetPosition)
    {
        moving = true;
        float i = 0;
        while (i < 1)
        {
            i += Time.deltaTime / time;
            transform.position = Vector3.Lerp(transform.position, targetPosition, i);
            //test2.position = Vector3.Lerp(test2.position, tempPos1, i);
            yield return 0;
        }
        moving = false;
    }
}
