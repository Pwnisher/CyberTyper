using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class wordDisplay : MonoBehaviour
{    
    public Text text;
    //public Color textColor;
    public void setWord(string word)
    {
        text.text = word;
    }

    public void removeLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.black;
    }

    public void removeWord()
    {
        Destroy(gameObject);        
    }    

    private void Update()
    {
        //eto ung nagpapa fall ng words xd
        //transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }
}
