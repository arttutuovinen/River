using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FishMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _fishAgent;
    private Vector3 _currentTargetPosition;

    private void Start()
    {
        _currentTargetPosition = _fishAgent.transform.position;

        float randomSize = Random.Range(0.5f, 1f);
        _fishAgent.transform.localScale = new Vector3(randomSize, randomSize, randomSize);

        StartCoroutine(FishMovementCoroutine());
    }

    Vector3 GetRandomPointOnNavMesh()
    {
        // Set a random point within a specified range
        Vector3 randomPoint = new Vector3(
            Random.Range(_fishAgent.transform.position.x - 10f, _fishAgent.transform.position.x + 10f),
            transform.position.y,
            Random.Range(_fishAgent.transform.position.z - 10f, _fishAgent.transform.position.z + 10f)
        );

        // Use NavMesh.SamplePosition to get a valid position on the NavMesh
        if(NavMesh.SamplePosition(randomPoint, out NavMeshHit hit, 10.0f, NavMesh.AllAreas))
        {
            return hit.position;
        }

        return _currentTargetPosition;
    }

    private IEnumerator FishMovementCoroutine()
    {
        while (true)
        {
            if ((_fishAgent.transform.position - _currentTargetPosition).sqrMagnitude < 1f)
            {
                Vector3 newPosition = GetRandomPointOnNavMesh();

                if (newPosition != _currentTargetPosition)
                {
                    _currentTargetPosition = newPosition;
                    yield return new WaitForSeconds(Random.Range(0f, 2f));
                }
            }

            _fishAgent.SetDestination(_currentTargetPosition);

            yield return null;
        }
    }
}
