using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTile : MonoBehaviour {

    public static bool moving = false;
    public static bool notColliding = true;

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(Values.spawn[0], .5f, 0);
		transform.localScale = new Vector2 (Values.width/3, 1);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (Values.score);
	}

	void OnTriggerEnter2D (Collider2D collided)
	{
        notColliding = false;
        if (collided.gameObject.GetComponent<Block>().GetColor() == 0)
        {
			Values.addOne ();
		}
		else if (collided.gameObject.GetComponent<Block>().GetColor() != 3)
        {
            Values.gameOver();
		}
	}

    void OnTriggerExit2D(Collider2D collided)
    {
        if (collided.gameObject.GetComponent<Block>().GetColor() == 0 || collided.gameObject.GetComponent<Block>().GetColor() == 1 || collided.gameObject.GetComponent<Block>().GetColor() == 2 || collided.gameObject.GetComponent<Block>().GetColor() == 3)
        {
            Values.scannedPlusOne();
            GameObject.Find("Audio Source").GetComponent<Fx>().Score();
        }
        notColliding = true;
    }

    public bool Colliding()
    {
        return notColliding;
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
