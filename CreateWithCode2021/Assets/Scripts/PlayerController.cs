using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    private float turnSpeed = 50.0f;
    [SerializeField] private float speed = 20.0f;
    [SerializeField] private float horsePower = 0;
    [SerializeField] private float rpm;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    [SerializeField] private GameObject centerOfMass;
    [SerializeField] private TextMeshProUGUI speedometerText;
    [SerializeField] private TextMeshProUGUI rpmText;
    [SerializeField] private List<WheelCollider> allWheels;
    [SerializeField] private int wheelsOnGround;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward based on vertical input
        //transform.Translate(Vector3.forward * (Time.deltaTime * speed * forwardInput));

        if (IsOnGround())
        {
            playerRb.AddRelativeForce(Vector3.forward * (horsePower * forwardInput));
            // Rotates the car based on horizontal input
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

            speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f); // For kph, change 2.237 to 3.5;
            speedometerText.SetText("Speed:" + speed + "mph");

            rpm = (speed % 30) * 40;
            rpmText.SetText("RPM:" + rpm);
        }
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
