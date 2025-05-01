using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E05MoveObject : MonoBehaviour
{
    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Plane"))
                {
                    targetPosition = hit.point;
                    Debug.Log($"targetPosition: {targetPosition}");
                }
            }
        }

        Vector3 target = targetPosition - transform.position;
        if (target.magnitude > 0.1f)
        {
            Vector3 normalizedTarget1 = target / Mathf.Sqrt(Mathf.Pow(target.x, 2) + Mathf.Pow(target.y, 2) + Mathf.Pow(target.z, 2));
            Vector3 normalizedTarget2 = target / target.magnitude;
            Vector3 normalizedTarget3 = target.normalized;

            Debug.Log($"normalizedTarget1: {normalizedTarget1}");

            transform.Translate(normalizedTarget1 * Time.deltaTime * 5f);
        }
    }
}
