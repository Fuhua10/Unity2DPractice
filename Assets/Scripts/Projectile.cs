using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] private float bulletSpeed = 20f;
    [SerializeField] private float lifeTime = 3f;

    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    public void Initialize(Vector2 faceDir)
    {
        rb.velocity = faceDir * bulletSpeed;
        Destroy(gameObject,lifeTime);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player") && !collision.CompareTag("Coin"))
        {
            Destroy(gameObject);
        }
    }
}
