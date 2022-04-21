using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPause : MonoBehaviour
{
    
    public Rigidbody Freez;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pause(){
        Freez.constraints = RigidbodyConstraints.FreezeAll;
    }
    public void play(){
        Freez.constraints = RigidbodyConstraints.None;
    }
}
