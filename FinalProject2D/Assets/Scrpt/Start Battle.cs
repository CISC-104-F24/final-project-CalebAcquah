using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartBattle : MonoBehaviour
{
    public Animator animator;

    public bool battle = false;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        // if(collider.gameObject.tag == "Player" )
        // {
        //   battle = true;
        //   Debug.Log("Start Battle");
        //   animator.SetBool("Start", true);
        //   Destroy(gameObject);
        // }

        if(collider.gameObject.tag == "Player")
        {
            animator.SetTrigger("Start");
        }
    }
}
