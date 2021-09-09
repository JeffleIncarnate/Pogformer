// Modules
using UnityEngine;

// Untiy Class
public class Bullet : MonoBehaviour
{
    // Bullet Variables
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 1;
    public GameObject bulletDeath;

    // Start Method
    public void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Check for Bullet Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // play bullet when dead
        Instantiate(bulletDeath, transform.position, Quaternion.identity);

        // If collision  = true then destroy bullet
        Destroy(gameObject);
    }

    // Trigger for damage for the Enemy
    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // Calling damage Method
        EnemySlow enemy = hitInfo.GetComponent<EnemySlow>();
        EnemyMedium enemy1 = hitInfo.GetComponent<EnemyMedium>();
        EnemyFast enemy2 = hitInfo.GetComponent<EnemyFast>();

        // Check for bullet hit Enemy
        if(enemy != null)
        {
            // play bullet when dead
            Instantiate(bulletDeath, transform.position, Quaternion.identity);

            // Damage enemy
            enemy.TakeDamage(damage);
        }

        // Check for bullet hit Enemy1
        if (enemy1 != null)
        {
            // play bullet when dead
            Instantiate(bulletDeath, transform.position, Quaternion.identity);

            // Damage enemy
            enemy1.TakeDamage(damage);
        }

        // Check for bullet hit Enemy2
        if (enemy1 != null)
        {
            // play bullet when dead
            Instantiate(bulletDeath, transform.position, Quaternion.identity);

            // Damage enemy
            enemy2.TakeDamage(damage);
        }

        // Destroy bullet when it hits a enemy
        Destroy(gameObject);
    }
}
