using System.Collections;
using System.Collections.Generic;
using Tilia.Interactions.Controllables.AngularDriver;
using Tilia.Interactions.Interactables.Interactables;
using UnityEngine;

public class BatteriesManager : MonoBehaviour
{
    [SerializeField] private bool snapOne = false;
    [SerializeField] private bool snapTwo = false;
    [SerializeField] private bool snapThree = false;
    [SerializeField] private GameObject palanca;
    [SerializeField] private InteractableFacade gravityGun;
    private void Start()
    {
        snapOne = false;
        snapTwo = false;
        snapThree = false;
    }
    void Update()
    {
        if (snapOne == true && snapTwo == true && snapThree == true)
        {
            palanca.SetActive(true);
            gravityGun.EnableGrabReceiver();
        }
        else
        {
            palanca.SetActive(false);
        }
    }
    public void SnapOne()
    {
        snapOne = true;
    }
    public void SnapTwo()
    {
        snapTwo = true;
    }
    public void SnapThree()
    {
        snapThree = true;
    }
}
