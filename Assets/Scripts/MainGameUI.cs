using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainGameUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI speedText;  
    [SerializeField] private Rigidbody playerRb;

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = playerRb.velocity;

        int speed_int = (int)(velocity.magnitude * 100);
        float speed = (float)(speed_int/100);

        speedText.text = speed.ToString() + "mps";
    }
}
