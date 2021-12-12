using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float chaseSpeed;

    private Rigidbody2D enemyRb;

    private GameObject player;

    private bool dirRight = true;

    private PlayerMovement playerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookDirection = (player.transform.position - transform.position);
        
        if (lookDirection.x  >= -3 && lookDirection.x <= 3 && playerControllerScript.isOnGround == true )
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

            if (transform.position.x <= -2)
            {
                dirRight = true;
            }

            if (transform.position.x >= 2)
            {
                dirRight = false;
            }  
        }
    }
}
