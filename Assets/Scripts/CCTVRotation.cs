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



    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = RotationSpeed / 10;
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();

    }

    void Rotation()
    {
        CurrentAngle = transform.rotation.z * 180;
        transform.Rotate(0, 0, rotationSpeed);

        if (CurrentAngle >= MaxAngle)
        {
            rotationSpeed = -RotationSpeed / 10;
        }
        else if (CurrentAngle <= MinAngle)
        {
            rotationSpeed = RotationSpeed / 10;
        }

        
    }


}
