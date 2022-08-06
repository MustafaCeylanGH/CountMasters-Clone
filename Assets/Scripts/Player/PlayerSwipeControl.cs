using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwipeControl : MonoBehaviour
{
    private float swipeSpeed = 0.3f;
    private float lastFingerPositionX;
    private float moveX;
    private float moveXValue;
    private int moveXValueMax = 1;

    private void Update()
    {
        InputControl();
        Swipe();
    }

    private void InputControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastFingerPositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            moveX = Input.mousePosition.x - lastFingerPositionX;
            lastFingerPositionX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            moveX = 0.0f;
        }
    }

    private void BoundaryMoveXValue()
    {
        moveXValue = moveX * swipeSpeed * Time.deltaTime;
        moveXValue = Mathf.Clamp(moveXValue, -moveXValueMax, moveXValueMax);
    }

    private void Swipe()
    {
        BoundaryMoveXValue();
        transform.Translate(moveXValue, 0, 0);
    }
}
