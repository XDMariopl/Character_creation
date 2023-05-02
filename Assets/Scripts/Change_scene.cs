using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_scene : MonoBehaviour {

    public void BackToStarScreen()
    {
        SceneManager.LoadScene("StartScreen", LoadSceneMode.Single);
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainGame", LoadSceneMode.Single);
    }
    public void Stop()
    {
        Application.Quit();
    }
}
