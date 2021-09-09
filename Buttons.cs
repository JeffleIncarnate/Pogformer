// Modules
using UnityEngine.SceneManagement;
using UnityEngine;

// Unity Class
public class Buttons : MonoBehaviour
{
    // Variables
    public string x = "Loading Scene ";


    // Game Buttons
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting Game...");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        Debug.Log("Playing Again..");
    }

    // Main Menu
    public void Level_01()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
        Debug.Log(x + "1");
    }

    public void Level_02()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
        Debug.Log(x + "2");
    }

    public void Level_03()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
        Debug.Log(x + "3");
    }

    public void Level_04()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
        Debug.Log(x + "4");
    }

    public void Level_05()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
        Debug.Log(x + "5");
    }

    public void Level_06()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
        Debug.Log(x + "6");
    }

    public void Level_07()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
        Debug.Log(x + "7");
    }

    public void Level_08()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
        Debug.Log(x + "8");
    }

    public void Level_09()
    {
        SceneManager.LoadScene(9);
        Time.timeScale = 1f;
        Debug.Log(x + "9");
    }

    public void Level_10()
    {
        SceneManager.LoadScene(10);
        Time.timeScale = 1f;
        Debug.Log(x + "10");
    }

    public void Level_11()
    {
        SceneManager.LoadScene(11);
        Time.timeScale = 1f;
        Debug.Log(x + "11");
    }

    public void Level_12()
    {
        SceneManager.LoadScene(12);
        Time.timeScale = 1f;
        Debug.Log(x + "12");
    }
}
