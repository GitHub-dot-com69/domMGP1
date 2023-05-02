using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    //creates a box to store our sprite renderer information
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        //sets the sprite renderer information to what inforation is in the component
        spriteRenderer = GetComponent<SpriteRenderer>();
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

            //acess the color ofnsprite and sets the valuse of the color to blue
            spriteRenderer.color = Color.blue;
        }

        if (collision.gameObject.tag == "Rock")
        {
            Debug.Log("You hit a Rock");
        }
    }
}