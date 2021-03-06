using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Winner : MonoBehaviour
{
    //private static float health;
    public GameObject WinUI;
    public string Menu;
    public string restartLevel;
    public GameObject JohnSmith;
    //private float menuCooldown;
    //public GameObject image;
    public GameObject JohnsDoor;
    private BoxCollider2D JohnBox;
    private BoxCollider2D DoorBox;

    void Awake() {
        JohnBox = JohnSmith.GetComponent<BoxCollider2D>();
        DoorBox = JohnsDoor.GetComponent<BoxCollider2D>();
    } //end Awake

    // Update is called once per frame
    void Update()
    {
        if (DoorBox.IsTouching(JohnBox) && Input.GetKey(KeyCode.UpArrow)) {
            Win();
        } //end if
    }

    private void Win() {
        print("You Won!");
        //trigger animation

        //trigger UI
        WinUI.SetActive(true);
        Time.timeScale = 0f;
    } //end win

    public void Restart() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } //end restart

    public void LoadMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Menu);
    }

    public void QuitGame() {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }

    public void NextLevel() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } //end NextLevel

} //end class

