using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D myBody;

    public float jumpPower = 10;

    public float speed = 10;

    public int  maxHealth = 150;

    public int currentHealth;

    public HealthBar healthBar;

    public Animator anime;

    public int animeSpeed;

    public bool faceRight;

    public bool isJumping;

    public int animepunch = 1;

    public bool isMoving;

    public float doubleJump = 2;

    public bool isAir;

    private float timer;
  
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>(); 

        currentHealth = maxHealth;

        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(speed);
        Debug.Log(doubleJump);
        bool right = Input.GetKey(KeyCode.D);
        bool left =  Input.GetKey(KeyCode.A);
        bool jump = Input.GetKeyDown(KeyCode.Space);
        bool punch = Input.GetKeyDown(KeyCode.E);
        bool speedUp = Input.GetKeyDown(KeyCode.LeftShift);

        if(jump && isJumping == false)
        {
          if(doubleJump == 2 || doubleJump == 1)
          {
            anime.SetBool("Jumping", true);
            myBody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            doubleJump -= 1;
          }

        }

        else if(right || right && speedUp) 
        {
         
            anime.SetInteger("Runing", 1);
            transform.position = transform.position + transform.right * speed * Time.deltaTime;
            isMoving = true;

              if(faceRight)
                { 
                   
                     Flip();
                   
                }
               if(isAir)
                {
                Animation(); 
                }
                if(right && speedUp)
                {
                  speed = 20;
                }
               
            
        }
        else if(left)
        {
            anime.SetInteger("Runing", 1);
            transform.position = transform.position + transform.right * speed * Time.deltaTime;
            isMoving = true;

            if(!faceRight)
                { 
                    
                    
                     Flip();
                   
                }
            if(isAir)
                {
                Animation(); 
                }
                if(left && speedUp)
                {
                  speed = 20;
                }
               
        }
     
        else if(!right)
        {
            isMoving = false;
            speed = 10;
            Animation();
        }
        else if(!left)
        {
            isMoving = false;
            speed = 10;
            Animation();
        }

        timer += Time.deltaTime; 
    }


    public void SetDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

   private void OnCollisionEnter2D(Collision2D collision)
   {
    if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Mini Boss" )
    {
       SetDamage(20);
         anime.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
          anime.SetBool("Death", true);
          speed = 0;
          jumpPower = 0;
        }
    }
    Debug.Log(collision.gameObject.tag);
     if(collision.gameObject.tag == "Acid")
    {
      
       SetDamage(60);
         anime.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
          anime.SetBool("Death", true);
          speed = 0;
          jumpPower = 0;
        }


    }

     if(collision.gameObject.tag == "Traps")
    {
        SetDamage(30);
        anime.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
          anime.SetBool("Death", true);
          speed = 0;
          jumpPower = 0;
        }
      

    }
  

      if(collision.gameObject.CompareTag("Floor"))
      {
        anime.SetBool("Jumping", false);
        isAir = false;
        isJumping = false;
        if(doubleJump == 0)
        {
        doubleJump = 2;
        }
      } 
  

   }


    private void OnCollisionStay2D(Collision2D collision)
    {
      if(collision.gameObject.tag == "Acid")
    {
      if(timer > 5)
      {
      SetDamage(5);
         anime.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
          anime.SetBool("Death", true);
          speed = 0;
          jumpPower = 0;
        }
      }
    }
      
      
      
     if(collision.gameObject.tag == "Traps")
    {
      if(timer > 5)
      {
        SetDamage(2);
        anime.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
          anime.SetBool("Death", true);
          speed = 0;
          jumpPower = 0;
        }

      }
    }
    }

   public void OnCollisionExit2D(Collision2D collision)
   {

      if(collision.gameObject.CompareTag("Floor"))
      {
        anime.SetBool("Jumping", true);
        isAir = true;
        isJumping = false;
        if(doubleJump == 0)
        {
        doubleJump = 2;
        }

      }
   }

     private void Animation()
    {
        anime.SetInteger("Runing", animeSpeed);
        animeSpeed *= 0 ;
        anime.SetInteger("Runing", animeSpeed); 
    }

   public void Flip()
    {
      // Vector3 currentScale = gameObject.transform.localScale;
      // currentScale.x *= -1;
      // gameObject.transform.localScale = currentScale;
      
      faceRight = !faceRight;
      transform.Rotate(0f,180f,0f);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {

    if(collider.gameObject.tag == "Mini Boss damage")
    {
         SetDamage(50);
         anime.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
          anime.SetBool("Death", true);
          speed = 0;
          jumpPower = 0;
        }
    
    }

    }
   




    
    
   
}
