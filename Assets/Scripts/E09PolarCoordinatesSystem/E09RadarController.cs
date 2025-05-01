using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E09RadarController : MonoBehaviour
{
    [SerializeField] GameObject DotPrefab;
    [SerializeField] Transform radarTransform;

    private float rotationSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed);

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 10f))
        {
            GameObject hitObject = hit.collider.gameObject;

            float r = Vector3.Distance(transform.position, hitObject.transform.position);

            Vector3 enemyPosition = ConvertToCartesian(r, Mathf.Abs(transform.localEulerAngles.y - 360 - 90));

            Debug.Log("Enemy position: " + enemyPosition);

            StartCoroutine(displayEnemyPosition(enemyPosition));

            Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.red);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.forward * 10f, Color.green);
        }
    }

    IEnumerator displayEnemyPosition(Vector3 position)
    {
        GameObject dot = Instantiate(DotPrefab, radarTransform);
        RectTransform dotTransform = dot.GetComponent<RectTransform>();
        dotTransform.anchoredPosition = new Vector2(position.x, position.y) * 30f;

        yield return new WaitForSeconds(0.8f);
        Destroy(dot);   
    }

    Vector2 ConvertToCartesian(float radius, float angle)
    {
        float x = radius * Mathf.Cos(angle * Mathf.Deg2Rad);
        float y = radius * Mathf.Sin(angle * Mathf.Deg2Rad);
        return new Vector2(x, y);
    }
}
