using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class WordManager : MonoBehaviour
{
    public List<Word> words;
    public WordSpawner spawner;
    public TMP_Text scoreText;
    public TMP_Text finalScore;
    public Canvas UICanvas;
    public Canvas TextCanvas;
    public Canvas GameOverCanvas;

    public bool stopSpawn = false;
    private bool isActiveWord;
    private Word activeWord;
    public TextMeshProUGUI count;
    public float score = 0;

    public void AddWord()
    {
        if (stopSpawn == false)
        {
            //add delay
            Word word = new Word(WordGenerator.GetRandomWord(), spawner.spawnWord());
            Debug.Log(word.word);

            words.Add(word);
        }
    }

    public void typeLetter(char letter)
    {
        if (isActiveWord)
        {
            if (activeWord.getNextLetter() == letter)
            {
                activeWord.typeLetter();
                score++;
                Debug.Log("Score: " + score);
            }
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.getNextLetter() == letter)
                {
                    activeWord = word;
                    isActiveWord = true;
                    word.typeLetter();
                    score++;
                    Debug.Log("Score: " + score);
                    break;
                }
            }
        }

        if (isActiveWord && activeWord.wordTyped())
        {
            isActiveWord = false;
            words.Remove(activeWord);
        }
    }

    private void Update()
    {
        if (words.Count >= 30)
        {
            TextCanvas.gameObject.SetActive(false);
            UICanvas.gameObject.SetActive(false);
            GameOverCanvas.gameObject.SetActive(true);
            stopSpawn = true;
            finalScore.text = score.ToString();
        }
        count.text = words.Count.ToString();        
    }
}
