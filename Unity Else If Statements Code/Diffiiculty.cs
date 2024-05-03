using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Start is called before the first frame update
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public float attackStrength;
    void Start()
    {
        Debug.Log("Name: " + itemName);
        Debug.Log("Description: " + itemDescription);
        Debug.Log("Attack: " + attackStrength);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}