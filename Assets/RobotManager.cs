using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using static UnityEditor.ShaderData;

public class RobotManager : MonoBehaviour
{
    [SerializeField]
    private float step = 1f;
    [SerializeField]
    private float velocity = 1f;
    [SerializeField]
    private GameObject key;
    [SerializeField]
    private GameObject door;
    [SerializeField]
    private AudioSource robotStep;
    [SerializeField]
    private AudioSource bip;
    public bool keyCollected = false;
    public static RobotManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }
    public void Up()
    {
        StartCoroutine(UpNum());
    }
    private IEnumerator UpNum()
    {
        float distanciaPaso = step;
        float tiempoPaso = Mathf.Abs(distanciaPaso) / velocity;
        bool isAudioPlaying = robotStep.isPlaying;  
        if(!isAudioPlaying)
        {
            robotStep.Play();
        }
        while (distanciaPaso > 0f)
        {
            float desplazamiento = Mathf.Min(distanciaPaso, velocity * Time.deltaTime);
            transform.Translate(new Vector3(0f, desplazamiento, 0f));
            distanciaPaso -= desplazamiento;
            yield return null;
        }
        robotStep.Stop();
    }
    public void Down()
    {
        StartCoroutine(DownNum());
    }
    private IEnumerator DownNum()
    {
        float distanciaPaso = step;
        float tiempoPaso = Mathf.Abs(distanciaPaso) / velocity;
        bool isAudioPlaying = robotStep.isPlaying;
        if (!isAudioPlaying)
        {
            robotStep.Play();
        }
        while (distanciaPaso > 0f)
        {
            float desplazamiento = Mathf.Min(distanciaPaso, velocity * Time.deltaTime);
            transform.Translate(new Vector3(0f, -desplazamiento, 0f));
            distanciaPaso -= desplazamiento;
            yield return null;
        }
        robotStep.Stop();
    }
    public void Left()
    {
        StartCoroutine(LeftNum());
    }
    private IEnumerator LeftNum()
    {
        float distanciaPaso = step;
        float tiempoPaso = Mathf.Abs(distanciaPaso) / velocity;
        bool isAudioPlaying = robotStep.isPlaying;
        if (!isAudioPlaying)
        {
            robotStep.Play();
        }
        while (distanciaPaso > 0f)
        {
            float desplazamiento = Mathf.Min(distanciaPaso, velocity * Time.deltaTime);
            transform.Translate(new Vector3(desplazamiento, 0f, 0f));
            distanciaPaso -= desplazamiento;
            yield return null;
        }
        robotStep.Stop();  
    }
    public void Right()
    {
        StartCoroutine(RightNum());
    }
    private IEnumerator RightNum()
    {
        float distanciaPaso = step;
        float tiempoPaso = Mathf.Abs(distanciaPaso) / velocity;
        bool isAudioPlaying = robotStep.isPlaying;
        if (!isAudioPlaying)
        {
            robotStep.Play();
        }
        while (distanciaPaso > 0f)
        {
            float desplazamiento = Mathf.Min(distanciaPaso, velocity * Time.deltaTime);
            transform.Translate(new Vector3(-desplazamiento, 0f, 0f));
            distanciaPaso -= desplazamiento;
            yield return null;
        }
        robotStep.Stop();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Key"))
        {
            keyCollected = true;
            key.SetActive(false);
            door.SetActive(true);
            bip.Play();
        }
    }
}
