using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Data.Type;

public class LightManager : MonoBehaviour
{
    [SerializeField]
    private Light _light;
    [SerializeField]
    private float velocity = 1f;
    private float timer = 0f;
    void Update()
    {
        timer += Time.deltaTime * velocity;
        float intensity = Mathf.Lerp(1f, 4f, Mathf.Sin(timer));
        _light.intensity = intensity;
    }
}
