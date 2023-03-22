using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorKey : MonoBehaviour
{
    [SerializeField] GameObject key;
    public void Blue()
    {
        key.GetComponent<Renderer>().material.color = Color.blue;
    }
       
    public void Red()
    {
        key.GetComponent<Renderer>().material.color = Color.red;
    }
}
