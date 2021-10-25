using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShootALT : MonoBehaviour
{
    //public Vector3 point = new Vector3(0.5f, 0.5f, 0);

    //Camera cam;

    // Start is called before the first frame update
   // void Start()
    //{

      //  cam = GetComponent<Camera>();
    //}

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
            if (hit.transform.gameObject.tag == "Door")
                if (Input.GetKeyDown("o"))

                {
                    hit.collider.gameObject.GetComponent<Animator>().Play("DoorSingle_Open");
                }

    }



}
