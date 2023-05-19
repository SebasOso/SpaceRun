using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    [SerializeField] GameObject Text;
    private bool hasShowned;
    [SerializeField] AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("aaaaaaaaaaaaaaa");
        if(other.CompareTag("ManoDerecha"))
        {
            Debug.Log("DERECHAAAAAAAAA");
            if (!hasShowned)
            {
                StartCoroutine(ScannerLenght());
                hasShowned = true;
            }
        }
    }
    private IEnumerator ScannerLenght()
    {
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        Text.SetActive(true);
    }
}
