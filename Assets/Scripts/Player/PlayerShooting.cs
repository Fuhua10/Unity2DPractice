using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float fireInterval = 0.25f;

    private float pressedTime = 0f;
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
            if (Time.time - pressedTime < 0.25f || Time.time - pressedTime > 1f)
            {
                Shoot();
                nextFireTime = Time.time + fireInterval;
            }       
                        
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
        
        if (value.isPressed)
        {
            isFiring = true;
            pressedTime = Time.time;
        }
        else
        {
            Debug.Log("抬起");
            isFiring = false;
        }
        
    }
}
