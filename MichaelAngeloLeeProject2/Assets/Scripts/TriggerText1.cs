using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You're finally awake! You must be wondering where you are...Seems like you lost your memories. To get them back, clear the stages and get a hold of the Holy Grail.");
    }
}
