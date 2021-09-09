// Modules
using UnityEngine;

// Unity Class
public class PlayerDead : MonoBehaviour
{
    // Variables
    public bool isDead = false;
    public GameObject deathMenuUI;

    // Check if Player hit Enemy
    public void OnCollisionEnter2D(Collision2D collision)
    {
        // If so we want to die
        if(collision.gameObject.tag == "Enemy")
        {
            // Calling the dying Method
            Dead();
        }
    }

    // Death method
    public void Dead()
    {
        // Once we diew we insult the player
        Debug.Log("ahahahah Lol trash");
        deathMenuUI.SetActive(true);
        Time.timeScale = 0f;
        this.GetComponent<PlayerMovement>().enabled = false;
        this.GetComponent<Wepon>().enabled = false;
    }
}
