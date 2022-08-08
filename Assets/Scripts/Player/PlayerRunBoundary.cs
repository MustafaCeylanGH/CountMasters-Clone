using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunBoundary : MonoBehaviour
{
    private float xBoundary;
    private float xBoundaryValue = 4.5f;
    void Update()
    {
        CheckBoundary();
    }

    private void CheckBoundary()
    {
        xBoundary = Mathf.Clamp(transform.position.x, -xBoundaryValue, xBoundaryValue);
        transform.position = new Vector3(xBoundary, transform.position.y, transform.position.z);
    }
}
