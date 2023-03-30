using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject doorToOpen;

    public void OnButtonPress()
    {
        Animator doorAnimator = doorToOpen.GetComponent<Animator>();
        if (doorAnimator != null)
        {
            bool isDoorOpen = doorAnimator.GetBool("IsOpen");

            // Toggle the "IsOpen" parameter to switch between opening and closing the door.
            doorAnimator.SetBool("IsOpen", !isDoorOpen);
        }
    }

    void Update()
    {
        // Cast a ray from the player's cursor and check if it hits the button collider.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
        {
            // The player is hovering over the button, so check if they've clicked.
            if (Input.GetMouseButtonDown(0))
            {
                OnButtonPress();
            }
        }
    }
}