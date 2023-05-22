using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplossionManager : MonoBehaviour
{
    [SerializeField] List<Rigidbody> breakableDoor = new List<Rigidbody>();
    [SerializeField] AudioSource ticTac;
    private bool hasBeenTouched = false;
    [SerializeField] private GameObject door;
    [SerializeField] private List<GameObject> rests;
    [SerializeField] private ParticleSystem explossionPS;
    [SerializeField] private AudioSource explosionAudio;
    [SerializeField] private AudioSource GUIDEFOUR;
    [SerializeField] public bool isC4 = false;
 
    private void OnTriggerEnter(Collider other)
    {
        if(isC4)
        {
            if (other.CompareTag("ManoDerecha") && !hasBeenTouched)
            {
                StartCoroutine(TicTac(ticTac, breakableDoor, door));
                hasBeenTouched = true;
            }
        }
    }
    private IEnumerator TicTac(AudioSource audioSource, List<Rigidbody> breakableDoor, GameObject door)
    {
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
        door.SetActive(false);
        foreach (Rigidbody rb in breakableDoor)
        {
            rb.isKinematic = false;
        }
        explossionPS.Play();
        explosionAudio.Play();
        yield return new WaitForSeconds(5);
        foreach (GameObject go in rests)
        {
            go.SetActive(false);
            GUIDEFOUR.Play();   
        }
    }
    private IEnumerator DissapearRest(List<GameObject> rests)
    {
        yield return new WaitForSeconds(5);
        foreach (GameObject go in rests)
        {
            go.SetActive(false);
        }
    }
    public void C4()
    {
        isC4 = true;
    }
}
