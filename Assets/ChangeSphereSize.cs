using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR; // Required for working with inputs from VR controllers

public class ChangeSphereSize : MonoBehaviour
{
    public float scaleChange = 0.1f;

    void Update()
    {
        // Check if the "Right Trigger" button on the Oculus Touch controller is pressed
        if (Input.GetButtonDown("XRI_Right_Trigger"))
        {
            // Increase the size of the sphere
            transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
        }
    }
}


