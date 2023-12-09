using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset; // for third person: offset is (0, 2, -5)

    [SerializeField] private float mouseSensitivity = 2f;
    [SerializeField] private float maxVerticalAngle = 90f;

    private Vector2 mouseInput;

    private float rotX, rotY;

    private void Update()
    {
        mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxis("Mouse Y"));

    }
    private void LateUpdate()
    {

        transform.position = player.position + offset;
        rotX += mouseInput.x * mouseSensitivity * Time.deltaTime;
        rotY -= mouseInput.y * mouseSensitivity * Time.deltaTime;
        rotY = Mathf.Clamp(rotY, -maxVerticalAngle, maxVerticalAngle);
        transform.rotation = Quaternion.Euler(rotY, rotX, 0);
    }
}