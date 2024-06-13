using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    //[SerializeField] put so that other scripts dont use variables
    [SerializeField] private float initalSpeed = 10; // controls balls intital speed
    [SerializeField] private float speedIncrease = 0.25f; // increases ball speed over time
    [SerializeField] private TextMeshProUGUI playerScore; // displays and updates player score in game
    [SerializeField] private TextMeshProUGUI AIScore; // displays and updates AI score in game

    private int hitCounter;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("StartBall", 2f);
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
        transform.position = new Vector2(0, 0); // removes/resets all speed
        hitCounter = 0;
        Invoke("StartBall", 2f); // calls the "StartBall" function after 2 seconds to give the player time to reset
    }

    private void PlayerBounce(Transform myObject)
    {
        hitCounter++;
        Vector2 ballPos = transform.position;
        Vector2 playerPos = myObject.position; // makes the ball go in a different direction

        float xDirection, yDirection;
        if (transform.position.x > 0)
        {
            xDirection = -1;

        }
        else
        {
            xDirection = 1;
        }
        yDirection = (ballPos.y - playerPos.y) / myObject.GetComponent<Collider2D>().bounds.size.y;

        if (yDirection == 0)
        {
            yDirection = 0.25f;
        }
        rb.velocity = new Vector2(xDirection, yDirection) * (initalSpeed + (speedIncrease * hitCounter));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "AI")
        {
            PlayerBounce(collision.transform);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.x > 0) // if the ball is on the right side of the screen
        {
            ResetBall();
            playerScore.text = (int.Parse(playerScore.text) + 1).ToString();
        }
        else if (transform.position.x < 0)
        {
            ResetBall();
        }
    }

    void Update()
    {
        
    }
}
