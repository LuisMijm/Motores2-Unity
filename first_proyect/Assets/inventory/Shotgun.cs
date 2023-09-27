using UnityEngine;

[System.Serializable]
public class Shotgun : Weapon
{
    public int ammo_;
    public int durability_;

    public Shotgun()
    {
        name_ = "Shotgun";
        damage_ = 100;
        rangeDistance_ = 30;
    }
    public override void Attack()
    {
        Debug.Log("Pañum de: " + damage_ + " Distancia: " + rangeDistance_);
        base.Attack();
    }
}
