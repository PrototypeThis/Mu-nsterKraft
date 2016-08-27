
using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour
{
    private Player player;

    //the player's rigidbody used for movement
    private Rigidbody rb;

    //how fast the player rotates
    public float rotateSpeed;

    void Start()
    {
        player = FindObjectOfType<Player>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 10))
            print("There is something in front of the object!");
    }

    void Update()
    {
        PlayerRotation();
        PlayerMovement();

    }

    /// <summary>
    /// Handles player movement
    /// </summary>
    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * player.speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * player.speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * player.speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * player.speed * Time.deltaTime;
        }     
    }

    /// <summary>
    /// Handles Player Rotation
    /// </summary>
    private void PlayerRotation()
    {
        //grabs horizontal input from mouse
        float h = rotateSpeed * Input.GetAxis("Mouse X");

        //grabs vertical input from mouse
        // float v = rotateSpeed * Input.GetAxis("Mouse Y");

        //rotates object based on mouse inputs
        transform.Rotate(0, h, 0);   
    }
}