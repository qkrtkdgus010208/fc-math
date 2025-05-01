using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E12QuaternionController : MonoBehaviour
{
    [SerializeField] private GameObject spherePrefab;
    private GameObject[] spheres = new GameObject[1000];

    private void Start()
    {
        int size = 10;
        float offset = (size - 1) / 2f;

        for (int x = 0; x < size; x++)
        {
            for (int y = 0; y < size; y++)
            {
                for (int z = 0; z < size; z++)
                {
                    Vector3 position = new Vector3(x - offset, y - offset, z - offset);
                    GameObject sphere = Instantiate(spherePrefab, position, Quaternion.identity);
                    spheres[x * size * size + y * size + z] = sphere;
                }
            }
        }
    }

    private void Update()
    {
        float angle = 30 * Time.deltaTime;
        //Rotate(angle);

        float cos = Mathf.Cos(angle * Mathf.Deg2Rad / 2);
        float sin = Mathf.Sin(angle * Mathf.Deg2Rad / 2);

        E12Quaternion rotateQuaternion = new E12Quaternion(cos, sin, sin, 0);

        Rotate(rotateQuaternion);
    }

    private void Rotate(float angle)
    {
        E11Matrix3x3 rotationMatrixY = E11Matrix3x3.RotateMatrixY(angle);

        for (int i = 0; i < spheres.Length; i++)
        {
            Vector3 position = spheres[i].transform.position;
            Vector3 newPosition = E11Matrix3x3.Multiply(rotationMatrixY, position);
            spheres[i].transform.position = newPosition;
        }
    }

    private void Rotate(E12Quaternion rotateQuaternion)
    {
        for (int i = 0; i < spheres.Length; i++)
        {
            Vector3 position = spheres[i].transform.position;
            E12Quaternion q = new E12Quaternion(0, position.x, position.y, position.z);
            E12Quaternion newQ = E12Quaternion.Multifly(E12Quaternion.Multifly(rotateQuaternion, q), E12Quaternion.Conjugate(rotateQuaternion));
            Vector3 newPosition = new Vector3(newQ.x, newQ.y, newQ.z);
            spheres[i].transform.position = newPosition;
        }
    }
}
