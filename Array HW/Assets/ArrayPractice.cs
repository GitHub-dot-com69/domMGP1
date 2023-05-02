using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // create a script that creates two arrays one string one int
    public string[] topPlayersNames = new string[] { "Saul", "Nathan", "Nora" };
    public int[] topPlayersScores = new int[] { 4000, 3000, 2000 };
    // Start is called before the first frame update
    void Start()
    {
        foreach ( string value in topPlayersNames)
        {
            Debug.Log(value);
        }
        topPlayersNames[0] = "Sophia";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
