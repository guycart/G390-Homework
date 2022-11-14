using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public int health = 10;

   public float speed = 5f;

   public int lootDrop = 5;

   public Vector3 targetLocation;

   PlayerScript playerReference;

    private void Start() {
    playerReference = FindObjectOfType<PlayerScript>();
   }

   public void TakeDamage(int damageValue)
   {
    //reduce enemy health
    health -= damageValue;
    //check if health <= 0 : if truel -> call teh Die()
    if(health <= 0)
    {
        Die();
    }
   }
   
   public void Die()
   {
    print("enemy has died");
    playerReference.AddCurrency(lootDrop);
    playerReference.AddXP(1);
    Destroy(gameObject);
   }

   private void MoveToTarget()
   {
    Transform enemyTransform = transform;
    //get the direction to the target
    Vector3 targetDirection = (targetLocation - transform.position).normalized;
    //move along that direction at a certain speed
    enemyTransform.position = targetDirection * speed * Time.deltaTime;
   }
}
