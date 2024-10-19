using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    // private Vector3 startPosition;
    // private Vector4 roamPosition;
    // [SerializeField] private float minRoamingRange = 10f;
    // [SerializeField] private float maxRoamingRange = 70f;
    private NavMeshAgent agent;
    // [SerializeField] private Rigidbody rb;
    // private float gravityMultiplier = 2f;

    [SerializeField] private Transform target;
    
    private void Start(){
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update(){ //should be start
        // startPosition = transform.position;
        // roamPosition = GetNewRoamingPosition();
        if(target != null && Vector3.Distance(transform.position, target.position) > 30.0f){
            Debug.Log("YEEYES");
            agent.SetDestination(target.position);
        }
    }

    // private Vector3 GetNewRoamingPosition(){
    //     Vector3 randDir = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    //     float roamingRange = Random.Range(minRoamingRange, maxRoamingRange);
    //     Vector3 newPos = startPosition + randDir * roamingRange;
    //     return newPos;
    // }

    // void Update(){
    //     // agent.destination = roamPosition;
    //     // if (Vector3.Distance(transform.position, roamPosition) < 10f){
    //     //     Debug.Log("NEW LOCATION");
    //     //     roamPosition = GetNewRoamingPosition();
    //     // }
    //     // else{
    //     //     Debug.Log("Walking");
    //     // }

    // }

    // void FixedUpdate(){
    //     Vector3 customGravity = Physics.gravity * gravityMultiplier;
    //     rb.AddForce(customGravity, ForceMode.Acceleration);
    // }
}
