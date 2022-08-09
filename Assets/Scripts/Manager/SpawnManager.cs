using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] public List<GameObject> currentPlayers = new List<GameObject>();
    [SerializeField] public int currentPlayerNumber;
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private Transform centerPoint;

    [SerializeField] private float[] spawnPosXValue;
    [SerializeField] private float[] spawnPosZValue;
    private float spawnPosX;
    private float spawnPosZ;
    private Vector3 spawnPos;


    private void Update()
    {
        CurrentPlayers();        
    }

    private int CurrentPlayers()
    {
        currentPlayerNumber = currentPlayers.Count;
        return currentPlayerNumber;
    }

    public void SpawnPlayer()
    {
       GameObject newplayer =  Instantiate(playerPrefab, centerPoint.position + SpawnPosition(), Quaternion.identity);
        newplayer.transform.SetParent(centerPoint);
        currentPlayers.Add(newplayer);
    }

    private Vector3 SpawnPosition()
    {
        spawnPosXValue[0] = Random.Range(-0.8f, -2.0f);
        spawnPosXValue[1] = Random.Range(0.8f, 2.0f);

        spawnPosZValue[0] = Random.Range(-0.8f, -1.0f);
        spawnPosZValue[1] = Random.Range(0.8f, 1.0f);

        spawnPosX = Random.Range(spawnPosXValue[0], spawnPosXValue[1]);
        spawnPosZ = Random.Range(spawnPosZValue[0], spawnPosZValue[1]);
        spawnPos = new Vector3(spawnPosX, playerPrefab.transform.position.y, spawnPosZ);
        return spawnPos;
    }   
}
