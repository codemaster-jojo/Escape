using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSideMovt : MonoBehaviour
{
    [SerializeField] private float movtAmount;
    [SerializeField] private float endMovtAmount;
    [SerializeField] private float speed;
    
    private bool moveDir = true;
    private float tempMovtAmount = 0;
    // Start is called before the first frame update

    private void FixedUpdate()
    {
        if (moveDir) 
        {
            tempMovtAmount += speed;
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }
        else 
        {
            tempMovtAmount -= speed;
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }
        
        if (tempMovtAmount <= endMovtAmount || tempMovtAmount >= movtAmount) 
        {
            moveDir = !moveDir;
        }


    }
}
