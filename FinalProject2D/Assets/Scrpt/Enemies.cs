using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public int health = 100;
    int currentHealth;
   

    public GameObject bat;

    public bool isBoss;

    public bool isFinalBoss;
    // Start is called before the first frame update
    void Start()
    {
       currentHealth = health; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


       private void TakeDamage(int damage)
    {
        currentHealth -= damage;
       
    }



      private void OnTriggerEnter2D(Collider2D hit)
      {
        if(hit.gameObject.tag == "Bat")
        {
            TakeDamage(20);

            if(currentHealth <= 0)
            {
                Destroy(gameObject);
            }
        }
        
      }

      


}
