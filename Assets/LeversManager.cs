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
    void Update()
    {
        Lever01();
        Lever02();
        //Lever03();
    }
    private void Lever01()
    {
        if(leverOne.transform.rotation.x >= -90 && leverOne.transform.rotation.x <= -70)
        {
            Debug.Log("aaaaaaaaaaaa");
            buttomOne.GetComponent<Renderer>().material = green;    
        }
        else
        {
            buttomOne.GetComponent<Renderer>().material = red;
        }
    }
    private void Lever02()
    {
        if (leverTwo.transform.rotation.x <= 20 && leverTwo.transform.rotation.x >= 0)
        {
            buttomTwo.GetComponent<Renderer>().material = green;
        }
        else
        {
            buttomTwo.GetComponent<Renderer>().material = red;
        }
    }
    private void Lever03()
    {
        if (leverThree.transform.rotation.x <= -70  && leverThree.transform.rotation.x >= -90)
        {
            buttomThree.GetComponent<Renderer>().material = green;
        }
        else
        {
            buttomThree.GetComponent<Renderer>().material = red;
        }
    }
}
