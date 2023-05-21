using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    [SerializeField] private GameObject lightDoor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Robot"))
        {
            lightDoor.SetActive(true);
        }
    }
}
