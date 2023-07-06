using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class Word
{
    public string word;
    private int typeIndex;
    private wordDisplay display;   

    public Word(string _word, wordDisplay _display)
    {
        word = _word;
        typeIndex = 0;
        display = _display;
        display.setWord(word);
    }

    public char getNextLetter()
    {
        return word[typeIndex];
    }

    public void typeLetter()
    {
        typeIndex++;
        //remove the letter on screen
        display.removeLetter();
    }

    public bool wordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if(wordTyped)
        {
            //remove word on screen
            display.removeWord();
        }
        return wordTyped;
    }
}
