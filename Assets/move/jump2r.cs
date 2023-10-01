using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump2r : MonoBehaviour
{
    //这是第二种
    public float jumpForce = 10f;
    public int maxJumpCount = 3;
    public AudioSource audioSource;
    private Rigidbody2D rb;
    private int jumpCount = 0;
    private PlayerState currentState;
    
    private enum PlayerState
    {
        Grounded,
        Jumping
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentState = PlayerState.Grounded;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentState == PlayerState.Grounded && jumpCount < maxJumpCount)
        {
            //         rb.velocity = Vector2.up * jumpForce;
            audioSource.Play();
            float moveHorizontal = Input.GetAxis("Horizontal");
            Vector2 moveDirection = new Vector2(moveHorizontal, jumpForce); // 创建移动方向向量
            

            rb.AddForce(moveDirection,ForceMode2D.Impulse ); // 施加力以改变物体的速度和移动方向
            jumpCount++;
            if(jumpCount==maxJumpCount)currentState = PlayerState.Jumping;
  
        }
    }

  /*  public void StartJumping(AudioSource audioSource)
    {
        
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        
    }*/
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")|| collision.gameObject.CompareTag("Enemy"))
        {
            jumpCount = 0;
            currentState = PlayerState.Grounded;
        }
    }
}

