using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceMoving : MonoBehaviour
{
    public float forceMult = 200;
    private Rigidbody rb;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        rb.AddForce(transform.forward * forceMult * Time.deltaTime);
    }
}
