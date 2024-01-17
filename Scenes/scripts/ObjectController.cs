using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectController : MonoBehaviour
{
    private Renderer objectRenderer; // Reference to the object's renderer component
    [SerializeField]
    [Tooltip("Move the player to the location of 'moveToLocation'.")]
    InputAction pause = new InputAction(type: InputActionType.Button);


    void OnEnable()
    {
        pause.Enable();
    }

    void OnDisable()
    {
        pause.Disable();

    }
    void Start()
    {
        Debug.Log("start");
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // in order to make the object disappear the key "space" need's to be pressed
        if (pause.IsPressed())
        {
            objectRenderer.enabled = !objectRenderer.enabled; // each time th ekey space will be pressed the object will aperee or disappear acordiong to his current condition
        }
    }
}