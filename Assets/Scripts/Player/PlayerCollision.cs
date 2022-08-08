using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private SpawnManager spawnManager;
    private GameManager gameManager;

    private void Awake()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
        gameManager = FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);            
            spawnManager.currentPlayers.Remove(gameObject);
            gameManager.enemyTarget1Number--;
        }
    }
}
