using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New fireball", menuName = "LMGame/Create new Fireball", order = 101)]
public class FireballContainer : ItemData
{ 
    public override void Use(InventoryController inventory)
    {
        GameObject.Instantiate(ItemPrefab_);
    }
}
