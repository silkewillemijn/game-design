using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX1 : MonoBehaviour
{
    public AudioSource girlVoice1;
    GameObject girl;
    GameObject player;

    void Start()
    {
        girl = GameObject.Find("AGIA_anime_girl");
        player = GameObject.Find("First Person Player");
    }

    void OnTriggerEnter(Collider other) {
        girlVoice1.Play();
    }

    void playVanishingSound() {
        FindObjectOfType<AudioManager>().Play("VanishingSound");
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        girl.SetActive(false);
    }

    void Update() {
        // if distance between player en girl is smaller than 5, let her disappear
        if (girl.activeInHierarchy == true) {

            var distance = Vector3.Distance(girl.transform.position, player.transform.position);

            if (!girlVoice1.isPlaying && distance < 5) {
                playVanishingSound();
                //1 sec delay..?
                girl.SetActive(false);
            }
        }

        
    }
}
