using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour
{
    //This where I delcare my variables for my script.
    //Declare two variables one for your age and one for your name
    public int age = 14;
    public string Name = "Dominick Meza";
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(age + Name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



