using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLogic : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;
    void Start()
    {
        
    }

    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical")* moveSpeed;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, -steerAmount);
    }
}
