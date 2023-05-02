using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceWithoutTheE : MonoBehaviour
{

    public int inteligence = 5;

    // Update is called once per frame
   private void Update()
    {
        Greet();
    }

    void Greet()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (Random.Range(1,7))
            {
                case 6:
                    Debug.Log("6");
                        break;
                case 5:
                    Debug.Log("5");
                        break;
                case 4:
                    Debug.Log("4");
                        break;
                case 3:
                    Debug.Log("3");
                        break;
                case 2:
                    Debug.Log("2");
                        break;
                case 1:
                    Debug.Log("1");
                        break;
                default:
                    Debug.Log("Incorrect intelligence level");
                    break;
            }
        }
    }
}
