using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX2 : MonoBehaviour
{
    public AudioSource girlVoice2a;

    void OnTriggerEnter(Collider other) {
        girlVoice2a.Play();
    }
}
