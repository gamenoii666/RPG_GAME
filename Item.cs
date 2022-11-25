using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName ="New Item",menuName ="Inventory/Item")]
public class Item : ScriptableObject{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool showIntenvory = true;
    
    //§” —ß„™Ë‰Õ‡∑¡
    public void Use()
    {
        if(name.Equals("Axe"))
        {
            PlayerMovement.instance.ShowAxe();
            RemoveItemFromInventory();
        }
        if (name.Equals("Chicken"))
        {
            FoodController.instance.healingFood();
            RemoveItemFromInventory();
        }
    }
    public void RemoveItemFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
