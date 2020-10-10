using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    PlayerControls obj_PlayerControls;

    Vector2 inputView;

    public float mouseSensitivity = .08f;

    Transform playerBody;

    float xRotation = 0f;

    private void Awake()
    {
        obj_PlayerControls = new PlayerControls();

        obj_PlayerControls.View.Look.performed += o => inputView = o.ReadValue<Vector2>();
    }

    void Start()
    {
        playerBody = transform.parent.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = inputView.x * mouseSensitivity;
        float mouseY = inputView.y * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void OnEnable()
    {
        obj_PlayerControls.Enable();
    }

    private void OnDisable()
    {
        obj_PlayerControls.Disable();
    }
}
