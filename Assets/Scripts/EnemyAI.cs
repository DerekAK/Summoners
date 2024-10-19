using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector4 roamPosition;
    [SerializeField] private float minRoamingRange = 10f;
    [SerializeField] private float maxRoamingRange = 70f;

    [SerializeField] private NavMeshAgent agent;
    
    private void Start(){
        startPosition = transform.position;
        roamPosition = GetNewRoamingPosition();
    }

    private Vector3 GetNewRoamingPosition(){
        Vector3 randDir = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        float roamingRange = Random.Range(minRoamingRange, maxRoamingRange);
        Vector3 newPos = startPosition + randDir * roamingRange;
        return newPos;
    }

    void Update(){
        agent.destination = roamPosition;
        if (Vector3.Distance(transform.position, roamPosition) < 1f){
            roamPosition = GetNewRoamingPosition();
        }
    }
}
