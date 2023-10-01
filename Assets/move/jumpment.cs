using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpment : MonoBehaviour
{
    //这是第一种
    public float jumpForce = 5f;
    private int isJumping = 0;
    private Rigidbody2D rb;
    public GameObject mObject;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown("space") && isJumping <= 2)
        {
            Jump();
        }
    }

    void Jump()
    {
        isJumping++;

        rb.velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == mObject)
        {
            isJumping = 0;

        }
    }
}
