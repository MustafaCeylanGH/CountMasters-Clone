using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private Transform enemyTarget1;
    [SerializeField] private Transform enemyTarget2;
    [SerializeField] private Transform enemyTarget3;
    [SerializeField] private Transform enemyTarget4;

    [SerializeField] private bool isEnemy1;
    [SerializeField] private bool isEnemy2;
    [SerializeField] private bool isEnemy3;
    [SerializeField] private bool isEnemy4;



    private void FixedUpdate()
    {
        FollowCenterPoint(enemyTarget1,isEnemy1);
        FollowCenterPoint(enemyTarget2, isEnemy2);
        FollowCenterPoint(enemyTarget3, isEnemy3);
        FollowCenterPoint(enemyTarget4, isEnemy4);
    }

    private void FollowCenterPoint(Transform enemyTarget,bool isEnemyTargetNumber)
    {
        if (isEnemyTargetNumber)
        {
            transform.position = Vector3.Lerp(transform.position, enemyTarget.position, 2.0f * Time.deltaTime);
        }        
    }
}
