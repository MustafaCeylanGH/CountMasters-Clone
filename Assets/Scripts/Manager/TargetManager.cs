using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    [SerializeField] private Transform centerPoint;

    [SerializeField] private Transform enemyTarget1;
    [SerializeField] private Transform enemyTarget2;
    [SerializeField] private Transform enemyTarget3;
    [SerializeField] private Transform enemyTarget4;

    private PlayerSwipeControl playerSwipeControl;

    private void Awake()
    {
        playerSwipeControl = FindObjectOfType<PlayerSwipeControl>();
    }

    private void FixedUpdate()
    {
        EnemyTarget(enemyTarget1);
        EnemyTarget(enemyTarget2);
        EnemyTarget(enemyTarget3);
        EnemyTarget(enemyTarget4);
    }

    private void EnemyTarget(Transform enemyTarget)
    {
        if (enemyTarget!=null)
        {
            if (centerPoint.position.z + 7.0f >= enemyTarget.position.z)
            {
                playerSwipeControl.canUseSwipe = false;
                centerPoint.position = Vector3.MoveTowards(centerPoint.position, enemyTarget.position, 2.8f*Time.deltaTime);
                enemyTarget.position = Vector3.MoveTowards(enemyTarget.position, centerPoint.position, 2.8f*Time.deltaTime);
            }           
        }        
    }
}
