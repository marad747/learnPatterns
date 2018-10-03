using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FPS;
using UnityEngine;

namespace FPS
{
    [Serializable]
    public abstract class BaseWeapon
    {
        protected IBullet Bullet;

        public abstract void CreateBullet();
        public abstract void Shoot();
    }
}
