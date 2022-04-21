using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesMovemnt : MonoBehaviour
{
    public float speed;


    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -1f * speed * Time.deltaTime);

    }
   
}
