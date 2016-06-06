using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour
{
    public Vector3 rotation;
    public float rotationSpeed;

    void Update()
    {
        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);
    }

}