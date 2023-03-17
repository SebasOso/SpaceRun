using System.Collections;
using System.Collections.Generic;
using Tilia.Interactions.Controllables.AngularDriver;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public AngularDriveFacade angularDriveFacade;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wand"))
        {
            Debug.Log("TRIGEEER");
            angularDriveFacade.MoveToTargetValue = true;
            angularDriveFacade.TargetValue = 1;
        }
    }
}
