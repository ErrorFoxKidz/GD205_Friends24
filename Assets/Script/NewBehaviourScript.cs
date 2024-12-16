using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float explosionForce = 20f;
    public float explosionRadius = 20f;
    // Start is called before the first frame update
    void Start()
    {

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
            {
                Destroy(laserImpactReport.transform.gameObject);
                Debug.Log("BANG");
            }
            else if (Input.GetMouseButtonDown(1))
            {
                laserImpactReport.rigidbody.AddExplosionForce(explosionForce, laserImpactReport.point, explosionRadius);
            }


        }


    }
   

}
