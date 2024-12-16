using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Follow : MonoBehaviour
{
    public Transform Player; // Location of the player
    private NavMeshAgent Enemy; // How you grab the characters NavMesh property
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>(); // Declaring
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.destination = Player.position; // How the Ai moves towards an object or player
    }

}