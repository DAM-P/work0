using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RUNN : MonoBehaviour
{
    public jump2r jumpingScript;
    public AudioSource audioSource; // 引用AudioSource组件
    public GameObject mObject;
    private Rigidbody2D rb; // 引用刚体组件
    private bool yes;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpingScript = GetComponent<jump2r>();

    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)){
            yes = false;
            audioSource.Stop();
        }
        if(rb.velocity.magnitude == 0) {
            audioSource.Stop();
        }
     //   Debug.Log(rb.velocity);
        if (rb.velocity.magnitude > 0 && yes)
        {
            
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
           // Debug.Log(collision.gameObject.name);
            yes = true;

        }
        
    }
}

