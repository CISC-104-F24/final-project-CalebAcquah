using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyeball : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player-Dummy");
        
    }

    // Update is called once per frame
    void Update()
    {
      
        eyeFollow();
    }


    private void eyeFollow()
    {
          Vector3 playerPros = player.transform.position;

        Vector2 dir = new Vector2(playerPros.x - transform.position.x, playerPros.y - transform.position.y);

        transform.up = dir;
    }
}
