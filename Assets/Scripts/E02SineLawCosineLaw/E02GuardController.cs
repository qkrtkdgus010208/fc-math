using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E02GuardController : MonoBehaviour
{
    [SerializeField] Transform enemy1;
    [SerializeField] Transform enemy2;

    // Start is called before the first frame update
    void Start()
    {
        CosineLaw();
    }

    void SineLaw()
    {
        var a = Vector3.Distance(enemy1.position, enemy2.position);
        var sinA = Mathf.Sin(45 * Mathf.Deg2Rad);
        var sinB = Mathf.Sin(45 * Mathf.Deg2Rad);

        var b = a / sinA * sinB;
        Debug.Log("b변의 길이는 = " + b);
    }

    void CosineLaw()
    {
        var a = Vector3.Distance(enemy1.position, enemy2.position);
        var b = Vector3.Distance(transform.position, enemy1.position);
        var c = Vector3.Distance(transform.position, enemy2.position);

        var cosA = (Mathf.Pow(b, 2) + Mathf.Pow(c, 2) - Mathf.Pow(a, 2)) / (2 * b * c);
        Debug.Log("CosA = " + Mathf.Acos(cosA) * Mathf.Rad2Deg);
    }
}
