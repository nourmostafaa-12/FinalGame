using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject mainMenuPanel; // Reference to the Main Menu Panel

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 0; // Pause the game initially
        mainMenuPanel.SetActive(true); // Show the Main Menu
        gameOverPanel.SetActive(false); // Hide the Game Over Panel initially
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }

    // This method will be called when the Start Button is clicked
    public void StartGame()
    {
        Time.timeScale = 1; // Resume the game
        mainMenuPanel.SetActive(false); // Hide the Main Menu
    }
}
