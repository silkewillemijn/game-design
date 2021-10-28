using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToCollect : MonoBehaviour
{
    public static int objects = 0;
    public AudioSource girlvoice2;
    

    // Use this for initialization
    void Awake()
    {
        objects++;
    }

    // Play the next audio track of the daughters' voice
    void PlayGirlVoice() {
        girlvoice2.Play();
    }
    
    // Update is called once per frame
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "First Person Player")
        {
            objects--;
        }
        
        if (gameObject == GameObject.Find("Poster 1")) { // and stop playing if next piece is collected and next sound starts?
            PlayGirlVoice(); 
            Debug.Log("poster 1 collected");
        }

        if (gameObject == GameObject.Find("Poster 2")) { // and stop playing if next piece is collected and next sound starts?
            // play second audioclip...

            //stop previous one?
            girlvoice2.loop = false;
        }
        
        gameObject.SetActive(false);
        
        // play sound        
        FindObjectOfType<AudioManager>().Play("PickingUpPoster");
    }
}