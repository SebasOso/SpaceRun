using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ButtomsManager : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    public TextMeshProUGUI numberInScreen;
    private bool puzzleCompleted;
    private string concatenatedString = "";
    public OpenDoorManager openDoorManager;
    private string randomCombination;
    void Start()
    {
        GenerateRandomCombination();
        numberInScreen.text = randomCombination;
    }
    void GenerateRandomCombination()
    {
        randomCombination = "";

        for (int i = 0; i < 4; i++)
        {
            int randomNumber = Random.Range(0, 10);
            randomCombination += randomNumber.ToString();
        }
    }
    public void HandleButtonClick(string buttonNumber)
    {
        if (!puzzleCompleted)
        {
            concatenatedString += buttonNumber;

            if (concatenatedString.Length >= 4)
            {
                if (concatenatedString == randomCombination)
                {
                    Debug.Log("Puzzle completado");
                    puzzleCompleted = true;
                    openDoorManager.OpenDoor();
                }
                else
                {
                    concatenatedString = "";
                    Debug.Log("Puzzle reiniciado");
                }
            }
            UpdateNumberText();
        }
    }
    void UpdateNumberText()
    {
        numberText.text = concatenatedString;
    }
}
