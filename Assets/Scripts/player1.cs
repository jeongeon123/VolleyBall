using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    public bool isJumping;

    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Transform tr;
    
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        tr = GetComponent<Transform>();
        isJumping = false;
    }
    
    void Update()
    {
        
        if (Input.GetButtonUp("player1_h"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.5f, rigid.velocity.y);
        }
        
        if (Input.GetButtonDown("player1_h"))
        {
            spriteRenderer.flipX = Input.GetAxisRaw("player1_h") == -1;
        }
        
        if (Input.GetButtonDown("player1_j") && !isJumping)
        {
            //isJumping = true;
            rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }
           
    }
    
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("ground_p1") | collision.gameObject.CompareTag("ground_p2")) 
    //    {
    //        isJumping = false;
    //    }
    //}
    
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("player1_h");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        if (rigid.velocity.x > maxSpeed)
        {
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        }
        else if (rigid.velocity.x < maxSpeed * (-1))
        {
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        }
        if(tr.position.y < -7)
        {
            isJumping = false;
        }
        else
        {
            isJumping = true;
        }
    }

    public void resetPos()
    {
        transform.position = new Vector3(-8.885f, -6f, 0f);
        rigid.velocity = Vector2.zero;
    }
}

