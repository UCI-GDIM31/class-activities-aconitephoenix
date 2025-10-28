using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private float _moveSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    
    NavMeshAgent _deerNavMeshAgent;
    Vector3 movement = Vector3.zero;
    Vector3 destination = Vector3.zero;

    private void Start()
    {
        _transform = GetComponent<Transform>();
        destination = _transform.position;
        _deerNavMeshAgent = GetComponent<NavMeshAgent>();
        _deerNavMeshAgent.SetDestination(destination);
    }

    private void Update()
    {
        transform.Translate(movement * _moveSpeed * Time.deltaTime);
    }
}