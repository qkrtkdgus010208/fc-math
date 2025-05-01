using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E06DotProduct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(1, 0, 0);
        Vector3 v2 = new Vector3(0, 1, 0);

        float result = Vector3.Dot(v1, v2);
        Debug.Log($"Dot product of v1 and v2: {result}");

        // cos(theta) = ¹Øº¯ / ºøº¯
        // ¹Øº¯ = ºøº¯ * cos(theta)

        // tan(theta) = ³ôÀÌ / ¹Øº¯
        // ³ôÀÌ = ¹Øº¯ * tan(theta)

        float baseValue = 1 * Mathf.Cos(45);
        float heightValue = baseValue * Mathf.Tan(45);

        Vector3 v3 = new Vector3(baseValue, heightValue, 0);

        float dotProduct1 = Vector3.Dot(v1, v3);
        Debug.Log($"Dot product of v1 and v3: {dotProduct1}");

        float docProduct2 = (v1.x * v3.x) + (v1.y * v3.y) + (v1.z * v3.z);
        Debug.Log($"Dot product of v1 and v3: {docProduct2}");

    }
}
