using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentNumberText;
    [SerializeField] private Transform centerPoint;
    private SpawnManager spawnManager;

    private void Awake()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
    }

    private void LateUpdate()
    {
        CurrentPlayerNumber();
    }

    private void CurrentPlayerNumber()
    {
        currentNumberText.transform.position = new Vector3(centerPoint.position.x, centerPoint.position.y+2.5f, centerPoint.position.z);
        currentNumberText.text = spawnManager.currentPlayerNumber.ToString();        
    }
}
