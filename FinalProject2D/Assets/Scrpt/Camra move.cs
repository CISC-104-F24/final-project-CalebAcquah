using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraMove : MonoBehaviour
{
    public float followSpeed = 2f;
    public Transform traget;

    public float yOffset;

    public float xOffset;

    public bool faceRight;

    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      if(faceRight && Input.GetKey(KeyCode.D))
      {
        Flip();
      }
      else if(!faceRight && Input.GetKey(KeyCode.A))
      {
        Flip();
      }

      Vector3 newPros = new Vector3(traget.position.x + xOffset, traget.position.y + yOffset,-10f);  
      transform.position = Vector3.Slerp(transform.position, newPros,followSpeed*Time.deltaTime);

    }

      public void Flip()
    {
      xOffset *= -1;
      faceRight = !faceRight;
    }
}
