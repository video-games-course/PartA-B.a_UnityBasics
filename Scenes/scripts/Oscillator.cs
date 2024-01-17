using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour

{
    public float swingForce = 1f; // this is the speed of the swing
    public float maxSwingAngle = 90f; // the object will stop at 90 degree
    public float damping = 5f; // 

    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.rotation; // this line is for the object to start as we placed him
    }

    void Update()
    {
        float targetRotation = Mathf.Sin(Time.time * swingForce) * maxSwingAngle; // 

        // Apply rotation to simulate swinging motion around the Z-axis
        transform.rotation = initialRotation * Quaternion.Euler(0f, 0f, targetRotation);

        // Calculate damping factor based on the current rotation angle
        float currentRotationAngle = Mathf.Abs(targetRotation);
        float adjustedDamping = Mathf.Lerp(damping, 1f, Mathf.InverseLerp(0f, maxSwingAngle, currentRotationAngle));

        // Damping to gradually slow down the swing
        float dampingFactor = 1f - Mathf.Clamp01(adjustedDamping * Time.deltaTime);
        targetRotation *= dampingFactor;
    }
}