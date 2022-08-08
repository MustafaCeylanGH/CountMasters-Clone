using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentNumberText;
    [SerializeField] private Transform centerPoint;

    [SerializeField] private TextMeshProUGUI enemyTarget1Text;
    [SerializeField] private Transform enemyTarget1;    
    [SerializeField] public int enemyTarget1Number;
    private SpawnManager spawnManager;

    private void Awake()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
    }

    private void LateUpdate()
    {
        CurrentPlayerNumber();
        EnemyTargetNumber();       
    }

    private void CurrentPlayerNumber()
    {
        currentNumberText.transform.position = new Vector3(centerPoint.position.x, centerPoint.position.y+2.5f, centerPoint.position.z);
        currentNumberText.text = spawnManager.currentPlayerNumber.ToString();        
    }

    private void EnemyTargetNumber()
    {
        if (enemyTarget1 != null)
        {
            enemyTarget1Text.transform.position = new Vector3(enemyTarget1.position.x, enemyTarget1.position.y + 2.5f, enemyTarget1.position.z);
            enemyTarget1Text.text = enemyTarget1Number.ToString();
        }       

        if (enemyTarget1Number == 0)
        {
            Destroy(enemyTarget1Text);
        }
    }
}
