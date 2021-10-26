using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    public Vector2 movement;
    public float gravity = -9.81f;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        velocity.y += gravity * Time.deltaTime;
    }
    void MoveFish(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);

       
    }
    void moveCharacter(Vector2 direction)
    {
        rb.velocity = direction * speed;

    }

}
