using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float speed = 40f;
    public GameObject player = null;

    private Vector3 direction;

    //Establecer dirección de la bala recibida desde fuera
    public void setDirection(Vector3 dir)
    {
        direction = dir;
    }

    //Colisiones de la bala con objetos
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != tag)
        {
            //Colisión con Torretas
            if (other.tag == "Turret")
            {
                Destroy(other.gameObject);
                Debug.Log("Destruida la unidad " + other.name);
            } 

            //Colisión con el Jugador
            else if (other.tag == "Player")
            {
                player.GetComponent<PlayerBehaviour>().hit(player);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddRelativeForce((direction.normalized) * speed, ForceMode.VelocityChange);
    }
}
