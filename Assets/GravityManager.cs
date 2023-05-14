using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    [SerializeField] GameObject gravity;
    [SerializeField] GameObject trigger;
    [SerializeField] public bool isPistolGrabbed = false;
    void Update()
    {
        if(isPistolGrabbed)
        {
            gravity.SetActive(true);
            trigger.SetActive(true);
        }
        else
        {
            gravity.SetActive(false);
            trigger.SetActive(false);
        }
    }
    public void GrabbedPistol()
    {
        isPistolGrabbed=true;
    }
    public void OffPistol()
    {
        isPistolGrabbed = false;
    }
}
