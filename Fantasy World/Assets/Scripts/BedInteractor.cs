using System.Collections.Generic;
using UnityEngine;

public class BedInteractor : MonoBehaviour
{

    // Sets a Max Distance the door can be seen from.
    float maxDistance = 2;
    static public bool hitBed = false;
    // Allows the Door Script to know if it's being Looked at right now

    void FixedUpdate()
    {

        // Will contain the information of which object the raycast hit
        RaycastHit hit;


        // Sends out a Raycast, if it hits something, is that something Tagged as a "Door" in the Editor
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance) && hit.collider.gameObject.CompareTag("Bed"))
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
            hitBed = true;
            }
        }
        else
        {
            hitBed = false;
        }
    }
}