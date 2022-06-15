using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(menuName ="Inventory Item Data")]
//We're making this a scriptable object since we want to be able to make new items as we please
public class InventoryItemData : Item
{
    //Sprite for the UI
    public Sprite icon;

}
