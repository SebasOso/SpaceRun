using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    [SerializeField] GameObject Text;
    private bool hasShowned;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aaaaaaaaaaaaaaa");
        if(other.CompareTag("ManoDerecha"))
        {
            Debug.Log("DERECHAAAAAAAAA");
            if (!hasShowned)
            {
                Text.SetActive(true);
                hasShowned = true;
            }
        }
    }
}
