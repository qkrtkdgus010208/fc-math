using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E11RotationMatrixController : MonoBehaviour
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
        Rotate(angle);
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
}
