using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



//This will dynamically display our inventory in the inventory panel in the UI
public class InventoryUI : MonoBehaviour
{
   public GameObject slotPrefab;
   
    public void OnInventoryUpdate()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        DrawInventory();
    }

   public void DrawInventory()
    {

        //NULL POINTER EXCEPTION

        foreach(InventoryItem item in InventorySystem.current.inventory)
        {
            AddInventorySlot(item);
        }
    }


    //Add an item to a slot in the inventory.
    public void AddInventorySlot(InventoryItem item)
    {
        GameObject obj = Instantiate(slotPrefab);
        obj.transform.SetParent(transform, false);

        InventoryUIItem slot = obj.GetComponent<InventoryUIItem>();
        slot.set(item);

    }

    public void closeInventoryPanel()
    {
        
    }

}
