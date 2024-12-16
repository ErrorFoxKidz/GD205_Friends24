using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{

    public int Collectible = 0;


 void OnTriggerEnter(Collider other)
 {
    if (other.transform.tag == "Collectible")
    {
        Collectible++;
        Debug.Log(Collectible);
        Destroy(other.gameObject);
    }


  }

 }
