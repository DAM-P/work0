using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MeleeAttack : MonoBehaviour
{
    public Transform attackPoint;               
    public LayerMask enemyLayers;               // µÐÈËËùÔÚµÄÍ¼²ã
    public float attackRange = 0.5f;            // ¹¥»÷·¶Î§
    public int attackDamage = 10;               // ¹¥»÷ÉËº¦
    private Transform ob;
    //private Animator animator;                  // ¶¯»­¿ØÖÆÆ÷
    
    void Start()
    {
        ob = transform;
       // animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
       // Debug.Log("aaa");
            Attack();
        }
    }

    void Attack()
    {   //attackPoint.transform.position=new Vector3(ob.position.x+2f, ob.position.y, ob.position.z);
 
        // animator.SetTrigger("attack");


        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
      //  Debug.Log(hitEnemies.Length);

        foreach (Collider2D enemy in hitEnemies)

        {
            Enemy enemyComponent = enemy.GetComponent<Enemy>();


            if (enemyComponent != null)
            {
                
                enemyComponent.TakeDamage(attackDamage);
               
            }

        }
    }

    
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
