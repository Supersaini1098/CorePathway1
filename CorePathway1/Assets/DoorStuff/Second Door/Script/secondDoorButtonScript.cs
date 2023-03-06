using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondDoorButtonScript : MonoBehaviour
{
    public GameObject objectToAppear;
    public LayerMask layerMask;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100, layerMask))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    objectToAppear.SetActive(true);
                }
            }
        }
    }
}