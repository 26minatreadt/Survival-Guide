using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public string myName = "Karsyn";
    public int myAge = 16;
    public float mySpeed = 12.9f;
    public int health = 290;
    public int score = 129;
    public bool hasAllKeys;
    public int ammoCount = 29;
    void Start()
    {
        Debug.Log("My name is " + myName + " and I am " + myAge + " years old.");
        Debug.Log("Speed: " + mySpeed);
        Debug.Log("Health: " + health);
        Debug.Log("Score: " + score);
        Debug.Log("Has all keys: " + hasAllKeys);
        Debug.Log("Ammo Count: " + ammoCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}