using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array4 : MonoBehaviour
{
    public string[] names;
    public int[] ages;
    public string[] cars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Name: " + names[4] + " Car model: " + cars[4]);
        }
    }
}
