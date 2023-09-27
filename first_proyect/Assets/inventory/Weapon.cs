
using UnityEngine;


[System.Serializable]
public class Weapon 
{
    public string name_;
    public int damage_;
    public int rangeDistance_;
    public RangeType type_;

    public enum RangeType {
        Melee,
        Range
    };

    public Weapon(RangeType range = RangeType.Melee)
    {
        type_ = range;
    }

    public virtual void Attack()
    {
        Debug.Log(name_ + " Attack!");
    }
}
