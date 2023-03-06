using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoorScript : MonoBehaviour
{
    public Animator animator;
    public GameObject key;

    private bool isLocked = true;
    private bool isOpen = false;

    private void Start()
    {
        animator.SetBool("IsOpen", false);
    }

    private void Update()
    {
        if (!isLocked && Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    if (!isOpen)
                    {
                        animator.SetBool("isOpen", true);
                        isOpen = true;
                        Debug.Log("open");
                    }
                    else
                    {
                        animator.SetBool("isOpen", false);
                        isOpen = false;
                        Debug.Log("close");
                    }
                }
            }
        }
    }

    public void Unlock()
    {
        isLocked = false;
        key.SetActive(false);
    }
}