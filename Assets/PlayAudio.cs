using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().PlayDelayed(12.0f);


    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
