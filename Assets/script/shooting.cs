using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletprefap;
    public float bulletSpeed = 10;
    public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input. GetButtonDown("Fire1"))
        {
           

            var bullet = Instantiate(bulletprefap, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        

        }
    }
}
