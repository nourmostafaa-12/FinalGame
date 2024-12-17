using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Any initialization code can go here (if needed)
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the coin for visual effect
        transform.Rotate(80 * Time.deltaTime, 0, 0);
    }

    // Correct capitalization for Unity's trigger detection
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Use CompareTag for better performance
        {
            FindObjectOfType<AudioManager>().PlaySound("Coins");
            PlayerManager.numberOfCoins += 1; // Increment the player's coin count
            Destroy(gameObject); // Remove the coin from the scene
        }
    }
}
