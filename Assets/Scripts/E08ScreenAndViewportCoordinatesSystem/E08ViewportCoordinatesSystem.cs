using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E08ViewportCoordinatesSystem : MonoBehaviour
{
    [SerializeField] GameObject cubePrefab;

    Vector3 viewportPosition = new Vector3(1f, 0.5f, 0f);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 worldPosition = Camera.main.ViewportToWorldPoint(new Vector3(viewportPosition.x, 
                viewportPosition.y, Camera.main.nearClipPlane + 10f));

            Instantiate(cubePrefab, worldPosition, Quaternion.identity);
        }
    }
}
