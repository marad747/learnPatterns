using System;
using UnityEngine;

public class WeaponFactory
{
    public IWeapon CreateItem(int bulletCount, WeaponsType weaponsType)
    {   
        Weapon weapon = new Weapon(bulletCount,weaponsType.ToString() + "_" + Guid.NewGuid().ToString(),weaponsType);        
        return weapon;
    }
}

