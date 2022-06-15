using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIItem : MonoBehaviour
{


    [SerializeField] private Image icon;

    [SerializeField] private Text label;

    [SerializeField] private GameObject stackObject;

    [SerializeField] private Text stackCount;

    public void set(InventoryItem item)
    {
        icon.sprite = item.itemData.icon;
        label.text = item.itemData.displayName;

        if(item.stackSize <= 1)
        {
            stackObject.SetActive(false);
            return;
        }

        stackCount.text = item.stackSize.ToString();


    }

}
