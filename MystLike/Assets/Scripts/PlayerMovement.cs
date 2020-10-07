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

        obj_PlayerControls.Movement.Foward.performed += w => InitiateMoveFoward();
        obj_PlayerControls.Movement.Back.performed += s => InitiateMoveBack();
        obj_PlayerControls.Movement.Left.performed += a => InitiateMoveLeft();
        obj_PlayerControls.Movement.Right.performed += d => InitiateMoveRight();
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

    void InitiateMoveFoward()
    {
        if (movingFoward)
        {
            movingFoward = false;
            return;
        } 
        if (!movingFoward)
        {
            movingFoward = true;
        }
    }

    void InitiateMoveBack()
    {
        if (movingBack)
        {
            movingBack = false;
            return;
        }
        if (!movingBack)
        {
            movingBack = true;
        }
    }

    void InitiateMoveLeft()
    {
        if (movingLeft)
        {
            movingLeft = false;
            return;
        }
        if (!movingLeft)
        {
            movingLeft = true;
        }
    }

    void InitiateMoveRight()
    {
        if (movingRight)
        {
            movingRight = false;
            return;
        }
        if (!movingRight)
        {
            movingRight = true;
        }
    }





    //Enable/Diable
    private void OnEnable()
    {
        obj_PlayerControls.Enable();
    }

    private void OnDisable()
    {
        obj_PlayerControls.Disable();
    }
}
