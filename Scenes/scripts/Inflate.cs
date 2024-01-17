using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inflator : MonoBehaviour
{
    public float scaleSpeed = 1f;      // Adjust this value to control the scale speed
    public float maxScale = 5f;        // Maximum scale size
    public float minScale = 0.5f;      // Minimum scale size

    private bool increasing = true;     // Flag to track whether to increase or decrease the scale

    void Update()
    {
        // Check if we should increase or decrease the scale
        if (increasing)
        {
            // Increase the object's scale
            transform.localScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime;

            // Check if the scale has reached the maximum
            if (transform.localScale.x >= maxScale)
            {
                // Set the flag to decrease the scale
                increasing = false;
            }
        }
        else
        {
            // Decrease the object's scale
            transform.localScale -= new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime;

            // Check if the scale has reached the minimum
            if (transform.localScale.x <= minScale)
            {
                // Set the flag to increase the scale
                increasing = true;
            }
        }
    }
}
