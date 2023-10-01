using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

public class Movement1 : MonoBehaviour
{
    private bool onground=false;
    private Rigidbody2D rb;
    public float moveSpeed = 5f;
    public float maxSpeed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
 

    }
    void Update()

    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // 获取水平输入，-1代表左移，1代表右移

        Vector2 moveDirection = new Vector2(moveHorizontal, 0f); // 创建移动方向向量
        FixedUpdate();


        //if (onground)
            rb.AddForce(moveDirection * moveSpeed); // 施加力以改变物体的速度和移动方向
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onground = false;
        }
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onground = true;
        }
    }*/
    void FixedUpdate()
    {
        Vector2 currentVelocity = rb.velocity;
        float horizontalVelocity = currentVelocity.x;

        // 在水平方向上限制速度
        float limitedHorizontalVelocity = Mathf.Clamp(horizontalVelocity, -maxSpeed, maxSpeed);
        rb.velocity = new Vector2(limitedHorizontalVelocity, currentVelocity.y);
    }
}