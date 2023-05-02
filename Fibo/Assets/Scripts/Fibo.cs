using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibo : MonoBehaviour
{
    
        int n1 = 0;
        int n2 = 1;
        int result;
    

    // Update is called once per frame
    void Update()
    {
        if (result < 2000)
        {
            result = n1 + n2;
            Debug.Log (result);
            n1 = n2;
            n2 = result;
        }
    }
}
