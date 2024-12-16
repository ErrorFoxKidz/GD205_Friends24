using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigator : MonoBehaviour
{


    NavMeshAgent Y_Bot;

        public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        Y_Bot = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit laserImpactReport = new RaycastHit();

        if (Physics.Raycast(laser, out laserImpactReport))
        {
            Debug.Log("BANG");
            if (Input.GetMouseButtonDown(0))
                Y_Bot.SetDestination(laserImpactReport.point);

        }


    }
}
