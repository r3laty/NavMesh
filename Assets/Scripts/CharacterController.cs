using UnityEngine;
using UnityEngine.AI;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private GameObject[] targets;

    private int _currentIndex;
    private void Start()
    {
        //agent.destination = target.transform.position;
    }
    private void Update()
    {
        if (_currentIndex <= targets.Length - 1)
        {
            agent.destination = targets[_currentIndex].transform.position;
            _currentIndex++;
        }
    }
}
