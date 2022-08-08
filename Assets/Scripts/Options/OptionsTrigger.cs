using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsTrigger : MonoBehaviour
{
    [SerializeField] private int optionsMultiplicationValue;
    [SerializeField] private int optionsAdditionValue;
    [SerializeField] private bool isAdditionOperation;
    private SpawnManager spawnManager;
    [SerializeField] private int numberAddList;

    private void Awake()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CenterPoint")
        {
            if (isAdditionOperation)
            {
                numberAddList = (spawnManager.currentPlayerNumber + optionsAdditionValue)-spawnManager.currentPlayerNumber;
                for (int i = 0; i < numberAddList; i++)
                {
                    spawnManager.SpawnPlayer();
                }                
            }
            else if (!isAdditionOperation)
            {
                numberAddList = (spawnManager.currentPlayerNumber * optionsMultiplicationValue)-spawnManager.currentPlayerNumber;
                for (int i = 0; i < numberAddList; i++)
                {
                    spawnManager.SpawnPlayer();
                }               
            }
        }
    }
}
