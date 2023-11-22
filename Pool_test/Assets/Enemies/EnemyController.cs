using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour, IDamageable
{
    public int score_ = 100;
    public int health_ = 10;

    public delegate void OnDieHeader(GameObject causer, int score);
    public event OnDieHeader DieEvent;
    

    public void TakeDamage(GameObject causer, int damage)
    {
        if (damage < 0) return;
        if (damage < health_) health_ -= damage;
        else
        {
            health_ = 0;
            if(DieEvent != null)
            {
                DieEvent(causer, score_);
                Destroy(gameObject);
            }
        }
    }

}
