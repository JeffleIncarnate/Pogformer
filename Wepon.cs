// Modules
using UnityEngine;

// Unity Class
public class Wepon : MonoBehaviour
{
    // Variables
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject bulletParticals;

    // Update is called once per frame
    void Update()
    {
        //IF we hit right mouse button we want to shoot
        if(Input.GetButtonDown("Fire1"))
        {
            // Calling the shoot method
            Shoot();
        }
    }

    // The shoot method
    void Shoot()
    {
        // Particals for the bullet spawn
        Instantiate(bulletParticals, firePoint.position, firePoint.rotation);

        // Spawn the shoot bullet
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
