using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDetection : MonoBehaviour
{

    public float RotationSpeed;
    public float MinRotateAngle;
    public float MaxRotateAngle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }


    void Rotation()
    {
        transform.Rotate(0, 0, RotationSpeed/10);


        if (transform.rotation.z <= MinRotateAngle && RotationSpeed <= 0)
        {
            RotationSpeed *= -1;
        }
        else if (transform.rotation.z <= MaxRotateAngle && RotationSpeed >= 0)
        {
            RotationSpeed *= -1;
        }

    }
}
