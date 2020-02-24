using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float acceleration = 20f;
    public float turnAcceleration = 2f;

    public int lifes = 3;
    public int foundBases = 0;

    public GameObject BulletYellow = null;

    //Función disparo
    private void shot()
    {
        GameObject shootedBullet = GameObject.Instantiate(BulletYellow);
        shootedBullet.transform.position = transform.position + transform.forward * 1f;
        shootedBullet.GetComponent<BulletBehaviour>().setDirection(transform.forward);
        shootedBullet.tag = "Player";
        Destroy(shootedBullet, 5.0f);
    }

    //Bases encontradas
    public void baseFounded()
    {
        foundBases++;
        if (foundBases==4)
        {
            Debug.Log("¡¡Ganaste!!");
        }
    }

    //Disparo recibido
    public void hit(GameObject other)
    {
        lifes--;
        Debug.Log("Player: Daño recibido");
        Debug.Log("Te quedan " + lifes + " vidas");
        GetComponent<Rigidbody>().AddRelativeForce(new Vector3(500.0f,500.0f,500.0f), ForceMode.Impulse);


        //Si el Jugador pierde todas las vidas  
        if (lifes == 0)
        {
            Destroy(other);
            Debug.Log("GAME OVER");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movimientos
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

        if (Input.GetKey(KeyCode.R))
        {
            transform.position= new Vector3(0.0f, 0.0f, 0.0f);
        }
    }

    void Update()
    {
        //Disparos
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shot();
        }
    }
}
