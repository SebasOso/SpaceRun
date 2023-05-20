using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLightManager : MonoBehaviour
{
    [SerializeField] private Light rotatingLight;
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private float radius = 5f;

    private Vector3 initialPosition;

    private void Start()
    {
        if (rotatingLight == null)
        {
            rotatingLight = GetComponent<Light>();
        }

        initialPosition = rotatingLight.transform.position;
    }

    private void Update()
    {
        // Calcula la nueva posición de la luz en el círculo
        float angle = Time.time * rotationSpeed;
        float x = Mathf.Sin(angle) * radius;
        float z = Mathf.Cos(angle) * radius;
        Vector3 newPosition = initialPosition + new Vector3(x, 0f, z);

        // Establece la nueva posición de la luz
        rotatingLight.transform.position = newPosition;
    }
}
