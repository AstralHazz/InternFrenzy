using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Script : MonoBehaviour
{

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Riley_Version"); //Put name of main scene in here
    }
/*
    public void PlayLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void PlayFinalLevel()
    {
        SceneManager.LoadScene("LastLevel");
    }
*/
    public void GotoMainMenu()
    {
        SceneManager.LoadScene("IntroMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();

    }
}