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
        float moveHorizontal = Input.GetAxis("Horizontal"); // ��ȡˮƽ���룬-1�������ƣ�1��������

        Vector2 moveDirection = new Vector2(moveHorizontal, 0f); // �����ƶ���������
        FixedUpdate();


        //if (onground)
            rb.AddForce(moveDirection * moveSpeed); // ʩ�����Ըı�������ٶȺ��ƶ�����
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

        // ��ˮƽ�����������ٶ�
        float limitedHorizontalVelocity = Mathf.Clamp(horizontalVelocity, -maxSpeed, maxSpeed);
        rb.velocity = new Vector2(limitedHorizontalVelocity, currentVelocity.y);
    }
}