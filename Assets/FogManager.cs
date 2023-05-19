using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class FogManager : MonoBehaviour
{
    [SerializeField] private Transform m_transform;
    [SerializeField] private VisualEffect m_effect;
    void Update()
    {
        m_effect.SetVector3("ColliderPos", m_transform.position);
    }
}
