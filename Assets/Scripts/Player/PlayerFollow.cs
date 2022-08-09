using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    private Transform centerPoint;
    private Vector3 targetCenterPointPos;
    

    private void Awake()
    {
        centerPoint = GameObject.Find("CenterPoint").transform;
    }

    private void FixedUpdate()
    {
        FollowCenterPoint();
    }

    private void FollowCenterPoint()
    {
        transform.position = Vector3.Lerp(transform.position,FollowCenterPointPosition(), 6.0f*Time.deltaTime);
    }

    private Vector3 FollowCenterPointPosition()
    {
        targetCenterPointPos = new Vector3(centerPoint.position.x, transform.position.y, centerPoint.position.z);
        return targetCenterPointPos;
    }
    
}
