using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float tiempoTranscurrido;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        tiempoTranscurrido = Time.realtimeSinceStartup; 
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("End");
    }
}
