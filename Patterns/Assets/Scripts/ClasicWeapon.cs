using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using FPS;

namespace FPS
{
    [Serializable]
    public class ClasicWeapon : BaseWeapon
    {
        public string WeaponName;

        public ClasicWeapon()
        {
            WeaponName = Guid.NewGuid().ToString();
            Debug.Log(WeaponName);
        }

        public override void CreateBullet()
        {
            Bullet = new ClasicBullet();
            Debug.Log(Bullet);
        }

        public override void Shoot()
        {
            CreateBullet();
            Bullet.Shoot();
        }
    }
}
