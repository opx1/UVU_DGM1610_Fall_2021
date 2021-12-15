using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float chaseSpeed;
    private float paceMax;
    private float paceMin;
    public float paceDistance;

    private Rigidbody2D enemyRb;

    private GameObject player;

    private bool dirRight = true;

    private PlayerMovement playerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        paceMax = transform.position.x + paceDistance;
        paceMin = transform.position.x - paceDistance;
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookDirection = (player.transform.position - transform.position);
        
        if (lookDirection.x  >= -3.5 && lookDirection.x <= 3.5 && playerControllerScript.isOnGround == true )
        {
            enemyRb.AddForce(lookDirection * chaseSpeed);
            Debug.Log("ChaseRange");
        }
        else
        {
            if (dirRight)
            {
                transform.Translate(Vector2.right * (speed * Time.deltaTime));
            }
            else
            {
                transform.Translate(Vector2.left * (speed * Time.deltaTime));
            }

            if (transform.position.x <= paceMin)
            {
                dirRight = true;
            }

            else if (transform.position.x >= paceMax)
            {
                dirRight = false;
            }  
        }
    }
  private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
        }
    }
}
