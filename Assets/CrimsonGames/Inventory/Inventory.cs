using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> items = new List<Item>();

    public void AddItem(Item item)
    {
        items.Add(item);
    }

    public void RemoveItem(Item item) 
    { 
        items.Remove(item);
    }

    public Item GetItem(int index) {  return items[index]; }
    public List<Item> GetItems() {  return items; }

    public int GetItemsCount() { return items.Count; }

    public void Clear() { items.Clear(); }
}
