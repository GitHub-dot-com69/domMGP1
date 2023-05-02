using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PseudoCode : MonoBehaviour
{
    //create two variables that I will add together 
    public int n1 = 4;
    public int n2 = 5;

    // Start is called before the first frame update
    void Start()
    {
        //The is in the the parameters of debug.log
        Debug.Log(AddingTogether(n1, n2));
    }

    // Update is called once per frame
    void Update()
    {

    }

    int AddingTogether(int n1, int n2)
    {
        //At the end of your code have to get your result of the code
        int result;
        result = n1 + n2;
        return result;
    }
}
   


