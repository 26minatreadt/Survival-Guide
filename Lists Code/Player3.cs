using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    public Item[] inventory;
    private ItemDB _itemDatabase;

    private void Start()
    {
        _itemDatabase = GameObject.Find("ItemID").GetComponent<ItemDB>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(Keycode.Space))
        {
            //request item by id
            _itemDatabase.AddItem(0);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            //remove item by id
            _itemDatabase.RemoveItem(0);
        }
    }
}