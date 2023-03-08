using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class PlayerController1 : MonoBehaviour
{
    private bool isGrounded;
    private Rigidbody2D rb;
    // OPTIONAL: include if you want to limit x velocity
    private float maxVelX = 10;

    public float xSpeed;
    public float jumpStrength;
    public Text P2Score;

    void Start()
    {
        isGrounded = false;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float xHat = new Vector2(Input.GetAxis("Horizontal2"), 0).normalized.x;
        float vx = xHat * xSpeed;
        rb.AddForce(transform.right * vx);

        float yHat = new Vector2(0, Input.GetAxis("Vertical2")).normalized.y;
        if (isGrounded && yHat == 1) {
            float vy = yHat * jumpStrength;
            isGrounded = false;
            rb.AddForce(transform.up * vy);
        }
        // OPTIONAL: include if you want to limit x velocity
        rb.velocity = new Vector2(Vector2.ClampMagnitude(rb.velocity, maxVelX).x, rb.velocity.y);
        
        if (transform.position.y < -3) {
            //if u go too far in direction u go backa to spawn
            transform.position = new Vector3(-2,2,0);
            // Get the current score
            int newScore = Int32.Parse(P2Score.text) - 5;
            // Display the newScore in the UI
            P2Score.text = newScore.ToString();
        }

        if (transform.position.y > 25) {
            //if u go too far in direction u go backa to spawn
            transform.position = new Vector3(-2,2,0);
            // Get the current score
            int newScore = Int32.Parse(P2Score.text) - 5;
            // Display the newScore in the UI
            P2Score.text = newScore.ToString();
        }

        if (transform.position.x < -21) {
            //if u go too far in direction u go backa to spawn
            transform.position = new Vector3(-2,2,0);
            // Get the current score
            int newScore = Int32.Parse(P2Score.text) - 5;
            // Display the newScore in the UI
            P2Score.text = newScore.ToString();
        }

        if (transform.position.x > 26) {
            //if u go too far in direction u go backa to spawn
            transform.position = new Vector3(-2,2,0);
            // Get the current score
            int newScore = Int32.Parse(P2Score.text) - 5;
            // Display the newScore in the UI
            P2Score.text = newScore.ToString();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = collision.gameObject.tag == "Ground";
    
        if (collision.gameObject.tag == "Bronze")
        {
            // Get the current score
            int newScore = Int32.Parse(P2Score.text) + 1;
            // Save the current score to be used across multiple scenes.
            PlayerPrefs.SetInt("P2Score", newScore);
            // Display the newScore in the UI
            P2Score.text = newScore.ToString();

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Silver")
        {
            // Get the current score
            int newScore = Int32.Parse(P2Score.text) + 3;
            // Save the current score to be used across multiple scenes.
            PlayerPrefs.SetInt("P2Score", newScore);
            // Display the newScore in the UI
            P2Score.text = newScore.ToString();

            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Gold")
        {
            // Get the current score
            int newScore = Int32.Parse(P2Score.text) + 5;
            // Save the current score to be used across multiple scenes.
            PlayerPrefs.SetInt("P2Score", newScore);
            // Display the newScore in the UI
            P2Score.text = newScore.ToString();

            Destroy(collision.gameObject);
        }
    }
}