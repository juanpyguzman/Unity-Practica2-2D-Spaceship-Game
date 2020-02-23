using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float acceleration = 20f;
    public float turnAcceleration = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * acceleration, ForceMode.Acceleration);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddRelativeForce(-Vector3.forward * acceleration, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().AddTorque(transform.up * turnAcceleration, ForceMode.Acceleration);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().AddTorque(-transform.up * turnAcceleration, ForceMode.Acceleration);

        }

    }
}
