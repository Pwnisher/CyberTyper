using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;    
    public float score;
    public WordManager wordManager;
        
    public void displayScore(float score)
    {
        scoreText.text = score.ToString();
    }

    private void Update()
    {
        score = wordManager.score;
        displayScore(wordManager.score);
    }
}
