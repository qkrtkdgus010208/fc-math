using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E12Quaternion
{
    public float w, x, y, z;

    public E12Quaternion(float w, float x, float y, float z)
    {
        this.w = w;
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public static E12Quaternion Multifly(E12Quaternion q1, E12Quaternion q2)
    {
        float w = q1.w * q2.w - q1.x * q2.x - q1.y * q2.y - q1.z * q2.z;
        float x = q1.w * q2.x + q1.x * q2.w + q1.y * q2.z - q1.z * q2.y;
        float y = q1.w * q2.y - q1.x * q2.z + q1.y * q2.w + q1.z * q2.x;
        float z = q1.w * q2.z + q1.x * q2.y - q1.y * q2.x + q1.z * q2.w;

        return new E12Quaternion(w, x, y, z);
    }

    public static E12Quaternion Conjugate(E12Quaternion q)
    {
        return new E12Quaternion(q.w, -q.x, -q.y, -q.z);
    }
}
