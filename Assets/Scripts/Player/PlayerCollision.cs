using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private SpawnManager spawnManager;
    private GameManager gameManager;
    private bool isDidCollidePlayer1;
    private bool isDidCollidePlayer2;

    private void Awake()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy1"))
        {
            if (!isDidCollidePlayer1)
            {
                isDidCollidePlayer1 = true;
                Destroy(gameObject);
                Destroy(collision.gameObject);
                spawnManager.currentPlayers.Remove(gameObject);
                gameManager.enemyTarget1Number--;
                
            }         
        }

        if (collision.gameObject.CompareTag("Enemy2"))
        {
            if (!isDidCollidePlayer2)
            {
                isDidCollidePlayer2 = true;
                Destroy(gameObject);
                Destroy(collision.gameObject);
                spawnManager.currentPlayers.Remove(gameObject);
                gameManager.enemyTarget2Number--;

            }
        }
    }
}
