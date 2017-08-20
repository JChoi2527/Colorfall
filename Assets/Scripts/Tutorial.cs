using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text tutorialText;
    public float timeLeft = 99999999;

    const float period = 4.0f;
    // Update is called once per frame
    void Update()
    {
        if (Values.startGame == true)
        {
            timeLeft = 7f;
        }
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            if (Time.time > period)
            {
                //Destroy(gameObject);
            }
            Color colorOfObject = tutorialText.color;   // for Unity 5x
            float prop = (Time.time / period);
            colorOfObject.a = Mathf.Lerp(1, 0, prop);
            tutorialText.color = colorOfObject;    // for Unity 5x
        }
    }
}
