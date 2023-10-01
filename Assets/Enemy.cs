using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public AudioSource audioSource;
    private void Start()
    {
        currentHealth = maxHealth;
       // gameObject.tag = "Enemy,Ground";
        //Debug.Log(gameObject.tag);
       
    }

    public void TakeDamage(int damageAmount)
    {
        Debug.Log("oach");
        audioSource.Play();
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Update()
    {
      //  Debug.Log("1");
    }
    void Die()
    {

        Destroy(gameObject);
    }
}
