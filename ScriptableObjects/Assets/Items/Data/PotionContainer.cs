using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Heal Orb", menuName = "LMGame/Create new Heal Orb", order = 101)]
public class PotionContainer : ItemData
{
    public int minHeal_;
    public int maxHeal_;
    public int selfDestructTimer_;

    public override void Use(InventoryController inventory, Charactercontroller character)
    {
        GameObject go = Instantiate<GameObject>(ItemPrefab_, character.transform.position, character.transform.rotation);

        character.health_ += Random.Range(minHeal_, maxHeal_); 

        if(character.health_ > character.maxHealth_)
        {
            character.health_ = character.maxHealth_;
        }
        
        Debug.Log("Character current health: " + character.health_);


        Destroy(go, selfDestructTimer_);
    }
}