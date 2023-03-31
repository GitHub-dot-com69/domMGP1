using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //declare public max and current health
    public int currentHealth;
    public int maxHealth;
    public int coinCount;
    movement movement;
    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<movement>();
    }

    public bool PickupItem(GameObject obj)
    {
        switch (obj.tag)
        {
            case "Currency":
                coinCount++;
                return true;
            case "Speed":
                movement.SpeedPowerUp();
                return true;
            default:
                Debug.Log("Item tag or refrence not set.");
                return false;
        }
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            PauseGame();
        }
    }

    //create a function that minuses the players current health.
    public void TakeDamage()
    {
        currentHealth -= 1;
    }

    //create a function that will pause the game 
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    //create a function that will resume the game
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

}