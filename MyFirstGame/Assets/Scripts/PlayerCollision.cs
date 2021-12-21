using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public ScoreCounter scoreCounterScript;
    public PlayerMovement movement;
    //public Transform player;
    GameObject[] obstacles;

    void OnCollisionEnter(Collision collesionInfo)
    {
        if (collesionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }   
    }

    private void Start()
    {
        obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
    }

    void Update()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            if((gameObject.transform.position.z > obstacles[i].transform.position.z) && !obstacles[i].GetComponent<PassedByPlayer>().passed)
            {
                obstacles[i].GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                scoreCounterScript.score++;
                obstacles[i].GetComponent<PassedByPlayer>().passed = true;
            }
        }
    }
}


/*
    Questions:

    - What component is required on an object if you want it to exhibit physical traits such as falling?

    Rigidbody

    - Should all game objects have rigidbodies?
    
    It depends of what is the purpose of the object. If the object moves, it should have. 

    - Is every component editable by script?

    Yes, unity allows even to create our complementional script for specific purposes.

    - List all classes have you created and what are their relationships? 
        
        * ScoreCounter
        * PassedByPlayer
        * PlayerMovement
        * FollowPlayer
        * PlayerCollision


    - Create a UML diagram for the classes, and show how they interact with each other? 

      

 */