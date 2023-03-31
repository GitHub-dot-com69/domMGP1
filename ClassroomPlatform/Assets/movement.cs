using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float jumpForce;
    public float moveSpeed = 6;
    public float moveDirection;
    public Transform ceilingCheck;
    public Transform groundCheck;
    public LayerMask groundObjects;
    public int maxJumpCount;
    public int jumpCount;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool isJumping;
    private bool isGrounded;

    private void Start()
    {
        jumpCount = maxJumpCount;
    }

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Get Inputs
        ProcessInputs();

        //Animate
        Animate();
    }

    //Better for handling physics, can be called multiple times per update frame.
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 2f, groundObjects);
        if (isGrounded)
        {
            jumpCount = maxJumpCount;
        }
        //Move
        MoveRB();
    }


    private void MoveRB()
    {
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
        if(isJumping && jumpCount > 0)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumpCount--;
        }
         isJumping = false;

        float timeReset = Time.time;
        if(timeReset >= timeReset + 5)
        {
            maxJumpCount = 1;
        }
    }

        private void Animate()
        {
            if (moveDirection > 0 && !facingRight)
            {
                flipcharacter();
            }
            else if (moveDirection < 0 && facingRight)
            {
                flipcharacter();
            }
        }
       
    private void ProcessInputs()
    {
        moveDirection = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            isJumping = true;
        }
    }

    private void flipcharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    IEnumerator PowerUpSpeed()
    {
        moveSpeed = 9;
        yield return new WaitForSeconds(5);
        moveSpeed = 5;
    }

    public void SpeedPowerUp()
    {
        StartCoroutine(PowerUpSpeed());
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "MovingPlatform")
        {
            transform.parent = col.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "MovingPlatform")
        {
            transform.parent = null;
        }
    }
}
