﻿using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        var playerInput = GetComponent<PlayerInput>();
        playerInput.onActionTriggered += OnInputAction;
    }

    private void OnInputAction(InputAction.CallbackContext context)
    {
        if (!context.performed) return;

        switch (context.action.name)
        {
            case "FireAction":
                Debug.Log("FireAction");
                break;
            case "SkillAction":
                Debug.Log("SkillAction");
                break;
            case "Horizontal":
                Debug.Log($"Horizontal {context.action.ReadValue<float>()}");
                break;
            case "MousePos":
                Debug.Log($"MousePos {context.action.ReadValue<Vector2>()}");
                break;
        }
    }
}