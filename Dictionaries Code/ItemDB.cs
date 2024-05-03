using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();
    private void Start ();
    sword.name = "Sword";
    sword.id = 0;

    itemList.Add(sword);
    itemDictionary.Add(0,sword);

    var item = itemDictionary[0];
}