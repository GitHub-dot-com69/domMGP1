using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Test("This is a test!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creating a function that will help us test our code

    void Test(string message)
    {
        Debug.Log(message);
    }


}
