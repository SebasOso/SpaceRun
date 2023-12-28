using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    [SerializeField] GameObject gravity;
    [SerializeField] public bool isPistolGrabbed = false;
    void Update()
    {
        if(isPistolGrabbed)
        {
            gravity.SetActive(true);
        }
        else
        {
            gravity.SetActive(false);
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
