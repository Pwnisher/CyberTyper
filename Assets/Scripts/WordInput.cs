using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WordManager wordManager;   
    void Update()
    {
        if(wordManager.stopSpawn == false)
        {
            foreach (char letter in Input.inputString)
            {
                wordManager.typeLetter(letter);
            }
        }
    }
}
