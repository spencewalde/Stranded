using UnityEngine;
using System.Collections;

public class AIAnimal : MonoBehaviour {

    public Transform[] Waypoints;
    public int NextDest = 0;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (agent.remainingDistance < 0.5f)
        {
            agent.SetDestination(Waypoints[NextDest].position);
            NextDest = (NextDest + 10) % Waypoints.Length;
        }
    }
}
