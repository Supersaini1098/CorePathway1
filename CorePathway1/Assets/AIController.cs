using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(player.transform.position);
        agent.speed = speed;
    }
}
