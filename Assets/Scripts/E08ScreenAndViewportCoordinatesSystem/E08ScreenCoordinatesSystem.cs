using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class E08ScreenCoordinatesSystem : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        text.text = "Mouse Position: " + mousePosition;
    }
}
