using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed;
    [SerializeField] float moveSpeed;

    private void FixedUpdate()
    {
        float steerAmount = Input.GetAxis("Horizontal") * Time.deltaTime * steerSpeed;
        float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

}
