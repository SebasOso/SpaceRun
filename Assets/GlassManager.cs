using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Data.Operation.Extraction;

public class GlassManager : MonoBehaviour
{
    [SerializeField] List<GameObject> glass;
    [SerializeField] private AudioSource breakGlass;
    private bool hasExtintor;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Extintor") && !hasExtintor)
        {
            Glass();
            StartCoroutine(DissapearGlass());
            hasExtintor = true;
        }
    }
    private void Glass()
    {
        breakGlass.Play();
        foreach(GameObject go in glass)
        {
            go.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
    private IEnumerator DissapearGlass()
    {
        yield return new WaitForSeconds(5);
        foreach(GameObject go in glass)
        {
            go.SetActive(false);
        }
    }
}
