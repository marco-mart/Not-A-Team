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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadLevelSelect() {
        print("There is currently no Level Select Screen. Please try again later!");
        //SceneManager.LoadScene(LevelSelect);
    }

    public void QuitGame() {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
