using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public static bool mainMenuIsOpen;
    public static bool gameIsOver;
    private Animator myAnimator;

    // Use this for initialization
    void Start () {
        mainMenuIsOpen = true;
        myAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        myAnimator.SetBool("IsOpen", mainMenuIsOpen);
        myAnimator.SetBool("IsOver", Values.gameIsOver);
    }

    public void mainMenuOpen()
    {
        mainMenuIsOpen = true;
        Values.stopBlock();
        Values.stopSpawn();
    }

    public void mainMenuClose()
    {
        mainMenuIsOpen = false;
        Values.continueBlock();
        Values.continueSpawn();
    }

    public void restartMeu()
    {
        Values.restart();
    }
}
