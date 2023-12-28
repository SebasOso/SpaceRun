using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textMeshProUGUI;
    private float minutes = 0;  
    private void Start()
    {
        minutes = GameManager.Instance.tiempoTranscurrido / 60;
        textMeshProUGUI.text = minutes + (" MINUTES :D");
    }
}
