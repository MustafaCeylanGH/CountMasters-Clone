using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    private Transform centerPoint;
    

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
        transform.position = Vector3.Lerp(transform.position, centerPoint.position, 0.2f);
    }
    
}
