using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem : Item 
{
    //The item data we are going to retrieve and set to the stack
    public InventoryItemData itemData { get; private set; }
    //How many of the item are in the stack
    public int stackSize { get; private set; }

    public InventoryItem (InventoryItemData sourceData)
    {
        itemData = sourceData;
        AddToStack();
    }

    public void AddToStack()
    {
        stackSize++;
    }

    public void RemoveFromStack()
    {
        stackSize--;
    }

}

