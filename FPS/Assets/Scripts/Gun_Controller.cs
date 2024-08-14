using UnityEngine;

public class Gun_Controller : MonoBehaviour
{
    // Gun settings
    public float fireRate = 10f; // shots per second
    public float bulletSpeed = 20f;
    public int bulletDamage = 10;

    // Bullet prefab
    public GameObject bulletPrefab;

    // Gun barrel transform
    public Transform gunBarrel; // set this to the tip of the gun barrel in the Inspector

    private float nextFireTime = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFireTime)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate bullet
        GameObject bullet = Instantiate(bulletPrefab, gunBarrel.position, gunBarrel.rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        bulletRb.velocity = gunBarrel.forward * bulletSpeed;

        // Calculate next fire time
        nextFireTime = Time.time + 1f / fireRate;
    }
}