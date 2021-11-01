using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster2Appearance : MonoBehaviour
{
    GameObject girl;
    GameObject player;
    GameObject posterpiece;

    void Start()
    {
        girl = this.gameObject;
        player = GameObject.Find("First Person Player");
        
        posterpiece = GameObject.Find("Poster 2");
        if (posterpiece.activeInHierarchy == true) { 
            posterpiece.SetActive(false);
        }
    }

    void playVanishingSound() {
        FindObjectOfType<AudioManager>().Play("VanishingSound");
    }

    void Update() {
        // if distance between player en girl is smaller than 5, let her disappear
        if (girl.activeInHierarchy == true) {

            var distance = Vector3.Distance(girl.transform.position, player.transform.position);

            if (distance < 8) {
                playVanishingSound();
                //1 sec delay..?
                girl.SetActive(false);
                posterpiece.SetActive(true);
            }
        }

        
    }
}
