using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E01GuardController : MonoBehaviour
{
    [SerializeField] Transform enemyTransform;

    // Start is called before the first frame update
    void Start()
    {
        GetTanHeight();
    }

    public void GetTanHeight()
    {
        // Tan
        // Tan(Theta) = ³ôÀÌ / ¹Øº¯
        // Tan(Theta) * ¹Øº¯ = ³ôÀÌ

        var height = Mathf.Tan(45 * Mathf.Deg2Rad) * enemyTransform.position.x;
        Debug.Log("Height = " + height);
    }

    public void GetSinHeight()
    {
        // Sin
        // Sin(Theta) = ³ôÀÌ / ºøº¯
        // Sin(Theta) * ºøº¯ = ³ôÀÌ
        var enemyDistance = Mathf.Sqrt(Mathf.Pow(enemyTransform.position.x, 2) + Mathf.Pow(enemyTransform.position.z, 2));
        var height = Mathf.Sin(45 * Mathf.Deg2Rad) * enemyDistance;

        Debug.Log("height = " + height);
    }

    public void GetCosBase()
    {
        // Cos
        // Cos(Theta) = ¹Øº¯ / ºøº¯
        // Cos(Theta) * ºøº¯ = ¹Øº¯

        var enemyDistance = Mathf.Sqrt(Mathf.Pow(enemyTransform.position.x, 2) + Mathf.Pow(enemyTransform.position.z, 2));
        var baseValue = Mathf.Cos(45 * Mathf.Deg2Rad) * enemyDistance;

        Debug.Log("height = " + baseValue);
    }

    public void GetSinAngle()
    {
        var enemyDistance = Mathf.Sqrt(Mathf.Pow(enemyTransform.position.x, 2) + Mathf.Pow(enemyTransform.position.z, 2));
        Debug.Log("Enemy distance = " + enemyDistance);

        var unityDistance = Vector3.Distance(transform.position, enemyTransform.position);
        Debug.Log("Unity distance = " + unityDistance);

        // Sine
        var sinTheta = enemyTransform.position.z / enemyDistance;
        Debug.Log("sinTheta = " + sinTheta);
        Debug.Log("unitySinTheta = " + Mathf.Sin(45 * Mathf.Deg2Rad));

        var arcSin = Mathf.Asin(sinTheta);
        Debug.Log("Theta = " + arcSin * Mathf.Rad2Deg);
    }

    public void GetCosAngle()
    {
        var enemyDistance = Mathf.Sqrt(Mathf.Pow(enemyTransform.position.x, 2) + Mathf.Pow(enemyTransform.position.z, 2));
        var cosTheta = enemyTransform.position.x / enemyDistance;

        // var unityCosTheta = Mathf.Cos(45 * Mathf.Deg2Rad);

        var arcCos = MathF.Acos(cosTheta);
        Debug.Log("arcCos = " + arcCos * Mathf.Rad2Deg);
    }

    public void GetTanAngle()
    {
        var tanTheta = enemyTransform.position.z / enemyTransform.position.x;
        var arcTan = Mathf.Atan(tanTheta);
        Debug.Log("arcTan = " + arcTan * Mathf.Rad2Deg);
    }
}
