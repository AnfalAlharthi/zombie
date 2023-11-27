using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
        //    GetComponent<Animator>().SetBool("run", true);
            transform.position += transform.forward * 2 * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(new Vector3(0, -150 * Time.deltaTime, 0));
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(new Vector3(0, 150 * Time.deltaTime, 0));
            }
        
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
         //   GetComponent<Animator>().SetBool("run", false);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
         //   GetComponent<Animator>().SetTrigger("jump");
            GetComponent <Rigidbody>().velocity=new Vector3(0, 4, 0);

        }


    }
}
