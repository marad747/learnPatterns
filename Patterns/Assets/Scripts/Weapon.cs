using UnityEngine;

[SerializeField]
public class Weapon : BaseWeapon, IWeapon
{          
    public WeaponsType WeaponsType
    {
        get
        {
            return _weaponsType;
        }

        set
        {
            _weaponsType = value;
        }
    }

    public int MaxBullets
    {
        get
        {
            return _maxBullets;
        }

        set
        {
            _maxBullets = value;
        }
    }

    public int CurrentBulletsCount
    {
        get
        {
            return _currentBulletsCount;
        }

        set
        {
            _currentBulletsCount = value;
        }
    }

    public Weapon(int maxBullets,string name, WeaponsType type)
    {
        _name = name;
        WeaponsType = type;
        MaxBullets = maxBullets;
        CurrentBulletsCount = MaxBullets;        
    }

    public void Interact()
    {
        if (CurrentBulletsCount > 0)
        {
            Debug.Log("shoot from " + this._name);
            CurrentBulletsCount--;
        }
        else
        {
            Debug.Log("for " + this._name + " count bullets = 0");
        }

    }
}

