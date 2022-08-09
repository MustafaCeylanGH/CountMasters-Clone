using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [SerializeField] private Transform centerPoint;

    [SerializeField] private Transform enemyTarget1;
    [SerializeField] private Transform enemyTarget2;

    private bool isDidCollideTarget1;
    private bool isDidCollideTarget2;
    

    private void FixedUpdate()
    {
        EnemyTarget(enemyTarget1,isDidCollideTarget1);
        EnemyTarget(enemyTarget2, isDidCollideTarget2);
    }

    private void EnemyTarget(Transform enemyTarget,bool isDidCollideTarget)
    {
        if (!isDidCollideTarget && enemyTarget!=null)
        {
            if (centerPoint.position.z + 8.0f >= enemyTarget.position.z)
            {                
                centerPoint.position = Vector3.MoveTowards(centerPoint.position, enemyTarget.position, 3.0f*Time.deltaTime);
                enemyTarget.position = Vector3.MoveTowards(enemyTarget.position, centerPoint.position, 2.5f*Time.deltaTime);
            }

            if (centerPoint.position.z - 3.0f >= enemyTarget.position.z && (centerPoint.position.x -2.5f>= enemyTarget.position.x || centerPoint.position.x + 2.5f <= enemyTarget.position.x))
            {                
                isDidCollideTarget1 = true;
                isDidCollideTarget2 = true;
            }
        }        
    }
}
