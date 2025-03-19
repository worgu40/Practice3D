using System.IO.Compression;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float horizontal; // X AXIS
    private float vertical; // Z AXIS
    public float speed;
    public float mouseSensitivity = 100f;
    private float mouseX;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical"); // Get vertical input   
        rb.linearVelocity = new Vector3(horizontal * speed, rb.linearVelocity.y, vertical * speed); // Update velocity for both horizontal and vertical movement

        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        transform.Rotate(Vector3.up * mouseX); // Rotate player based on mouse input
    }        
}



