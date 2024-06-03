using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public Transform spawnpoint;

    public GameObject Bullet;

    public float shotForce = 1500f;

    public float shotRate = 0.5f;

    private float shotRateTime;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(Time.time > shotRateTime)
            {


                GameObject newBullet;

                newBullet = Instantiate(Bullet,spawnpoint.position,spawnpoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawnpoint.forward * shotForce);

                shotRateTime = Time.time + shotRate;

                Destroy(newBullet,3);

            }


        }



        
    }
}
