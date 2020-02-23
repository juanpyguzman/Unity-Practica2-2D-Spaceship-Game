using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject target = null;
    public float MinHeight = 40f;
    public float HeightFactor = 10.0f;

    private float Height;
    private Rigidbody shipRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        shipRigidBody = target.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        if (target != null)
        {
            Height = MinHeight * (1 + shipRigidBody.velocity.magnitude / HeightFactor);

            transform.position = new Vector3(target.transform.position.x,
                                             target.transform.position.y + Height,
                                             target.transform.position.z);

            Debug.Log(transform.position.y);

        }
    }
}
