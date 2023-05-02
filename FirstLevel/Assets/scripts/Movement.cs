using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;

    //Awake is called after all objects are initialized. Called in Random order.
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); //will look for a componenton this GameObject (what the script is attached to) of type Rigidbody
    }

    // Update is called once per frame
    void Update()
    {
        //get inputs
        moveDirection = Input.GetAxis("Horizontal"); //scale of -1 -> 1

        //Move
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
    }
}
