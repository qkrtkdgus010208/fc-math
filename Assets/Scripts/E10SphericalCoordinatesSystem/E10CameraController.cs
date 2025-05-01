using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E10CameraController : MonoBehaviour
{
    float radius = 5f;
    float polarAngle = 0f;
    float azimuthAngle = 0f;
    float rotationSpeed = 30f;

    // Update is called once per frame
    void Update()
    {
        float h, v;
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        azimuthAngle += h * rotationSpeed * Time.deltaTime;
        polarAngle += v * rotationSpeed * Time.deltaTime;

        Vector3 cartesianPosition = ConvertToCartesian(radius, polarAngle, azimuthAngle);

        transform.position = cartesianPosition;
        transform.LookAt(Vector3.zero);
    }

    Vector3 ConvertToCartesian(float r, float polarAngle, float azimuthAngle)
    {
        float b = r * Mathf.Cos(polarAngle * Mathf.Deg2Rad);
        float x = b * Mathf.Cos(azimuthAngle * Mathf.Deg2Rad);
        float y = r * Mathf.Sin(polarAngle * Mathf.Deg2Rad);
        float z = b * Mathf.Sin(azimuthAngle * Mathf.Deg2Rad);

        return new Vector3(x, y, z);
    }
}
