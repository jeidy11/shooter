using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public static InputController Instance;

    InputAction movementInput;

    InputAction shootInput; 
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
        shootInput = InputSystem.actions.FindAction("Attack");
    }
    private void Shoot()
    {
        if (shootInput.WasPressedThisFrame())
        {
            GunController.instance.Fire();
        }
    }
    public void GetMoveInput()
    {
        movementVector = movementInput.ReadValue<Vector2>();
    }
    // Update is called once per frame
    void Update()
    {
        GetMoveInput();
        Shoot(); 
    }
}
