using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DoAPause() {
        Time.timeScale = 0f;
    }

//} else if (Time.timeScale == 0f)
    //Time.timeScale = 1f;

}