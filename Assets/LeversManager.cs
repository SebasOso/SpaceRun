using System.Collections;
using System.Collections.Generic;
using Tilia.Interactions.Controllables.AngularDriver;
using UnityEngine;

public class LeversManager : MonoBehaviour
{
    [SerializeField] private GameObject leverOne;
    [SerializeField] private GameObject leverTwo;
    [SerializeField] private GameObject leverThree;
    [SerializeField] private GameObject buttomOne;
    [SerializeField] private GameObject buttomTwo;
    [SerializeField] private GameObject buttomThree;
    [SerializeField] private Material green;
    [SerializeField] private Material red;
    [SerializeField] private AudioSource source;
    private AngularDriveFacade driveFacade;
    private bool isButtonOneGreen;
    private bool isButtonTwoGreen;
    private bool isButtonThreeGreen;
    void Update()
    {
        Lever01();
        Lever02();
        Lever03();
        if (isButtonOneGreen && isButtonTwoGreen && isButtonThreeGreen)
        {
            source.Play();
            driveFacade.enabled = false;
        }
    }
    private void Lever02()
    {
        float rotationX = leverTwo.transform.rotation.eulerAngles.x;
        if (rotationX >= 290 && rotationX <= 300)
        {
            buttomTwo.GetComponent<Renderer>().material = green;
            isButtonTwoGreen = true;
        }
        else
        {
            buttomTwo.GetComponent<Renderer>().material = red;
            isButtonTwoGreen=false;
        }
    }
    private void Lever01()
    {
        float rotationX = leverOne.transform.rotation.eulerAngles.x;
        if (rotationX >= 70 && rotationX <= 90)
        {
            buttomOne.GetComponent<Renderer>().material = green;
            isButtonOneGreen = true;
        }
        else
        {
            buttomOne.GetComponent<Renderer>().material = red;
            isButtonOneGreen=false;
        }
    }
    private void Lever03()
    {
        float rotationX = leverThree.transform.rotation.eulerAngles.x;
        if (rotationX >= 0 && rotationX <= 20)
        {
            buttomThree.GetComponent<Renderer>().material = green;
            isButtonThreeGreen = true;
        }
        else
        {
            buttomThree.GetComponent<Renderer>().material = red;
            isButtonThreeGreen=false;
        }
    }

}
