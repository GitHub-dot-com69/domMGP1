using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public string[] questPartyMembers = new string[] { "Merlin the Wise", "Grim the Barbarian", "Sterling the Knight" };
    // Start is called before the first frame update
    void Start()
    {
      for (int i = 0; i < questPartyMembers.Length; i++)
        {
            Debug.Log(questPartyMembers[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
