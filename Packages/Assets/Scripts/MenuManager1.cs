using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}
