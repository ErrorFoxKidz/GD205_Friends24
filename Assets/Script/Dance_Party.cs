using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance_Party : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.W))
            {
                GetComponent<Animator>().SetFloat("Dancing", 2f);
            }
            else
            {
                GetComponent<Animator>().SetFloat("Dancing", 0f);
            }

        }

    }

}
