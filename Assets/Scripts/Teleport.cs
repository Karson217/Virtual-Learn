using System.Collections;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Security.AccessControl;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public GameObject player;
    public AudioClip[] audioClips;
    public bool hasplayed=false;
    public bool hasplayed2 = false;
    public AudioSource aud;


    public void TeleportPlayer()
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 4.5f, transform.position.z);
        StartCoroutine(Text());

    }


   

    IEnumerator Text()
    {
        aud.PlayOneShot(audioClips[0]);
        yield return new WaitForSeconds(15f);
        aud.PlayOneShot(audioClips[1]);
    }
}

