using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tilia;
using Tilia.Interactions.SnapZone;

public class SnapBateriesManager : MonoBehaviour
{
    [SerializeField] private SnapZoneFacade BateryOne;
    [SerializeField] private SnapZoneFacade BateryTwo;
    [SerializeField] private GameObject bigCollider;
    public bool isBatteriesDone = false;
    public bool isBladeDone =  false;
    public static SnapBateriesManager Instance {  get; private set; }
    private void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        if (BateryOne.SnappedGameObject != null && BateryTwo.SnappedGameObject != null)
        {
            bigCollider.SetActive(true);
            isBatteriesDone = true;
        }
    }
    public void BladeDone()
    {
        isBladeDone = true;
    }
}
