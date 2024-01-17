using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    [Tooltip("Movement speed in meters per second")][SerializeField] float speed = 1f;

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);

    [SerializeField]
    [Tooltip("Move the player to the location of 'moveToLocation'.")]
    InputAction moveRight = new InputAction(type: InputActionType.Button);

    [SerializeField]
    [Tooltip("Move the player to the location of 'moveToLocation'.")]
    InputAction moveLeft = new InputAction(type: InputActionType.Button);

 
    void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
        moveRight.Enable();
        moveLeft.Enable();  
    }

    void OnDisable()
    {
        moveUp.Disable();
        moveDown.Disable();
        moveRight.Disable();
        moveLeft.Disable();
    }
    void Update()
    {
        if (moveUp.IsPressed())
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        else if (moveDown.IsPressed())
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
        else if (moveLeft.IsPressed()) 
        {
            transform.position += new Vector3(-speed * Time.deltaTime,0, 0);
        }  
        else if(moveRight.IsPressed())
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        }
    
    }
}