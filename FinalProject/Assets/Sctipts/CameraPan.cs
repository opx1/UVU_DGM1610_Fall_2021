using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    private GameObject player;
    private Vector2 lookDirection;
    public float speed;
    private GameObject camera;
    public bool cameraPanned = false;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookDirection = (player.transform.position - transform.position);
    }

    private void OnTriggerEnter2D (Collider2D player) 
    {
        Debug.Log("Camera Change");
        if (lookDirection.x <= 0 && cameraPanned == false)
        {
            camera.transform.Translate(new Vector2 (19,0));
            cameraPanned = true;
        }
        else if (lookDirection.x >= 0 && cameraPanned == true)
        {
            camera.transform.Translate(new Vector2 (-19,0));
            cameraPanned = false;
        }
    }
}
