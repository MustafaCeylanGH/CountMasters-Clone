using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private SpawnManager spawnManager;
    private GameManager gameManager;
    
    private bool isDidCollidePlayer1;
    private bool isDidCollidePlayer2;
    private bool isDidCollidePlayer3;
    private bool isDidCollidePlayer4;

    private void Awake()
    {        
        spawnManager = FindObjectOfType<SpawnManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1") && !isDidCollidePlayer1)
        {
            isDidCollidePlayer1 = true;
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gameManager.enemyTarget1Number--;
            spawnManager.currentPlayers.Remove(gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy2") && !isDidCollidePlayer2)
        {            
            isDidCollidePlayer2 = true;
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gameManager.enemyTarget2Number--;
            spawnManager.currentPlayers.Remove(gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy3") && !isDidCollidePlayer3)
        {            
            isDidCollidePlayer3 = true;
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gameManager.enemyTarget3Number--;
            spawnManager.currentPlayers.Remove(gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy4") && !isDidCollidePlayer4)
        {           
            isDidCollidePlayer4 = true;
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gameManager.enemyTarget4Number--;
            spawnManager.currentPlayers.Remove(gameObject);
        }        
    }
   
}
