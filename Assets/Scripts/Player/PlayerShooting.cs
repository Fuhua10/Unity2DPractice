using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] private GameObject bulletPerfab;

    private PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnFire()
    {
        GameObject bullet = Instantiate(bulletPerfab,transform.position,transform.rotation);
        
        Projectile projectile = bullet.GetComponent<Projectile>();
        projectile.initialize(playerMovement.FaceDir);
    }
}
