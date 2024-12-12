using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackWheninrange : MonoBehaviour
{
    public Animator animator;

     public GameObject shockPrefab;

     public Transform attackPonit;

     public bool faceRight;

     private Transform playerPos;


    
    // Start is called before the first frame update
    void Start()
    {
      playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();     
    }

    // Update is called once per frame
    void Update()
    {    

    }

   private void OnTriggerEnter2D(Collider2D collision)
   {
      
    if(collision.gameObject.tag == "Player"   ) 
    {
       animator.SetTrigger("Attack");
       Rumbling();
    }

    if(collision.gameObject.tag == "Player")
    {
       animator.SetTrigger("Attack");
    }

   }

  
      void Rumbling()
    {
      
        Instantiate(shockPrefab, attackPonit.position, attackPonit.rotation);
    }
}
