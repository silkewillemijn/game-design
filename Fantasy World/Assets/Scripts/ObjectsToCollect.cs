using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToCollect : MonoBehaviour
{
    public static int objects = 0;
    public AudioSource girlvoice1;
    public AudioSource girlvoice2;
    public AudioSource girlvoice3;
    

    // Use this for initialization
    // void Awake()
    // {
    //     objects++;
    // }

    // Play the next audio track of the daughters' voice
    void PlayGirlVoiceTwo() {
        girlvoice2.Play();
    }

    void PlayGirlVoiceThree() {
        girlvoice3.Play();
    }
    
    // Update is called once per frame
    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            objects++;
        }
        
        if (gameObject == GameObject.Find("Poster 1")) { // and stop playing if next piece is collected and next sound starts?
            //stop previous audio
            girlvoice1.loop = false;
            girlvoice1.volume = 0;
            
            // play second audioclip...
            PlayGirlVoiceTwo();
            
        }

        if (gameObject == GameObject.Find("Poster 2")) { // and stop playing if next piece is collected and next sound starts?
            //stop previous audio
            girlvoice2.loop = false;
            girlvoice2.volume = 0;

            // play second audioclip...
            PlayGirlVoiceThree();
        }

        if (gameObject == GameObject.Find("Poster 3")) {
            girlvoice3.loop = false;
            girlvoice3.volume = 0;
        }
        
        gameObject.SetActive(false);
        
        // play sound        
        FindObjectOfType<AudioManager>().Play("PickingUpPoster");
    }
}