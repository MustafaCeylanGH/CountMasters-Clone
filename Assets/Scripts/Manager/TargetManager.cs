using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [SerializeField] private Transform centerPoint;

    [SerializeField] private Transform enemyTarget1;

    private bool isDidCollideTarget1;

    private void Update()
    {
        EnemyTarget1();
    }

    private void EnemyTarget1()
    {
        if (!isDidCollideTarget1)
        {
            if (centerPoint.position.z + 1.0f >= enemyTarget1.position.z)
            {                
                centerPoint.position = Vector3.MoveTowards(centerPoint.position, enemyTarget1.position, 3.1f*Time.deltaTime);
                enemyTarget1.position = Vector3.MoveTowards(enemyTarget1.position, centerPoint.position, 3.1f*Time.deltaTime);
            }

            if (centerPoint.position.z - 3.0f >= enemyTarget1.position.z && (centerPoint.position.x +0.8f>= enemyTarget1.position.x || centerPoint.position.x - 0.8f <= enemyTarget1.position.x))
            {
                isDidCollideTarget1 = true;
                Destroy(enemyTarget1.gameObject);
            }
        }        
    }
}
