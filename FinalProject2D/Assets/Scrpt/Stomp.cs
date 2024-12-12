using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stomp : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
     rb.velocity =  transform.right * speed;    
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
       
    }


  
}
