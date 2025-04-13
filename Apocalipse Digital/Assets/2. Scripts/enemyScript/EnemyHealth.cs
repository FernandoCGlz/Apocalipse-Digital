using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Enemy enemy;
    public GameObject  deathEffect;
    private void Start()
    {
        enemy=GetComponent<Enemy>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Weapon")){
            enemy.healthpoints-=2f;
            if(enemy.healthpoints <=0){
                Instantiate(deathEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }

}
