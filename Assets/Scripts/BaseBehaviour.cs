using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBehaviour : MonoBehaviour
{
    private bool detected = false;
    Material[] mat;
    Renderer render;

    private Light baseLight;

    void OnTriggerEnter (Collider other)
    { 
        if (other.gameObject.name == "Player" && detected != true)
        {
            detected = true;
            mat[1].SetColor("_EmissionColor", Color.green);
            baseLight.enabled = !baseLight.enabled;
            other.GetComponent<PlayerBehaviour>().baseFounded();

        }

        else
        {

        }
    } 

    // Start is called before the first frame update
    void Start()
    {
        render = gameObject.GetComponent<Renderer>();
        mat = render.materials;
        baseLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}