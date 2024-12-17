using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add this for TextMeshPro support

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject mainMenuPanel; // Reference to the Main Menu Panel

    public static int numberOfCoins;
    public TMP_Text coinsText; // Use TMP_Text instead of Text

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 0; // Pause the game initially
        mainMenuPanel.SetActive(true); // Show the Main Menu
        gameOverPanel.SetActive(false); // Hide the Game Over Panel initially
        numberOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        coinsText.text = "Coins: " + numberOfCoins; // Update the TextMeshPro text
    }

    // This method will be called when the Start Button is clicked
    public void StartGame()
    {
        Time.timeScale = 1; // Resume the game
        mainMenuPanel.SetActive(false); // Hide the Main Menu
    }
}