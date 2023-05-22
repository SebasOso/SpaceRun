using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBlockManager : MonoBehaviour
{
    [SerializeField] private GameObject tp;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private AudioSource audioWeld;
    [SerializeField] private GameObject door;
    [SerializeField] private AudioSource win;
    [SerializeField] private GameObject[] knifeList;
    [SerializeField] private AudioSource guideOne;
    [SerializeField] private AudioSource guideTwo;
    void Start()
    {
        tp.SetActive(false);
        guideOne.Play();    
    }
    public void OnTP()
    {
        StartCoroutine(TP());
    }
    private IEnumerator TP()
    {
        ps.Play();
        audioWeld.Play();
        yield return new WaitForSeconds(audioWeld.clip.length);
        ps.Pause();
        tp.SetActive(true);
        Destroy(door);
        foreach (GameObject go in knifeList)
        {
            go.SetActive(false);
        }
        win.Play();
        guideTwo.Play();
    }
}
