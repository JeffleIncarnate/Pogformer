// Modules
using UnityEngine;

// Unity Class
public class EnemyFast : MonoBehaviour
{
    // Hitpoints
    public float HitPoints;
    public float MaxHitPoints = 20;
    public GameObject deathEffect;


    // Movement
    public float speed = 20f;
    public bool movingRight = true;
    public Transform grounDetection;
    public float distance = 2f;


    // Damage Method
    public void TakeDamage(int damage)
    {
        // HitPoints -= damage
        HitPoints -= damage;

        // Check Hitpoints Lower than 0
        if (HitPoints <= 0)
        {
            // Then Die
            Die();
        }
    }

    // Die Method
    public void Die()
    {
        // Particals
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Debug.Log("Enemy is now Dead haha lol you are actually good");
    }

    public void Update()
    {
        // MOVEMENT AHHHHHH
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(grounDetection.position, Vector2.down, distance);

        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}
