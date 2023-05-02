using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringArray : MonoBehaviour
{
    int[] topPlayerScores = new int[3];
    string[] topPlayersName = new string[6];
    GameObject[] Prefabs = new GameObject[7];
    // Start is called before the first frame update
    void Start()
    {
        int[] topPlayerScores = { 713, 549, 984 };
        topPlayerScores[0] = 713;
        topPlayerScores[1] = 549;
        topPlayerScores[2] = 984;
        Debug.Log(topPlayerScores[0]);
        Debug.Log(topPlayerScores[1]);
        Debug.Log(topPlayerScores[2]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
