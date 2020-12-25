using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class LegoMovement : MonoBehaviour
{

    GameObject gameController;
    //  NavMeshAgent myNavMeshAgent;

    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
        //     myNavMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {

        GetComponent<NavMeshAgent>().destination = gameController.transform.position;

    }
}
