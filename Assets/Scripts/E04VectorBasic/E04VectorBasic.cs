using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E04VectorBasic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 a = new Vector3(3, 4, 0);
        Vector3 b = new Vector3(-2, 2, 0);

        Vector3 r1 = a + b;
        Debug.Log($"r1: {r1}");

        Vector3 r2 = a - b;
        Debug.Log($"r2: {r2}");

        Vector3 r3 = b - a;
        Debug.Log($"r3: {r3}");

        float d1 = Mathf.Sqrt(Mathf.Pow(r2.x, 2) + Mathf.Pow(r2.y, 2) + Mathf.Pow(r2.z, 2));
        Debug.Log($"d1: {d1}");
        Debug.Log($"magnitude: {r2.magnitude}");
        Debug.Log($"distance: {Vector3.Distance(a, b)}");

        float d2 = Mathf.Sqrt(Mathf.Pow(r3.x, 2) + Mathf.Pow(r3.y, 2) + Mathf.Pow(r3.z, 2));
        Debug.Log($"d2: {d2}");
        Debug.Log($"magnitude: {r3.magnitude}");
        Debug.Log($"distance: {Vector3.Distance(b, a)}");
    }
}
