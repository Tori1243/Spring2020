using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiPlayer : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform Player, destination;
    private void Start()
    {
        destination = Player;
        agent = GetComponent<NavMeshAgent>();
    }
    
    private void Update()
    {
        agent.destination = destination.position;
        destination = Player;
    }
}