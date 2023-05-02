using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeHeHe : MonoBehaviour
{
    private int speed = 10;
    public Rigidbody2D rb;
    public Vector3 xMove;
    public float direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        xMove = new Vector3(direction, 0 * speed);
    }

    private void FixedUpdate()
    {
        rb.velocity = xMove * speed;
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            direction = -1f;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            direction = 1f;
        }

        else
        {
            direction = 0f;
        }
    }
}
