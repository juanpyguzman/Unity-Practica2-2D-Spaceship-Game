using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject target = null;
    public float MinHeight = 4f;
    public float HeightFactor = 1.0f;

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
            transform.position = new Vector3(target.transform.position.x,
                                             target.transform.position.y + Height,
                                             target.transform.position.z);

            Height = MinHeight * (1 + shipRigidBody.velocity.magnitude / HeightFactor);
        }
    }
}
