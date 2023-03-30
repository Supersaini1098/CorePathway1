using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformController : MonoBehaviour
{
    public Vector3 movementVector = new Vector3(0, 0, 5);
    public float speed = 2;

    private Vector3 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
        
    }

    private void FixedUpdate()
    {
        float pingPong = Mathf.PingPong(Time.time * speed, 1);
        Vector3 movement = movementVector * pingPong;
        Vector3 targetPosition = startingPosition + movement;
        GetComponent<Rigidbody>().MovePosition(targetPosition);
    }
}


