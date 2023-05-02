using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatMyAxis : MonoBehaviour
{
    public float inputX;
    public float inputY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       inputX = Input.GetAxis("Horizontal");
       inputY = Input.GetAxis("Vertical");
        Debug.Log(inputX + "," + inputY);
    }
}
