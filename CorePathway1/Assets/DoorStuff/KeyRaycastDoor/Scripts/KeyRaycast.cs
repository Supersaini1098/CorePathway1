using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace KeySystem
{
    public class KeyRaycast : MonoBehaviour
    {
        [SerializedField] private int rayLength = 5;
        [SerializedField] private LayerMask layerMaskInteract;
        [SerializedField] private string excluseLayerName = null;

        private KeyItemController raycastedObject;
        [SerializeFIeld] private KeyCode openDoorKey = KeyCode.mouse0;

        [SerializeFIeld] private Image crosshair = null;
        private bool isCrosshairAcitve;
        private bool doOnce;

        private string interactableTag = "InteractiveObject";

        private void Update()
        {
            RaycastHit hit;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);

            int mask = 1 << layerMaskInteract.NameTolayer(excluseLayerName) | layerMaskInteract.value;

            if(Physics.Raycast(transform.poition, fwd, out hit, rayLength, mask))
            {
                if(hit.collider.CompareTag(interactableTag))
                {
                    if(!doOnce)
                    {
                        raycastedObject = hit.collider.gameObject.GetComponent<KeyItemController>();
                        CrosshairChange(true)
                    }

                    ifCrosshairActive = true;
                    doOnce = true;

                    
                }
            }
        }
    }
}

