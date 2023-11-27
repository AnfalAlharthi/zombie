using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthSystem : MonoBehaviour
{
    // Start is called before the first frame update
    private float healthPoints;
    private float maxHealth;
    public float gethealth()
    {
        return healthPoints;
    }
    public float gethealthpercentage() { return healthPoints / maxHealth; }

    public healthSystem(int maxHealth)
    {
        this.maxHealth = maxHealth;
        healthPoints = maxHealth;
    }
    public void Damage(int damageAmount)
    {
        healthPoints -= damageAmount;
        if (healthPoints <= 0) {
            healthPoints = 0;
                   SceneManager.LoadScene(2);
             }

    }
    public void heal(int healAmount)
    {
        healthPoints += healAmount;
        if (healthPoints > maxHealth) { healthPoints = maxHealth; }
    }

}
