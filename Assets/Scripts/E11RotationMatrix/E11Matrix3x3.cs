using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E11Matrix3x3
{
    public float[,] matrix = new float[3, 3];

    public E11Matrix3x3(float[,] value)
    {
        this.matrix = value;
    }

    public static Vector3 Multiply(E11Matrix3x3 matrix, Vector3 vector)
    {
        float x = matrix.matrix[0, 0] * vector.x + matrix.matrix[0, 1] * vector.y + matrix.matrix[0, 2] * vector.z;
        float y = matrix.matrix[1, 0] * vector.x + matrix.matrix[1, 1] * vector.y + matrix.matrix[1, 2] * vector.z;
        float z = matrix.matrix[2, 0] * vector.x + matrix.matrix[2, 1] * vector.y + matrix.matrix[2, 2] * vector.z;

        return new Vector3(x, y, z);
    }

    public static E11Matrix3x3 RotateMatrixZ(float angle)
    {
        float radian = angle * Mathf.Deg2Rad;
        float cos = Mathf.Cos(radian);
        float sin = Mathf.Sin(radian);

        float[,] value = new float[3, 3]
        {
            {cos, -sin, 0 },
            {sin, cos, 0 },
            {0, 0, 1 }
        };

        return new E11Matrix3x3(value);
    }

    public static E11Matrix3x3 RotateMatrixY(float angle)
    {
        float radian = angle * Mathf.Deg2Rad;
        float cos = Mathf.Cos(radian);
        float sin = Mathf.Sin(radian);

        float[,] value = new float[3, 3]
        {
            {cos, 0, sin},
            {0, 1, 0},
            {-sin, 0, cos}
        };

        return new E11Matrix3x3(value);
    }

    public static E11Matrix3x3 RotateMatrixX(float angle)
    {
        float radian = angle * Mathf.Deg2Rad;
        float cos = Mathf.Cos(radian);
        float sin = Mathf.Sin(radian);

        float[,] value = new float[3, 3]
        {
            {1, 0, 0},
            {0, cos, -sin},
            {0, sin, cos}
        };

        return new E11Matrix3x3(value);
    }
}
