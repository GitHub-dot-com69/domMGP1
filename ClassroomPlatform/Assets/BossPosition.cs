using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPosition : MonoBehaviour
{
    public float speed;
    public float attackRange;
    //create a box to store information (position, rotaion, scale)
    Transform player;
    PlayerManager playerManager;
    //store if our boss flip or not settting the value to false
    public bool isFlipped = false;
    //create a variable for our boss's health
    public int bossHealth = 10;
    //create a series of bools to check and set our phases
    public bool Phase2 = false;
    public bool Phase3 = false;
    public bool isDeath = false;
    public Transform shotLocation;
    public GameObject projectile;
    public GameObject projectile2;
    public float timer;
    public float waitingTime;

    // Start is called before the first frame update
    void Start()
    {
        //set our referemce for out PlayerManager
        playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    private void Update()
    {
        //create a series of if else staements that will check to see 
        //if the boss is below 2 and above 3, below 3 and above 1,
        //and is less or equal to 0
        if (bossHealth <7 && bossHealth> 3)
        {
            Phase2 = true;
            Debug.Log("Phase2");
        }
        else if (bossHealth <3 && bossHealth >= 1)
        {
            Phase2 = false;
            Debug.Log("Phase3");
            Phase3 = true;
        }
        else if (bossHealth <= 0)
        {
            Phase3 = false;
            Debug.Log("Death");
            isDeath = true;
        }
    }

    public void ProjectileShoot()
    {
        if (timer > waitingTime)
        {
            if (Phase2)
            {
                //clone and create our projectile
                GameObject clone = Instantiate(projectile, shotLocation.position, Quaternion.identity);
                //reset our timer
                timer = 0f;
            }
            else if (Phase3)
            {
                GameObject clone = Instantiate(projectile2, shotLocation.position, Quaternion.identity);
                //reset our timer 
                timer = 0f;
            }
        }
    }

    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z = -1f;
        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0, 180, 0);
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0, 180, 0);
            isFlipped = false;
        }
    }

    private void OnCollisionEntr2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerManager.TakeDamage();
        }
    }
}
