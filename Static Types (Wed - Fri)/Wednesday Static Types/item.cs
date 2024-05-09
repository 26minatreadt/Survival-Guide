using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string name;
    public itemID;

    public static int itemCount;

    public Item()
    {
        itemCount++;
    }
}

public class Test : MonoBehaviour
{
    private void Start()
    {
        Item sword = new Item();
        Item bread = new Item();
        Item cape = new Item();
        Item fish = new Item();

        Debug.Log("Item Count: " + Item.itemCount);
    }
}