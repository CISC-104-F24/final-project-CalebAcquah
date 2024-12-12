using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Enemyshot : MonoBehaviour
{
    public Transform bulletpros;
    public GameObject bullet;

    private float timer;

     private GameObject player;
    // Start is called befor  e the first frame update
    void Start()
    {
     player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);
        

       
            
            timer += Time.deltaTime; 

            if(timer > 3)
            {
                Debug.Log(distance);
                timer = 0;
                shoot();
            }
        
        
    }

    private void shoot()
    {
        Instantiate(bullet, bulletpros.position, Quaternion.identity);
    }
}
