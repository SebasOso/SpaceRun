using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoorOpen : MonoBehaviour
{
    [SerializeField] private GameObject m_Door;
    [SerializeField] private GameObject m_DoorOpen;
    [SerializeField] private AudioSource audioDoor;
    [SerializeField] private AudioSource completed;
    [SerializeField] private float doorOpenSpeed = 2f;
    [SerializeField] private float doorOpenDistance = 5f;
    [SerializeField] private GameObject keyCompleted;

    private Vector3 initialPosition;
    private Vector3 targetPosition;
    private bool isOpening = false;
    private bool wasOpenYet = false;

    void Start()
    {
        initialPosition = m_Door.transform.position;
        targetPosition = initialPosition + Vector3.up * doorOpenDistance;
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
    public void OpenDoor()
    {
        if(RobotManager.Instance.keyCollected == true && !wasOpenYet)
        {
            isOpening = true;
            m_Door.GetComponent<Collider>().enabled = false;
            audioDoor.Play();
            completed.Play();
            keyCompleted.SetActive(true);
            wasOpenYet = true;
        }
    }
}
