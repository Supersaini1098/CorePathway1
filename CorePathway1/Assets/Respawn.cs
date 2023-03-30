using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;
    public Transform AIRespawnPoint;


    public void RespawnPlayer()
    {
        transform.position = respawnPoint.position;
    }

    public void RespawnPlayerAI()
    {
        transform.position = AIRespawnPoint.position;
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DeathZone"))
        {
            RespawnPlayer();
        }

        if (collision.gameObject.CompareTag("AI"))
        {
            RespawnPlayerAI();
        }
    }
}
