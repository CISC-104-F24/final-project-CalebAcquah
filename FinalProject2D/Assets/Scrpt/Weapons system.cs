using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponssystem : MonoBehaviour
{
    public int weaponAccess = 0;

    public Animator animator;
     
    public Transform throwPonit;

    public GameObject batPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    bool punch = Input.GetKeyDown(KeyCode.E);
    

    // if(weaponAccess == 1)
    // {
    // bool Bat = Input.GetKey(KeyCode.E);
    // }
    // else if(weaponAccess == 2)
    // {
    // bool kiBlast = Input.GetKeyDown(KeyCode.Q);
    // }

    if(punch)
    {
     animator.SetTrigger("Punching 0");
      
    }
    
        if(Input.GetButtonDown("Fire1"))
    {
        Shoot();
    }

}
  void Shoot()
    {
        Instantiate(batPrefab, throwPonit.position, throwPonit.rotation);
    }


}