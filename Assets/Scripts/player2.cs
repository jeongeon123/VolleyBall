using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    public bool isJumping;

    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        isJumping = false;
    }
    
    void Update()
    {
        
        if (Input.GetButtonUp("player2_h"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }
        
        if (Input.GetButtonDown("player2_h"))
        {
            spriteRenderer.flipX = Input.GetAxisRaw("player2_h") == -1;
        }
        
        if (Input.GetButtonDown("player2_j") && !isJumping)
        {
            isJumping = true;
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
           
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground_p1") | collision.gameObject.CompareTag("ground_p2"))
        {
            isJumping = false;
        }
    }
    
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("player2_h");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed)
        {
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        }
        else if (rigid.velocity.x < maxSpeed * (-1))
        {
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        }
    }
}

