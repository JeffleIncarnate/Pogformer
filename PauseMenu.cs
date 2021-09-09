// Modules
using UnityEngine;

// unity Class
public class PauseMenu : MonoBehaviour
{
    // Variables
    public bool gamePaused = false;
    public GameObject pauseMenuUI;


    // Update is called once per frame
    void Update()
    {
        // Check For Input
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            // Check is gamePaused for UI
            if(gamePaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }

    // Resume Method
    public void Resume()
    {
        Debug.Log("Unpausing Game...");
        this.GetComponent<Wepon>().enabled = true;
        this.GetComponent<PlayerMovement>().enabled = true;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    // Paused Method
    public void Pause()
    {
        Debug.Log("Pausing Game...");
        this.GetComponent<Wepon>().enabled = false;
        this.GetComponent<PlayerMovement>().enabled = true;
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }
}
