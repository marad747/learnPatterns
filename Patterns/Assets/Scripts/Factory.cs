using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FPS;

namespace FPS
{
    public class Factory
    {
        public BaseWeapon CreateWeapon()
        {
            return new ClasicWeapon();
        }
    }
}
