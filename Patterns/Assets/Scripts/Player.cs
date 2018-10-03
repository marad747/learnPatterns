using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private WeaponFactory weaponFactory = new WeaponFactory();
    private IWeapon _currentWeapon;
    private List<IWeapon> _allMyWeapons = new List<IWeapon>();
    public WeaponsType WeaponsType;

    void Start()
    {
        _allMyWeapons.Add(weaponFactory.CreateItem(5,WeaponsType.ClassicWeapon));
        _allMyWeapons.Add(weaponFactory.CreateItem(10,WeaponsType.M16));
        _currentWeapon = _allMyWeapons [0];
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _currentWeapon.Interact();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            AddBullets(10,WeaponsType);
        }
    }

    private void AddBullets(int bullets,WeaponsType type)
    {
        foreach (var item in _allMyWeapons)
        {
            if (item.WeaponsType == type)
            {
                item.CurrentBulletsCount += bullets;
                Debug.Log("Add " + bullets + " bulets to" + type);
            }
        }
    }
}
