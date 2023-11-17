using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
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
            GameObject.Find("GameManager").GetComponent<GameManager>().AddScore(2,1);
            transform.position = new Vector3(8.885f, 5f, 0f);
            rigid.velocity = Vector3.zero;
            GameObject.Find("player1").GetComponent<Player1>().resetPos();
            GameObject.Find("player2").GetComponent<Player2>().resetPos();
        }
        else if (collision.gameObject.CompareTag("ground_p2"))
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().AddScore(1,1);
            transform.position = new Vector3(-8.885f, 5f, 0f);
            rigid.velocity = Vector3.zero;
            GameObject.Find("player1").GetComponent<Player1>().resetPos();
            GameObject.Find("player2").GetComponent<Player2>().resetPos();
        }

    }
}
