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
            // �ӵ��˶����ȡ���������������������EnemyController��
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                // �Ե�������˺�
                enemy.TakeDamage(damage);
            }

            // �����ӵ�����
            
        }Destroy(gameObject);
    }
}
