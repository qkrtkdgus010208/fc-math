using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E07CrossProduct : MonoBehaviour
{
    [SerializeField] private Transform sphereTransform;

    Vector3 v1 = new Vector3(1, 0, 0);
    Vector3 v2 = new Vector3(0, 0, 1);
    Vector3 origin = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 normalVector = Vector3.Cross(v2, v1);
        var dotProduct = Vector3.Dot(sphereTransform.position, normalVector);

        Debug.Log(dotProduct);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(origin, origin + v1);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(origin, origin + v2);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(origin, origin + Vector3.Cross(v2, v1));
    }
}
