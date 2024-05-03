using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDBpt2 : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();
    private void Start ();
    
    ItemDB sword = new Item();
    sword.name = "Sword";
    sword.id = 0;

    Item bread = new Item();
    sword.name = "Bread";
    sword.id = 1;

    Item cape = new Item();
    sword.name = "Cape";
    sword.id = 2;

    itemDictionary.Add(0,sword);
    itemDictionary.Add(1, bread);
    itemDictionary.Add(2, cape);

    if (itemDictionary.ContainsKey(60))
    {
        Debug.Log("You Found the key!");
        var randomItem = itemDictionary[60];
    }
    else
    {
        Debug.Log("Key does not exist!");
    }
}