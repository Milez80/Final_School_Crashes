using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    //[SerializedField] put so that other scripts dont use variables
    [SerializeField] private float initalSpeed = 10; // controls balls intital speed
    [SerializeField] private float speedIncrease = 0.25f; // increases ball speed over time
    [SerializeField] private TextMeshProUGUI playerScore; // displays and updates player score in game
    [SerializeField] private TextMeshProUGUI AIScore; // displays and updates AI score in game

    private int hitCounter;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, initalSpeed + (speedIncrease * hitCounter)); //controls ball speed increase so it doesnt go over certain limit
    }

    private void StartBall() // gonna run at the start of the round and initalize the direction for the ball to travel
    {
        rb.velocity = new Vector2(-1, 0) * (initalSpeed + speedIncrease *hitCounter);
                              // (-1, 0) will make ball move towards player
    }

    private void ResetBall() // gonna be called at the end of each round and put the ball back to the center of the screen, plus remove all velocity and invoke the start ball function
    {
        rb.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0); // removes/resets all speed\
        hitCounter = 0;
    }

    void Update()
    {
        
    }
}
