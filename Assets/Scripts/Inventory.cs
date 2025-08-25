using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    void Awake() { instance = this; }

    public List<Item> items = new List<Item>();

    public void Add(Item item)
    {
        items.Add(item);
        Debug.Log("Picked up: " + item.itemName);
    }
}