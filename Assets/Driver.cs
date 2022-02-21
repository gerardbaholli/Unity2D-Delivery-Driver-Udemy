using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 120f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

    private void FixedUpdate()
    {
        float steerAmount = Input.GetAxis("Horizontal") * Time.deltaTime * steerSpeed;
        float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }

        if (collision.tag == "Bump")
        {
            moveSpeed = slowSpeed;
        }
    }

}
