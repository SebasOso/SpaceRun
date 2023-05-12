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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BateryOne.SnappedGameObject != null && BateryTwo.SnappedGameObject != null)
        {
            bigCollider.SetActive(true);
        }
    }
}
