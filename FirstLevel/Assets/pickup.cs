using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.CompareTag("player"))
        {
            //access our function from our player manager and call it
            PlayerMangager manager = collision.GetComponent<PlayerMangager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
