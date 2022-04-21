using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public StatManager gameStateManager;
    public Canvas mainMenu;
    public Canvas gamePlay;
    public Canvas gameOver;
    

    public void OnEnable()
    {
        gameStateManager.GameMainMenu += ChangeToMainMenu;
        gameStateManager.GamePlay += ChangeToGamePlay;
        gameStateManager.GameOver += ChangeToGameOver;

    }


    public void ChangeToMainMenu()
    {
        gamePlay.enabled = false;
        mainMenu.enabled = true;
        gameOver.enabled = false;
    }
    public void ChangeToGamePlay()
    {
        gamePlay.enabled = true;
        mainMenu.enabled = false;
        gameOver.enabled = false;
    }
    public void ChangeToGameOver()
    {
        gamePlay.enabled = false;
        mainMenu.enabled = false;
        gameOver.enabled = true;
    }
    public void GameQuit()
    {
        Application.Quit();
    }
    public void Start()
    {
        instance = this;
    }
}
