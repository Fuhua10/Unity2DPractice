using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float fireInterval = 0.25f;

    private float nextFireTime = 0f;

    private bool isFiring = false;

    private PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        if (isFiring && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireInterval;
        }

    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        Projectile projectile = bullet.GetComponent<Projectile>();
        projectile.Initialize(playerMovement.FaceDir);
    }

    private void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
        
    }
}
