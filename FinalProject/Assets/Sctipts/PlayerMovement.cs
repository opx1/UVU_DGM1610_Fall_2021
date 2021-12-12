using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float xRange = 10;

    public bool isOnGround = true;
    public bool isOnPlatform = true;

    private Rigidbody2D playerRb;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * (speed * Time.deltaTime * horizontalInput));
        if (Input.GetKeyDown(KeyCode.UpArrow) && (isOnGround || isOnPlatform))
        {
            playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isOnGround = false;
            isOnPlatform = false;
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange,transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange,transform.position.y);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        if (collision.gameObject.CompareTag("Platform"))
        {
            isOnPlatform = true;
        } 
    }
}
