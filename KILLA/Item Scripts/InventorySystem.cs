using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    //This class will create an inventory system in which the user will keep track of their items and what to do with them

    //Create a Dictionary containing the definitions of all the items;
    private Dictionary<InventoryItemData, InventoryItem> itemDictionary;

    //The actual items in the inventory

        //!!!!!!!!!!!!!!!!!!!!!!!!!!
    public List<InventoryItem> inventory { get; private set; }

    //Creates a reference to the current inventory system
    public static InventorySystem current;

    private void Awake()
    {
        //On awake construct a new inventory and new dictionary
        inventory = new List<InventoryItem>();
        itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
        current = this;
    }

    public void AddToInventory(InventoryItemData referenceData)
    {
        //If we find the item in the dictionary and get a value, add it to the stack
        if(itemDictionary.TryGetValue(referenceData, out InventoryItem value)){
            value.AddToStack();
        }
        else
        {
            //Create a new item from the reference data
            InventoryItem newItem = new InventoryItem(referenceData);
            //Add to our Inventory list
            inventory.Add(newItem);
            //Add the defenition to our dictionary
            itemDictionary.Add(referenceData, newItem);
        }
    }

    public void RemoveFromInventory(InventoryItemData referenceData)
    {
        if(itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            //Subtract one from the stack
            value.RemoveFromStack();

            //If the value of the stack hits zero, remove it from our inventory and Dictionary
            if(value.stackSize == 0)
            {
                inventory.Remove(value);
                itemDictionary.Remove(referenceData);
            }

        }
    }

    //Script to update inventory on pickup
    public void onPickUp(InventoryItemData referenceData)
    {
        //add the item to our inventory
        AddToInventory(referenceData);
    }

    //Script to update inventory on drop
    public void onDrop(InventoryItemData referenceData)
    {
        RemoveFromInventory(referenceData);
    }

}
