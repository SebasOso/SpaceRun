using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.ShaderData;

public class RobotManager : MonoBehaviour
{
    [SerializeField]
    private float step = 1f;
    [SerializeField]
    private float velocity = 1f;
    public void Up()
    {
        StartCoroutine(UpNum());
    }
    private IEnumerator UpNum()
    {
        float distanciaPaso = step;
        float tiempoPaso = Mathf.Abs(distanciaPaso) / velocity;

        while (distanciaPaso > 0f)
        {
            float desplazamiento = Mathf.Min(distanciaPaso, velocity * Time.deltaTime);
            transform.Translate(new Vector3(0f, desplazamiento, 0f));
            distanciaPaso -= desplazamiento;
            yield return null;
        }
    }
    public void Down()
    {
        StartCoroutine(DownNum());
    }
    private IEnumerator DownNum()
    {
        float distanciaPaso = step;
        float tiempoPaso = Mathf.Abs(distanciaPaso) / velocity;

        while (distanciaPaso > 0f)
        {
            float desplazamiento = Mathf.Min(distanciaPaso, velocity * Time.deltaTime);
            transform.Translate(new Vector3(0f, -desplazamiento, 0f));
            distanciaPaso -= desplazamiento;
            yield return null;
        }
    }
    public void Left()
    {
        StartCoroutine(LeftNum());
    }
    private IEnumerator LeftNum()
    {
        float distanciaPaso = step;
        float tiempoPaso = Mathf.Abs(distanciaPaso) / velocity;

        while (distanciaPaso > 0f)
        {
            float desplazamiento = Mathf.Min(distanciaPaso, velocity * Time.deltaTime);
            transform.Translate(new Vector3(desplazamiento, 0f, 0f));
            distanciaPaso -= desplazamiento;
            yield return null;
        }
    }
    public void Right()
    {
        StartCoroutine(RightNum());
    }
    private IEnumerator RightNum()
    {
        float distanciaPaso = step;
        float tiempoPaso = Mathf.Abs(distanciaPaso) / velocity;

        while (distanciaPaso > 0f)
        {
            float desplazamiento = Mathf.Min(distanciaPaso, velocity * Time.deltaTime);
            transform.Translate(new Vector3(-desplazamiento, 0f, 0f));
            distanciaPaso -= desplazamiento;
            yield return null;
        }
    }
}
