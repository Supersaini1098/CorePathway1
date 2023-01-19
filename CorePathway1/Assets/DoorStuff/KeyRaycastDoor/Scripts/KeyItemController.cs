using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool frontDoor = false;
        [SerializeField] private bool frontDoorKey = false;

        [SerializeField] private keyInventory _keyInventory = null;

        private KeyDoorController doorObject;

        private void Start()
        {
            if (frontDoor)
            {
                doorObject = GetComponent<KeyDoorController>();
            }
        }

        public void ObjectInteraction()
        {
            if (frontDoor)
            {
                doorObject.PlayAnimation();
            }

            else if (frontDoorKey)
            {
                _keyInventory.hasFrontDoorKey = true;
                gameObject.SetSctive(false);
            }
        }
    }

}
