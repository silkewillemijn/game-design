using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX2b : MonoBehaviour
{
    public AudioSource girlVoice2b;
    public AudioSource girlVoice2a;
    GameObject girl;
    GameObject player;
    GameObject posterpiece;

    void Start()
    {
        girl = GameObject.Find("AGIA_anime_girl 2");
        player = GameObject.Find("First Person Player");
        posterpiece = GameObject.Find("Poster 2");
        posterpiece.SetActive(false);
    }

    void OnTriggerEnter(Collider other) {
        // if (!girlVoice2a.isPlaying) { // zorg dat audio niet overlapt
        girlVoice2b.Play();
        // }
    }

    void playVanishingSound() {
        FindObjectOfType<AudioManager>().Play("VanishingSound");
    }

    // IEnumerator ExecuteAfterTime(float time)
    // {
    //     yield return new WaitForSeconds(time);
    //     girl.SetActive(false);
    //     posterpiece.SetActive(true);
    // }

    void Update() {
        // if distance between player en girl is smaller than 5, let her disappear
        if (girl.activeInHierarchy == true) {

            var distance = Vector3.Distance(girl.transform.position, player.transform.position);

            if (!girlVoice2b.isPlaying && distance < 5) {
                playVanishingSound();
                //1 sec delay..?
                girl.SetActive(false);
                posterpiece.SetActive(true);
            }
        }

        
    }
}
