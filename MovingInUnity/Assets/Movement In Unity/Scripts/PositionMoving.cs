using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMoving : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   private void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
}
