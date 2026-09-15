using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public static InputController Instance;

    InputAction movementInput;
    [HideInInspector] public Vector2 movementVector;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
           
        }
        else
        {
            Destroy(this);
        }

        movementInput = InputSystem.actions.FindAction("Move");
    }
    public void GetMoveInput()
    {
        movementVector = movementInput.ReadValue<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        GetMoveInput();
    }
}
