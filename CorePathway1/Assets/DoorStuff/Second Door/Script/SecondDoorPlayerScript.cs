
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoorPlayerScript : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    private bool hasKey = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key)
        {
            Destroy(key);
            hasKey = true;
        }
    }

    private void Update()
    {
        if (hasKey && Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == door)
                {
                    Animator doorAnimator = door.GetComponent<Animator>();
                    doorAnimator.SetTrigger("IsOpen");
                }
            }
        }
    }
}