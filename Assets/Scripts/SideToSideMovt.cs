using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSideMovt : MonoBehaviour
{
    [SerializeField] private float movtAmount;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    
    private bool moveDir = true;
    private float tempMovtAmount = 0;
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        if (moveDir) 
        {
            movtAmount += 1;
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
        }
        else 
        {
            movtAmount -= 1;
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -1 * speed);
        }
        
        if (tempMovtAmount <= 0 || tempMovtAmount >= movtAmount) 
        {
            moveDir = !moveDir;
        }


    }
}
