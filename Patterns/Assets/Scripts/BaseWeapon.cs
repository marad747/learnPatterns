using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[Serializable]
public class BaseWeapon
{
    protected string _name;
    protected WeaponsType _weaponsType;
    protected int _maxBullets;
    protected int _currentBulletsCount;
}
