using UnityEngine;
using UnityEngine.AI;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject[] targets;
    
    //method on button
    public void RunAround()
    {
        agent.destination = targets[Random.Range(0, targets.Length)].transform.position;
    }

    private void Start()
    {
        agent.destination = targets[Random.Range(0, targets.Length)].transform.position;
    }
    
}
