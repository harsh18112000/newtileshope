using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    public Rigidbody ballrigid;
   
    public float force ;

    public void Update()
    {
    if(Input.GetMouseButton(0))
        {
            transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 0, 0);
        }
    }


void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Cube"))
        {
            Debug.Log("touch");

          ballrigid.velocity = new Vector3(0, force, 0);
            
        }

       
    }
    
    
}

