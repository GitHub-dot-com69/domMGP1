using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnD : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("A key was pressed");
            rb.velocity = (Vector2.left);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("D key was pressed");
            rb.velocity = (Vector2.right);
        }
    }
}
