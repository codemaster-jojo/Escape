using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float dash_speed; // Declare most variables like this!
    [SerializeField] private float reg_speed; // Declare most variables like this!
    [SerializeField] private float speed; // Declare most variables like this!
    [SerializeField] private float jumpSpeed;

    [SerializeField] private Rigidbody rb;

    [SerializeField] private Transform mainCamera;

    [SerializeField] private Transform startPoint;
    [SerializeField] private string endPointName;


    private Vector2 playerInput;

    private void Awake()
    {
        transform.position = startPoint.transform.position; // new Vector3(startPoint.transform.x, startPoint.transform.y, startPoint.transform.z);
    }
    private void Update()
    {
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"));
        playerInput.Normalize();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.y);
        }
        
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
            speed = dash_speed;
        }

        else {
            speed = reg_speed;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == endPointName) {
            transform.position = startPoint.transform.position; // new Vector3(startPoint.transform.x, startPoint.transform.y, startPoint.transform.z);
            Debug.Log("GAME WON!!!");
        }

        if (collision.gameObject.name.StartsWith("Red")) {
            transform.position = startPoint.transform.position; // new Vector3(startPoint.transform.x, startPoint.transform.y, startPoint.transform.z);
            Debug.Log("DIED!!!!");
        }

    } 
    
    private void FixedUpdate()
    {
        // rb.velocity = new Vector3(playerInput.x * speed, rb.velocity.y, playerInput.y * speed);
        Vector3 moveDir = (playerInput.y * mainCamera.forward) + (playerInput.x * mainCamera.right);
        moveDir.Normalize();
        rb.velocity = new Vector3(moveDir.x * speed, rb.velocity.y, moveDir.z * speed);
    }
}
