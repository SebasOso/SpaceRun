using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBlockManager : MonoBehaviour
{
    [SerializeField] private GameObject tp;
    [SerializeField] private ParticleSystem ps;
    [SerializeField] private AudioSource audio;
    void Start()
    {
        tp.SetActive(false);
    }
    public void OnTP()
    {
        StartCoroutine(TP());
    }
    private IEnumerator TP()
    {
        ps.Play();
        yield return new WaitForSeconds(audio.clip.length);
        ps.Pause();
        tp.SetActive(true);
    }
}
