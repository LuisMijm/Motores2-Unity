using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Item", menuName= "LMGame/Create new Item", order= 101)]
public class ItemData : ScriptableObject
{
    public GameObject ItemPrefab_;
    public int Scale_;


    public virtual void Use(InventoryController inventory)
    {

    }
}
