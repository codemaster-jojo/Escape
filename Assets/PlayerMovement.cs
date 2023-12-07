using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float dash_speed; // Declare most variables like this!
    [SerializeField] private float reg_speed; // Declare most variables like this!
    [SerializeField] private float speed; // Declare most variables like this!
    [SerializeField] private float jumpSpeed;

    [SerializeField] private Rigidbody rb;

    [SerializeField] private Transform mainCamera;

    [SerializeField] private TextMeshProUGUI txtbox;  

    private Vector2 playerInput;

    private void Awake()
    {
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
            txtbox.text = "Dashing";
        }

        else {
            speed = reg_speed;
            txtbox.text = "Walking";
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
