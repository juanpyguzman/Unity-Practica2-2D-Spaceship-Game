using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehaviour : MonoBehaviour
{
    public GameObject pylon = null;
    public GameObject target = null;
    public GameObject BulletRed = null;

    public float shotDistance;
    public float shotFrequency;

    private float lastTimeShot = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position - target.transform.position).sqrMagnitude < shotDistance)
        {
            pylon.transform.LookAt(target.transform);

            if (Time.time - lastTimeShot >= shotFrequency)
            {
                shot();
                lastTimeShot = Time.time;
            }
        }
    }

    private void shot()
    {
        GameObject shootedBullet = GameObject.Instantiate(BulletRed);
        shootedBullet.transform.position = pylon.transform.position + pylon.transform.forward * 1f;
        shootedBullet.GetComponent<BulletBehaviour>().setDirection(pylon.transform.forward);
        shootedBullet.tag = tag;
        Destroy(shootedBullet, 5.0f);
    }
}
