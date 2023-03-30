using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotScript : MonoBehaviour
{
    public Transform target; // the player's Transform
    public float speed = 5.0f; // the bot's movement speed
    private UnityEngine.AI.NavMeshAgent agent; // reference to the AI navigation system

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        // set the bot's destination to the player's position
        agent.SetDestination(target.position);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // bot has collided with the player, respawn it
            collision.gameObject.GetComponent<Respawn>().RespawnPlayerAI();
        }
    }
}
