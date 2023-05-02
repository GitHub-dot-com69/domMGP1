using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollizion : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool Ground = true;
    public bool Rock = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("You have hit the Ground");
        }

        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("You hit a Rock");
        }
    }
}
