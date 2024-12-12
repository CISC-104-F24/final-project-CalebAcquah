using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class miniBoss : MonoBehaviour
{
    public bool faceRight;
    private Transform playerPos;

    public PlayerMove playerMove;

    public int  maxHealth = 500;
    public int currentHealth;
    public BossHealth bossHealth;

    public Animator animator;

    public StartBattle start;
    // Start is called before the first frame update
    void Start()
    {
     playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();   

      currentHealth = maxHealth;

      bossHealth.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    { 
         
            if(transform.position.x < playerPos.position.x && faceRight)
            {
            Flip();   
            }
            else if(transform.position.x > playerPos.position.x && !faceRight)
            {
            Flip();   
            }
            
    }

     private void OnTriggerEnter2D(Collider2D collider)
    {

    if(collider.gameObject.tag == "Bat" )
    {
         SetDamage(10);
         Debug.Log(currentHealth);


        if(currentHealth <= 0)
        {
          animator.SetBool("Death", true);
          currentHealth = 0;
        }
        
    }
   

    }


      public void Flip()
    {
  
      transform.Rotate(0f,180f,0f);
      faceRight = !faceRight;
    }


      public void SetDamage(int damage)
    {
        currentHealth -= damage;

        bossHealth.SetHealth(currentHealth);
    }

    
         
    

    

  

    


}
