using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderFighter
{
    public abstract class Bullet
    {
        Layout LayoutAttr
        {
            get;
            set;
        }
        Image BackGroundImage
        {
            get;
            set;
        }
        SpeedType SpeedTypeAttr
        {
            get;
            set;
        }
        PowerLevel PowerTypeAttr
        {
            get;
            set;
        }

        public abstract void Create();

        public abstract void ShootEnemy();

        public abstract void Move();

        public abstract void Destroy();

    }
}
