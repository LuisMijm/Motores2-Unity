using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New fireball", menuName = "LMGame/Create new Fireball", order = 101)]
public class FireballContainer : ItemData
{ 
    public int minDamage_;
    public int maxDamage_;
    public int selfDestructTimer_;


    public override void Use(InventoryController inventory, Charactercontroller character)
    {

        GameObject go = GameObject.Instantiate<GameObject>(ItemPrefab_);
        // GameObject.Instantiate(ItemPrefab_);
        if(character.health_ >= character.maxHealth_ * 0.5f)
        {
            character.health_ -= Random.Range(minDamage_, maxDamage_); 
        }

        Debug.Log("Character current health: " + character.health_);

        Destroy(go, selfDestructTimer_);
    }
}
