using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using TMPro;

public class MoveScript : MonoBehaviour
{
    public float speed = 5;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 9;
    public KeyCode runningKey = KeyCode.LeftShift;

    public int BoxCurrentNumber;

   

    public GameObject Box;
    public GameObject Door1;
    public GameObject Door2;
    public GameObject Door3;
    public GameObject Door4;

    public TMP_Text CreatureName;
    public TMP_Text PointCounter;

    private bool HasBox;


    Rigidbody rigidbody;
    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();



    void Awake()
    {
        // Get the rigidbody on this.
        rigidbody = GetComponent<Rigidbody>();
        BoxCurrentNumber += 1;
    }

    void FixedUpdate()
    {
        // Update IsRunning from input.
        IsRunning = canRun && Input.GetKey(runningKey);

        // Get targetMovingSpeed.
        float targetMovingSpeed = IsRunning ? runSpeed : speed;
        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        // Get targetVelocity from input.
        Vector2 targetVelocity = new Vector2(Input.GetAxis("Horizontal") * targetMovingSpeed, Input.GetAxis("Vertical") * targetMovingSpeed);

        // Apply movement.
        rigidbody.velocity = transform.rotation * new Vector3(targetVelocity.x, rigidbody.velocity.y, targetVelocity.y);
    }
    void OnCollisionEnter(Collision check)
    {
        if (check.gameObject.CompareTag("BoxTag"))
        {
            Box.SetActive(false);
           

            switch (BoxCurrentNumber)
            {
                case 1:
                    CreatureName.text = "Deliver to Water Boy";
                    break;
                case 2:
                    CreatureName.text = "Deliver to Donkey Kong";
                    break;
                case 3:
                    CreatureName.text = "Deliver to Dude from Jeresy";
                    break;
                case 4:
                    CreatureName.text = "Deliver to Lamp Fan";
                    break;
                default:
                    Debug.Log("No boxes are in your hand");
                    break;
            }

        }

        if (check.gameObject.CompareTag("Door"))
         {
            switch (BoxCurrentNumber)
            {
                case 1:
                    CreatureName.text = "Return to box";
                    
                    BoxCurrentNumber = 0;
                    break;
                case 2:
                    CreatureName.text = "Return to box";
                    BoxCurrentNumber = 0;
                    break;
                case 3:
                    CreatureName.text = "Return to box";
                    BoxCurrentNumber = 0;
                    break;
                case 4:
                    CreatureName.text = "Return to box";
                    BoxCurrentNumber = 0;
                    break;
                default:
                    Debug.Log("No boxes are in your hand");
                    break;
            }
        }

    }

 }