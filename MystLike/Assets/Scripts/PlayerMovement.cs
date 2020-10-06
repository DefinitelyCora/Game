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

    bool movingF = false;

    public float movementSpeed = 2f;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        obj_PlayerControls = new PlayerControls();

        obj_PlayerControls.Movement.Foward.ChangeBindingWithPath("<Keyboard>/" + fowardKey);

        obj_PlayerControls.Movement.Foward.performed += w => InitiateMoveF();
    }

    void Update()
    {
        if (movingF)
        {
            rb.AddForce(transform.forward / movementSpeed, ForceMode.VelocityChange);
        }
    }

    void InitiateMoveF()
    {
        if (movingF)
        {
            movingF = false;
            return;
        } 
        if (!movingF)
        {
            movingF = true;
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
