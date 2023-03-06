using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoorKeyScript : MonoBehaviour
{
    public GameObject keyObject;
    public bool hasKey = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            keyObject.SetActive(false);
            hasKey = true;
        }
    }
}

