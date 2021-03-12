using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //create a variable to store your name
    public string name = "Christopher West";
    //create a variable to store your age
    public int age = 40;
    //create a variable to store your speed
    public float speed = 5.0f;
    //create a health variable
    public int health = 100;
    //create a score variable
    public int score = 0;
    //create a speed variable
    public float otherSpeed = 0.0f;
    //create a variable to check if all keys were collected
    public bool hasCollectedAllKeys = false;
    //create a variable for ammo count
    public int ammoCount = 15;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"My Name: {name}");
        Debug.Log($"My Age: {age}");
        Debug.Log($"My Speed: {speed}");
        Debug.Log($"Health: {health}");
        Debug.Log($"Score: {score}");
        Debug.Log($"Other Speed: {otherSpeed}");
        Debug.Log($"Has Collected All Keys: {hasCollectedAllKeys}");
        Debug.Log($"Ammo Count: {ammoCount}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
