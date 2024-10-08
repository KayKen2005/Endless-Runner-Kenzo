using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{

    public GameObject DeathScreenCanvas;

    public void ShowDeathScreen()
    {
        Debug.Log("heeeey1");
        DeathScreenCanvas.SetActive(true);

        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        Debug.Log("heeeey");
        SceneManager.LoadScene(1);

    }

    public void QuitGame()
    {

        Time.timeScale = 1f;
        Application.Quit();
    }


    public void play()
    {

        SceneManager.LoadSceneAsync(1);
    }

}