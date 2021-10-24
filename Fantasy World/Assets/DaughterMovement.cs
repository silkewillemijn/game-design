using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaughterMovement : MonoBehaviour
{
    Animator animator;
    GameObject girl;
    GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        girl = this.gameObject;
        player = GameObject.Find("First Person Player");
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(girl.transform.position, player.transform.position);
        //Debug.Log(distance);

        //if player is at certain distance of girl, the trigger will be activated
        if (distance < 10) {
            animator.SetTrigger("closeEnough");
        }
    }
}
