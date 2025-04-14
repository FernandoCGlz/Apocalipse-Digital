using System.Collections;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Enemy enemy;
    public bool isDamaged;
    public GameObject  deathEffect;
    private void Start()
    {
        enemy=GetComponent<Enemy>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Weapon") &&!isDamaged){
            enemy.healthpoints-=2f;
            StartCoroutine(Damager());
            if(enemy.healthpoints <=0){
                Instantiate(deathEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
    IEnumerator Damager()
{
    isDamaged = true;
    yield return new WaitForSeconds(0.5f);
    isDamaged = false;

}

}
