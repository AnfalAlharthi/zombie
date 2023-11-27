using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Load load;
    int healthpoint;
    BinarySave binary = new BinarySave();
    public Slider slider;


    public GameObject des;
    public float health = 100;
    healthSystem healthsystem = new healthSystem(100);


    public void Start()
    {

    }
    public void save()
    {
        binary.saveToFile(healthsystem);
    }


    public void FixedUpdate()
    {
        slider.value = healthsystem.gethealthpercentage();
        if (healthsystem.gethealth() == 0) {
             void OnCollisionEnter(Collision other)
            {
                if (other.gameObject.name == "player")
                {
                    SceneManager.LoadScene(2);
                }
            } }

           // Destroy(des); }

    }
    public void Loading()
    {
        healthsystem = load.GetHealthSystem();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        { healthsystem.Damage(30); }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heal")
        { healthsystem.heal(10); }
    }

}
