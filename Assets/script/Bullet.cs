using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life;
    private void Awake()
    {

       // GetComponent<Animator>().SetTrigger("walk"); 
       Destroy(gameObject, life);
    }
    void OnCollisionEnter(Collision collision)
    {
        // GetComponent<Animator>().SetTrigger("walk");
        collision.gameObject.GetComponent<Animator>().SetTrigger("Dead");
      //  Destroy(collision.gameObject);
        Destroy(gameObject);
    }
    // Start is called before the first frame update
}


