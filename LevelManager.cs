// Moduels
using UnityEngine.SceneManagement;
using UnityEngine;

// Unity Class
public class LevelManager : MonoBehaviour
{
    // Variables
    public bool levelNext = false;
    public GameObject nextLevelUI;

    // Checkf or collion to start the Next level UI
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Chck if it was the right collision
        if (collision.gameObject.tag == "End")
        {
            // If so we execute this code
            this.GetComponent<PlayerMovement>().enabled = false;
            this.GetComponent<Wepon>().enabled = false;
            nextLevelUI.SetActive(true);
            Time.timeScale = 0f;
            levelNext = true;
            Debug.Log("AHHA YOU WON LOL TRASH");
        }
    }

    // Next level Method
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Load Next Level");
        Time.timeScale = 1f;
    }

}
