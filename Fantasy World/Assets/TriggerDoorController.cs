using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    //public Animator myDoor = null;

    //public bool openTrigger = false;
    //public bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (OpenTrigger)
            {
                myDoor.Play("DoorSingle_Open", 0, 0.0f);
                gameObject.SetActive(false);
            }

            else if (closeTrigger)
            {
                myDoor.Play("DoorSingle_Close", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}

