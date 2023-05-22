using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleKeyDoor : MonoBehaviour
{
    [SerializeField] private GameObject m_Door;
    [SerializeField] private GameObject m_DoorOpen;
    [SerializeField] private AudioSource audioDoor;
    [SerializeField] private AudioSource completed;
    [SerializeField] private AudioSource GUIDESIX;
    [SerializeField] private float doorOpenSpeed = 2f;
    [SerializeField] private float doorOpenDistance = 5f;

    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private bool isOpening = false;
    private bool wasOpenYet = false;

    void Start()
    {
        initialPosition = m_Door.transform.position;
        targetPosition = initialPosition + Vector3.back * doorOpenDistance;
    }
    void Update()
    {
        if (isOpening)
        {
            float step = doorOpenSpeed * Time.deltaTime;
            m_Door.transform.position = Vector3.Lerp(m_Door.transform.position, targetPosition, step);

            if (Vector3.Distance(m_Door.transform.position, targetPosition) < 0.01f)
            {
                isOpening = false;
                m_DoorOpen.SetActive(true);
                m_Door.SetActive(false);
            }
        }
    }
    private void OpenDoor()
    {
        if (!wasOpenYet)
        {
            isOpening = true;
            m_Door.GetComponent<Collider>().enabled = false;
            audioDoor.Play();
            completed.Play();
            wasOpenYet = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Key"))
        {
            OpenDoor();
        }
    }
}
