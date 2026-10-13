using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    Rigidbody2D rb;

    Vector2 moveInput = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("玩家初始化");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);   
        //rb.velocity = moveInput * moveSpeed;  //速度不用乘时间，位移才要速度乘时间
    }

    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        moveInput = Vector2.ClampMagnitude(moveInput, 1f);
    }
}
