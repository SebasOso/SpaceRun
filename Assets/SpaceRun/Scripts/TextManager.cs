using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    [SerializeField]
    GameObject textOne;
    [SerializeField]
    GameObject textTwo;
    private void Start()
    {
        StartCoroutine(TextEnumerator());
    }
    private IEnumerator TextEnumerator()
    {
        yield return new WaitForSeconds(14);
        textOne.SetActive(false);
        textTwo.SetActive(true);
    }
}
