using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int health = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage) 
    {
        health -= damage;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
