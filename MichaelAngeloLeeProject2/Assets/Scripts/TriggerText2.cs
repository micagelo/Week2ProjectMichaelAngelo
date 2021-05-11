using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Did I ever tell you that bumping into a tree can reveal something? No? Well then.");
    }
}
