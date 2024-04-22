using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<Item> itemDatabase = new List<ItemDB>();

    public void AddItem(int itemID, Player player)
    {
        //check if item matches something in the database
        foreach(var item in itemDatabase)
        {
            //check for match
            if (item.id == itemID)
            {
                Debug.Log("We have a match!");
                return;
            }
        }

        Debug.Log("Item Doesn't Exist")
    }
    public void RemoveItem(int itemId, Player player)
    {
        if (item.id == itemid)
        {
            player.inventory[0] - null;
        }
    }
}