using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // score[0] => 1P
    // score[1] => 2P
    public int[] score = new int[2];
    
    void Start()
    {
        score[0] = 0;
        score[1] = 0;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
        }
    }
    public void AddScore(int player, int addition)
    {
        score[player-1] += addition;
    }
    public int GetScore(int player)
    {
        return score[player-1];
    }

}
//GameObject.Find("score_p1").GetComponent<score_p1>().AddScore(1);