using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    private static float health;
    public GameObject GameOverUI;
    public string Menu;
    public string Level;
    public GameObject JohnSmith;
    private float menuCooldown;
    public GameObject image;

    // Update is called once per frame
    void Update() {


        health = JohnSmith.GetComponent<Health>().getCurrentHealth();

        if (health == 0f) {
            image.GetComponent<Animator>().SetBool("in", menuCooldown > 0.5f && menuCooldown < 1.5f);
            image.GetComponent<Animator>().SetBool("out", menuCooldown > 2.5f && menuCooldown < 3.5f);
            if (menuCooldown > 3.5f) {
                Die();
            } //end if
            menuCooldown += Time.deltaTime;
        } //end if
    } //end Update

    void Die() {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
    } //end Pause

    public void Restart() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Level);
    } //end restart

    public void LoadMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Menu);
    }

    public void QuitGame() {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
} //end class
