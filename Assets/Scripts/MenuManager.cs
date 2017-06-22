using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public static bool mainMenuIsOpen;
    public static bool gameIsOver;
    private Animator myAnimator;

    // Use this for initialization
    void Start () {
        mainMenuIsOpen = false;
        myAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        myAnimator.SetBool("IsOpen", mainMenuIsOpen);
        myAnimator.SetBool("IsOver", Values.gameIsOver);
        myAnimator.SetBool("startGame", Values.startGame);
        myAnimator.SetBool("backMenu", Values.backMenu);
    }

    public void mainMenuOpen()
    {
        mainMenuIsOpen = true;
        Values.backMenu = false;
        Values.stopBlock();
        Values.stopSpawn();
        Time.timeScale = 0;
    }

    public void mainMenuClose()
    {
        mainMenuIsOpen = false;
        Values.backMenu = true;
        Values.continueBlock();
        Values.continueSpawn();
        Time.timeScale = 1;
    }

    public void startGame()
    {
        Values.continueBlock();
        Values.continueSpawn();
        Values.startGame = false;
        Values.backMenu = true;
        Time.timeScale = 1;
    }

    public void restartMenu()
    {
        TileManager.resetSwitchNum();
        StartCoroutine(Fading());
    }

    IEnumerator Fading()
    {
        float fadeTime = GameObject.Find("Main Camera").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(.8f);
        Application.LoadLevel(Application.loadedLevel);
        Values.gameIsOver = false;
        Values.backMenu = true;
        Values.resetStats();
    }
}
