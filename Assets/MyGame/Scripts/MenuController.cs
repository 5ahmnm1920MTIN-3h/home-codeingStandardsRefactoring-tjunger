using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static string mainScene = "MainScene";
    
    public void Play()
    {
        SceneManager.LoadScene(mainScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
