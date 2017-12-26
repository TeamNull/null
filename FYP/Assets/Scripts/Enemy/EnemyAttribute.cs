using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttribute : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public int exp = 10;

    bool isDead = false;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isDead) 
        {
            Destroy(gameObject);
        }
	}

    public void TakeDamage(int amount)
    {
        if (isDead)
            return;

        currentHealth -= amount;

        if (currentHealth <= 0) isDead = true;
    }
}
