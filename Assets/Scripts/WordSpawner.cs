using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;    
    public Transform wordCanvas;
    /*bool CanSpawnPrefab()
    {
        GameObject tempPrefab = Instantiate(wordPrefab);
        PrefabCollisionDetector collisionDetector = tempPrefab.GetComponent<PrefabCollisionDetector>();

        bool canSpawn = !collisionDetector.IsColliding;

        Destroy(tempPrefab);

        return canSpawn;
    }

    public wordDisplay SpawnPrefab()
    {
        if (CanSpawnPrefab())
        {
            spawnWord();
        }
        else
        {
            Debug.Log("Prefab would collide with other objects. Cannot spawn.");
            
        }        
        return null;
    }*/
    public wordDisplay spawnWord() //spawns word function
    {
        Vector3 randomPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-1.3f, 4.1f)); // position word prefab with randomness
        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas); //pag spawn ng word 
        wordDisplay wordDisplay = wordObj.GetComponent<wordDisplay>();

        return wordDisplay;
    }

    /* public wordTMPDisplay spawnWord() //spawns word function
     {
         Vector3 randomPosition = new Vector3(Random.Range(-7f, 7f), Random.Range(-1.8f, 3.8f)); // position word prefab with randomness
         GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas); //pag spawn ng word 
         wordTMPDisplay wordTMPDisplaya = wordObj.GetComponent<wordTMPDisplay>();

         return wordTMPDisplaya;
     }*/
}
