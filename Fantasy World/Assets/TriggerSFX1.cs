using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX1 : MonoBehaviour
{
    public AudioSource girlVoice1;

    void OnTriggerEnter(Collider other) {
        girlVoice1.Play();
    }
}
