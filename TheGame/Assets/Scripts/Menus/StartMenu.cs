using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public string LevelSelect;
    
    public void PlayGame() 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }

    public void LoadLevelSelect() {
        SceneManager.LoadScene(LevelSelect);
    }

    public void QuitGame() {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
