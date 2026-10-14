using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] private float bulletSpeed = 20f;

    private PlayerMovement playerMovement;
    private Rigidbody2D rb;
    private bool tagShoot = false;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody2D>();

        if(player != null)
        {
            playerMovement = player.GetComponent<PlayerMovement>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!tagShoot)
        {
            BulletMove();
            tagShoot = true;
            if (gameObject != null)
            {
                Destroy(gameObject, 3f);
            }            
        }
    }

    private void BulletMove()
    {
        rb.velocity = playerMovement.FaceDir * bulletSpeed; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player") && !collision.CompareTag("Coin"))
        {
            Destroy(gameObject);
        }        
    }
}
