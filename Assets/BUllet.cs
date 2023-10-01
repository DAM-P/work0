using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 10;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // 从敌人对象获取敌人组件（假设敌人组件是EnemyController）
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                // 对敌人造成伤害
                enemy.TakeDamage(damage);
            }

            // 销毁子弹对象
            
        }Destroy(gameObject);
    }
}
