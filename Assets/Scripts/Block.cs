using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public static Rigidbody2D rb;
    public int color;
    public static Vector3 v3Pos;
    public static float threshold = 9;
    public static int column;
    public static Vector3 tempPosition;
    public static bool moving = false;

    // Use this for initialization
    void Start() {
        //transform.localScale = new Vector2((Values.width / 3)-.5f, 1.5f);
        //sets column at initialization
        column = Mathf.FloorToInt(transform.position.x / Values.border1);
    }

    // Update is called once per frame
    void Update() {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -1 * Values.fallingSpeed);
        if (transform.position.y < -5)
        {
            Destroy(gameObject);
        }
    }

    public void SetColor(int num)
    {
        color = num;
    }

    public int GetColor()
    {
        return color;
    }

    void setColumn(int num)
    {
        column = num;
    }

    void OnMouseDown()
    {
        v3Pos = Input.mousePosition;
    }

    void OnMouseUp()
    {
        var v3 = Input.mousePosition - v3Pos;
        RaycastHit2D hit;
        v3.Normalize();
        var f = Vector3.Dot(v3, Vector3.up);
        if (Vector3.Distance(v3Pos, Input.mousePosition) < threshold)
        {
            return;
        }

        if (f >= 0.5)
        {
        }
        else if (f <= -0.5)
        {
        }
        else
        {
            var left = transform.TransformDirection(Vector3.left);
            var right = transform.TransformDirection(Vector3.right);
            f = Vector3.Dot(v3, Vector3.right);
            if (f >= 0.5)
            {
                //RIGHT
                hit = Physics2D.Raycast(transform.position, right);
                if (hit.collider != null)
                {
                    if (hit.transform.gameObject.tag == "Block" && moving == false)
                    {
                        Debug.Log(GetColor());
                        Debug.Log(hit.transform.gameObject.GetComponent<Block>().GetColor());

                        tempPosition = transform.position;
                        if (hit.transform.gameObject.GetComponent<Block>().GetColor() != color)
                        {
                            StartCoroutine(Swap(Values.slidingSpeed, hit.transform.gameObject.GetComponent<Block>().transform.position));
                            hit.transform.gameObject.GetComponent<Block>().externalSwap(Values.slidingSpeed, tempPosition);
                        }
                        else
                        {
                            StartCoroutine(KillSwap(Values.slidingSpeed, hit.transform.gameObject.GetComponent<Block>().transform.position));
                        }
                    }
                }
            }
            else
            {
                //LEFT
                hit = Physics2D.Raycast(transform.position, left);
                if (hit.collider != null)
                {
                    if (hit.transform.gameObject.tag == "Block" && moving == false)
                    {
                        tempPosition = transform.position;
                        if (hit.transform.gameObject.GetComponent<Block>().GetColor() != color)
                        {
                            StartCoroutine(Swap(Values.slidingSpeed, hit.transform.gameObject.GetComponent<Block>().transform.position));
                            hit.transform.gameObject.GetComponent<Block>().externalSwap(Values.slidingSpeed, tempPosition);
                        }
                        else
                        {
                            StartCoroutine(KillSwap(Values.slidingSpeed, hit.transform.gameObject.GetComponent<Block>().transform.position));
                        }
                    }
                }
            }
        }
        v3Pos = Input.mousePosition;
    }

    IEnumerator Swap(float time, Vector3 targetPosition)
    {
        moving = true;
        float i = 0;
        while (i < 1)
        {
            i += Time.deltaTime / time;
            transform.position = Vector3.Lerp(transform.position, targetPosition, i);
            targetPosition.y -= Time.deltaTime * Values.fallingSpeed ;
            //test2.position = Vector3.Lerp(test2.position, tempPos1, i);
            yield return 0;
        }
        moving = false;
    }

    IEnumerator KillSwap(float time, Vector3 targetPosition)
    {
        moving = true;
        float i = 0;
        while (i < 1)
        {
            i += Time.deltaTime / time;
            transform.position = Vector3.Lerp(transform.position, targetPosition, i);
            targetPosition.y -= Time.deltaTime * Values.fallingSpeed;
            //test2.position = Vector3.Lerp(test2.position, tempPos1, i);
            yield return 0;
        }
        GetComponent<SpriteRenderer>().enabled = false;
        SetColor(3);
        transform.position = new Vector3(tempPosition.x, transform.position.y, 0);
        Debug.Log(transform.position);
        moving = false;
        gameObject.GetComponent<TrailRenderer>().enabled = false;
    }

    void externalSwap(float time, Vector3 targetPosition)
    {
        StartCoroutine(Swap(time, targetPosition));
    }

    public void OnBecameInvisible()
    {
        //Destroy(gameObject);
    }
}
