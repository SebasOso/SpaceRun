using System.Collections;
using System.Collections.Generic;
using Tilia.Interactions.Interactables.Interactables;
using Tilia.Interactions.SnapZone;
using UnityEngine;

public class SnapKnifePartManager : MonoBehaviour
{
    [SerializeField] public bool isKnifeAndHandleSnapped = false;
    [SerializeField] private GameObject snapZoneKnifePart;
    [SerializeField] private SnapZoneFacade snapBladePart;
    [SerializeField] private SnapZoneFacade snapBatteriesPart;
    [SerializeField] private GameObject bigCollider;
    [SerializeField] private InteractableFacade interactable; 
    void Update()
    {
        if(SnapBateriesManager.Instance.isBatteriesDone && SnapBateriesManager.Instance.isBladeDone)
        {
            interactable.EnableGrab();
        }
        else
        {
            interactable.DisableGrab();
        }
        if (SnapBateriesManager.Instance.isBladeDone)
        {
            snapZoneKnifePart.SetActive(true);
        }
        else
        {
            snapZoneKnifePart.SetActive(false);
        }
        if (snapBladePart.SnappedGameObject != null && snapBatteriesPart.SnappedGameObject != null)
        {
            bigCollider.SetActive(true);
        }
    }
}
