using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenHorrorDoor : MonoBehaviour
{
    public AudioSource doorSound;
    // Start is called before the first frame update
    void Update()
    {
        if (DoorInteractor.hitDoor == true)
        {
            this.GetComponent<Animator>().SetBool("open", true); //open door
            doorSound.Play();
            if (doorSound.isPlaying  == false) {
                doorSound.volume = 0;
            }

        }

        //if (DoorInteractor.hitDoor == false)
        //{
        //    this.GetComponent<Animator>().SetBool("open", false); //close door
        //}
    }
}

