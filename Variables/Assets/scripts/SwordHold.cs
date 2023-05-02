using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHold : MonoBehaviour
{
    public bool sword = true;
    private string message = "The Sword of Hephaestus has been equipped";
    // Start is called before the first frame update
    void Start()
    {
        if (sword == true)
        {
            Debug.Log(message);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
