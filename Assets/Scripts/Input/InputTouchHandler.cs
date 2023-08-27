using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputTouchHandler : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;

    private PlayerInput _playerInput;

    private InputAction _touchPressAction;

    private void Awake() 
    {
        _playerInput = GetComponent<PlayerInput>();

        _touchPressAction = _playerInput.actions["TouchPress"];
    }

    private void OnEnable() 
    {
        _touchPressAction.performed += TouchPressed;
    }

    private void OnDisable() 
    {
        _touchPressAction.performed -= TouchPressed;
    }

    private void TouchPressed(InputAction.CallbackContext context)
    {
        _playerMovement.Fly();
    }
}
