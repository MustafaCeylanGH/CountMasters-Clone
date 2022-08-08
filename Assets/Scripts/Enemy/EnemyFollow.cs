using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private Transform enemyTarget1;


    private void Awake()
    {
        enemyTarget1 = GameObject.Find("EnemyTarget1").transform;
    }

    private void FixedUpdate()
    {
        FollowCenterPoint();
    }

    private void FollowCenterPoint()
    {
        transform.position = Vector3.Lerp(transform.position, enemyTarget1.position, 2.0f*Time.deltaTime);
    }
}
