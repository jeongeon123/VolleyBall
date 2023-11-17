using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class ScoreBoard : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    private int score;

    private Transform tr;
    private string scoreBoardName;
    private int player;
    
    private void Awake()
    {
        tr = GetComponent<Transform>();
        scoreBoardName = tr.name;
        player = int.Parse(scoreBoardName[scoreBoardName.Length - 1].ToString());
    }

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        score = 0;
        Debug.Log(scoreBoardName);
    }
    
    void Update()
    {
        Debug.Log(player);
        score = GameObject.Find("GameManager").GetComponent<GameManager>().GetScore(player);
        scoreText.text = score.ToString();
    }
}