using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FPS;
using UnityEngine;

namespace FPS
{
    public class ClasicBullet : IBullet
    {
        public void Shoot()
        {
            Debug.Log("Clasic Bullet Shoot");
        }
    }
}
