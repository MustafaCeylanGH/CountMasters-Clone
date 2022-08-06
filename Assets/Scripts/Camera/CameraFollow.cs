using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float lerpValue;
    private Vector3 offset;
    private Vector3 targetPos;

    private void Start()
    {
        offset.z = target.position.z - transform.position.z;
    }
    private void LateUpdate()
    {
        CameraFollowControl();
    }

    private void CameraFollowControl()
    {
        transform.position = Vector3.Lerp(transform.position, TargetPos(), lerpValue);
    }

    private Vector3 TargetPos()
    {
        targetPos = new Vector3(transform.position.x, transform.position.y, target.position.z - offset.z);
        return targetPos;
    }
}
