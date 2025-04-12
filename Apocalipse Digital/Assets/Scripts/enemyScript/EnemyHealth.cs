using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Enemy enemy;
    private void Start()
    {
        enemy=GetComponent<Enemy>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Weapon")){
            enemy.healthpoints-=2f;
            if(enemy.healthpoints <=0){
                Destroy(gameObject);
            }
        }
    }

}
