using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDrillPressTut : MonoBehaviour
{
    AudioSource drillpressintro;

    
    // Start is called before the first frame update
    void Start()
    {

        drillpressintro = GetComponent<AudioSource>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }
void OnTriggerEnter(Collider collision)
    {
      
        
       

            drillpressintro.Play();

            
        
        

    }
}

