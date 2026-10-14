using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float stopDistance = 1.5f;

    private Transform playerTransform;
    private Vector2 playerPosition = Vector2.zero;
    private Vector2 position = Vector2.zero;
    private Rigidbody2D rb;
    private Vector2 direction = Vector2.zero;

    private float distance = 0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();    
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //等player awake
        if(player != null)
        {
            playerTransform = player.transform;
        }
        
    }

    
    void FixedUpdate()
    {
        position = transform.position;
        playerPosition = playerTransform.position;
        distance = Vector2.Distance(position,playerPosition);

        if(distance > stopDistance)
        {
            direction = (playerPosition - position).normalized;
            rb.MovePosition(position + direction * moveSpeed * Time.fixedDeltaTime);
        }
    }

  


}
