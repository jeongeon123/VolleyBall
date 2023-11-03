using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rigid;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground_p1"))
        {
            GameObject.Find("score_p2").GetComponent<score_p2>().AddScore(1);
            transform.position = new Vector3(8.885f, 5f, 0f);
            rigid.velocity = Vector2.zero;
        }
        else if (collision.gameObject.CompareTag("ground_p2"))
        {
            GameObject.Find("score_p1").GetComponent<score_p1>().AddScore(1);
            transform.position = new Vector3(-8.885f, 5f, 0f);
            rigid.velocity = Vector2.zero;
        }

    }
}
