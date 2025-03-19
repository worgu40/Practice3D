using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public float mouseSensitivity = 100f;
    private float mouseY;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) {
            transform.position = new Vector3(player.position.x, player.position.y + 1, player.position.z);

            mouseY -= Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
            mouseY = Mathf.Clamp(mouseY, -90f, 90f); // Clamp vertical rotation

            transform.localRotation = Quaternion.Euler(mouseY, 0f, 0f); // Rotate camera based on mouse input
            transform.rotation = Quaternion.Euler(mouseY, player.eulerAngles.y, 0f); // Follow player's rotation
        }
    }
}
