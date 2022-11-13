using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFactor : MonoBehaviour
{
    public int JumpFac = 3;
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= JumpFac;
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= JumpFac;
    }
}
