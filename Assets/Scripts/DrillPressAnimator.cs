using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public class DrillPressAnimator : MonoBehaviour
{
    public AudioClip[] audiClip;
    public AudioSource audi;

    
    public void On_Button()
    {   
        GameObject drillpress = GameObject.Find("Drill Press");
        Animator AM = drillpress.GetComponent<Animator>();

        bool drill_on = AM.GetBool("Drill On");
        
        if(drill_on)
        {
            AM.SetBool("Drill On", false);
        } else{
            AM.SetBool("Drill On", true);
        }
    }

    public void Handle(){
        GameObject drillpress = GameObject.Find("Drill Press");
        Animator AM = drillpress.GetComponent<Animator>();

        bool incorrect = AM.GetBool("Incorrect");
        bool drill_on = AM.GetBool("Drill On");
        if(drill_on){
            if(incorrect) {
            AM.SetBool("Incorrect", false);
            AM.SetTrigger("Handle");
            audi.PlayOneShot(audiClip[0]);
            

            
        }
        else{
            AM.SetBool("Incorrect", true);
            AM.SetTrigger("Handle");
            audi.PlayOneShot(audiClip[1]);
            

        }
        }
        
    }
}
