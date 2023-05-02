using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDownFromThereKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("W key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("A key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("S key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("D key was pressed");
        }
    }
}
