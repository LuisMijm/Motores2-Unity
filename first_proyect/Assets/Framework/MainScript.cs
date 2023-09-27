using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    // Clases
    private Elf myElf_;
    private Orc myOrc_;

    // Inventory
    public Axe axe_;
    public Shotgun shotgun_;
    public List<Weapon> weaponList_;


    void Start()
    {
        // Clases
        myElf_ = new Elf();
        myOrc_ = new Orc();

        myElf_.attack_ = 23.0f;
    
        // Inventory
        axe_ = new Axe();
        shotgun_ = new Shotgun();
        weaponList_ = new List<Weapon>();

        weaponList_.Add(axe_);      // 0
        weaponList_.Add(axe_);      // 1
        weaponList_.Add(shotgun_);  // 2
        weaponList_.RemoveAt(1);

        weaponList_[0].Attack();
        weaponList_[1].Attack();
    }


}
