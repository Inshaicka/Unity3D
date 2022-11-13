using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public int speedFactor = 3;

    void OnTriggerEnter(Collider other)
    {
        //���������� �������� ���� ������
        other.GetComponent<FirstPersonMovement>().speed *= speedFactor;
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //��������� �������� ���� ������
        other.GetComponent<FirstPersonMovement>().speed /= speedFactor;
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}