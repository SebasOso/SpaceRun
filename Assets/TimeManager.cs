using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textMeshProUGUI;
    private void Start()
    {
        textMeshProUGUI.text = GameManager.Instance.tiempoTranscurrido + (" SECONDS :D");
    }
}
