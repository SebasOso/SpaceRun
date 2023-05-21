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
    [SerializeField] private AngularDriveFacade driveFacadeOne;
    [SerializeField] private AngularDriveFacade driveFacadeTwo;
    [SerializeField] private AngularDriveFacade driveFacadeThree;
    [SerializeField]private bool isButtonOneGreen;
    [SerializeField]private bool isButtonTwoGreen;
    [SerializeField] private bool isButtonThreeGreen;
    [SerializeField] private bool isSoundPlayed;
    [SerializeField] private GameObject extintor;
    [SerializeField] private AudioSource extintorOne;
    void Update()
    {
        Lever01();
        Lever02();
        Lever03();
    }
    private void Lever02()
    {
        float rotationX = leverTwo.transform.rotation.eulerAngles.x;
        if (rotationX >= 270 && rotationX <= 320)
        {
            buttomTwo.GetComponent<Renderer>().material = green;
            isButtonTwoGreen = true;
        }
        else
        {
            buttomTwo.GetComponent<Renderer>().material = red;
            isButtonTwoGreen=false;
        }
        if (isButtonOneGreen && isButtonTwoGreen && isButtonThreeGreen && !source.isPlaying && !isSoundPlayed)
        {
            source.Play();
            driveFacadeOne.enabled = false;
            driveFacadeTwo.enabled = false;
            driveFacadeThree.enabled = false;
            isSoundPlayed = true;
            extintor.SetActive(true);
            extintorOne.Play(); 
        }
    }
    private void Lever01()
    {
        float rotationX = leverOne.transform.rotation.eulerAngles.x;
        if (rotationX >= 60 && rotationX <= 110)
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
        if (rotationX >= 0 && rotationX <= 40)
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
