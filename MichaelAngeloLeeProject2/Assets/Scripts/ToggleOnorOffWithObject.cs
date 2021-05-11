using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnorOffWithObject : MonoBehaviour
{
    public GameObject objectToToggle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (objectToToggle.active == true)
            {
                objectToToggle.SetActive(false);
            }
            else
            {
                objectToToggle.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (objectToToggle.active == false)
            {
                objectToToggle.SetActive(true);
            }
            else
            {
                objectToToggle.SetActive(false);
            }
        }
    }


}