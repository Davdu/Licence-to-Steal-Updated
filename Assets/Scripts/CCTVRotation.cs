using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTVRotation : MonoBehaviour
{

    public float MaxAngle;
    public float MinAngle;
    public float RotationSpeed;
    public float CurrentAngle;
    private float rotationSpeed;



    void Start()
    {
        rotationSpeed = RotationSpeed / 100;
    }

    void FixedUpdate()
    {
        Rotation();
    }

    void Rotation()
    {
        CurrentAngle = transform.rotation.z * 180;
        transform.Rotate(0, 0, rotationSpeed);

        if (CurrentAngle >= MaxAngle)
        {
            rotationSpeed = -RotationSpeed / 100;
        }
        else if (CurrentAngle <= MinAngle)
        {
            rotationSpeed = RotationSpeed / 100;
        }   
    }
}
