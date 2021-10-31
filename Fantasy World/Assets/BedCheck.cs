using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BedCheck : MonoBehaviour
{
    static public bool hitBed = false;
    // Sets a Max Distance the door can be seen from.
    float maxDistance = 2;

    void FixedUpdate()
    {
        // Will contain the information of which object the raycast hit
        RaycastHit hit;
   


        // Sends out a Raycast, if it hits something, is that something Tagged as a "Door" in the Editor
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance) && hit.collider.gameObject.CompareTag("Bed"))
        {
            //show text and if space, continue warping+transition
            hitBed = true;
        }
        else
        {
            hitBed = false;
        }
    }
}
