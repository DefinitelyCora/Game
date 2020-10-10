using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    PlayerControls obj_PlayerControls;

    public string fowardKey = "w";
    public string backKey = "s";
    public string leftKey = "a";
    public string rightKey = "d";

    bool movingFoward = false;
    bool movingBack = false;
    bool movingLeft = false;
    bool movingRight = false;

    public float movementSpeed = 2f;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        obj_PlayerControls = new PlayerControls();

        obj_PlayerControls.Movement.Foward.ChangeBindingWithPath("<Keyboard>/" + fowardKey);
        obj_PlayerControls.Movement.Back.ChangeBindingWithPath("<Keyboard>/" + backKey);
        obj_PlayerControls.Movement.Left.ChangeBindingWithPath("<Keyboard>/" + leftKey);
        obj_PlayerControls.Movement.Right.ChangeBindingWithPath("<Keyboard>/" + rightKey);

        obj_PlayerControls.Movement.Foward.performed += _ => movingFoward = !movingFoward;
        obj_PlayerControls.Movement.Back.performed += _ => movingBack = !movingBack;
        obj_PlayerControls.Movement.Left.performed += _ => movingLeft = !movingLeft;
        obj_PlayerControls.Movement.Right.performed += _ => movingRight = !movingRight;
    }

    void Update()
    {
        if (movingFoward)
        {
            rb.AddForce(transform.forward * movementSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (movingBack)
        {
            rb.AddForce(-transform.forward * movementSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (movingLeft)
        {
            rb.AddForce(-transform.right * movementSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (movingRight)
        {
            rb.AddForce(transform.right * movementSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
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
