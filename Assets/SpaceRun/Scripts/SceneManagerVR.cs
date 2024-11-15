using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerVR : MonoBehaviour
{
    [SerializeField] private GameObject uiOne;
    [SerializeField] private GameObject uiTwo;
    void Start()
    {
        StartCoroutine(Wait());
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(8);
        uiOne.SetActive(false);
        uiTwo.SetActive(true);
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("LevelOne");
    }
}
