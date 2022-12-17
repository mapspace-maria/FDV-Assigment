using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject player;
    private Vector3 position;


    // Update is called once per frame
    void Update()
    {
        // Calculate the direction to the player
        Vector3 direction = player.transform.position - transform.position;
        direction.Normalize();

        // Move towards the player
        transform.position = transform.position + direction * Time.deltaTime * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the enemy collided with the player
        if (collision.gameObject.name == "player")
        {
            // Destroy the player
            Destroy(collision.gameObject);

            // Stop the game
            Application.Quit();
        }
    }

    }
