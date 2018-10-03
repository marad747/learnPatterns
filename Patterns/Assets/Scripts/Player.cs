using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FPS;

public class Player : MonoBehaviour
{
    public BaseWeapon CurrentWeapon;
    public Factory Factory;

    void Start()
    {
        Factory = new Factory();
        CurrentWeapon = Factory.CreateWeapon();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CurrentWeapon.Shoot();
        }
    }
}
