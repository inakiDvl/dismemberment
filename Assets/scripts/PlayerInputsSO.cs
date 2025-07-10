using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "player inputs", menuName = "Scriptable Objects/player inputs")]
public class PlayerInputsSO : ScriptableObject
{
    private Playerinputs playerInputs;

    public event Action OnLeftClickPressed;

    private void LeftClickPressed(InputAction.CallbackContext callbackContext)
    {
        OnLeftClickPressed?.Invoke();
    }

    private void OnEnable()
    {
        if (playerInputs == null)
            playerInputs = new Playerinputs();

        playerInputs.Enable();

        playerInputs.gameplay.leftclick.performed += LeftClickPressed;
    }

    private void OnDisable()
    {
        playerInputs.Disable();
    }
}
