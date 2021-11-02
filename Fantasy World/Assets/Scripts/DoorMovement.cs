using UnityEngine;
using System.Collections;

public class DoorMovement : MonoBehaviour
{
    float maxDistance = 4;
    //static public bool hitDoor = false;
    public Animation DoorSingle_Close;
    public Animation DoorSingle_Open;

    public bool doorOpen = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (doorOpen == false)
                {
                    OpenDoor();
                }
                else if (doorOpen == true)
                {
                    CloseDoor();
                }
            }
        }
    }

    public void OpenDoor()
    {
        DoorSingle_Open.Play();
        doorOpen = true;
    }

    public void CloseDoor()
    {
        DoorSingle_Close.Play();
        doorOpen = false;
    }
}