using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class score_p1 : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        score = 0;
    }
 
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
 
    public int GetScore()
    {
        return score;
    }
 
    public void AddScore(int addition)
    {
        score += addition;
    }
 
}