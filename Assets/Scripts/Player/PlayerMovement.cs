using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        transform.Translate(0,0, moveSpeed * Time.deltaTime);
    }
}
