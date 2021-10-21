using System.Collections.Generic;
using UnityEngine;

public class DoorInteractor : MonoBehaviour
{

    // Sets a Max Distance the door can be seen from.
    float maxDistance = 4;
    static public bool hitDoor = false;
    // Allows the Door Script to know if it's being Looked at right now

    void FixedUpdate()
    {

        // Will contain the information of which object the raycast hit
        RaycastHit hit;


        // Sends out a Raycast, if it hits something, is that something Tagged as a "Door" in the Editor
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance) && hit.collider.gameObject.CompareTag("Door"))
        {

            //if (Input.GetKeyDown(KeyCode.Space))
            //{
            hitDoor = true;
            //}
        }
        else
        {
            hitDoor = false;
        }
    }
}