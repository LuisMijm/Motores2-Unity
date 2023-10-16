using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New shout", menuName = "LMGame/Create new Shout", order = 101)]
public class ShoutContainer : ItemData
{
    public string ShoutMessage_;

    public override void Use(InventoryController inventory)
    {
        Debug.Log(ShoutMessage_);
    }
}
