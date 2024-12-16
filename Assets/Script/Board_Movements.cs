using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    public Transform Enemy;
    public Transform[] Enemies;

    //public int myInt = 5;
    Vector3 startPos;


        public AudioClip impact;
        AudioSource audioSource;

        // Start is called before the first frame update
        void Start()
    {
        audioSource = GetComponent<AudioSource>();
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
          
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.back;
        }


        for (int howManyTimesLoopHasRun = 0; howManyTimesLoopHasRun < Enemies.Length; howManyTimesLoopHasRun++)
        {
            if (transform.position == Enemies[howManyTimesLoopHasRun].position)
            {
                transform.position = startPos;
                audioSource.PlayOneShot(impact, 0.7f);
            }
        }


        for (int howManyTimesLoopHasRun = 0; howManyTimesLoopHasRun < 5; howManyTimesLoopHasRun++)
        {
            Debug.Log("howManyTimesLoopHasRun = " + howManyTimesLoopHasRun);
        }



        }
}

