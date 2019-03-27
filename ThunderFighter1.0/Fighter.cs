using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderFighter
{
    public abstract class Fighter
    {
        Image BackGroundImag
        {
            get;
            set;
        }

        Layout LayoutAttr
        {
            get;
            set;
        }

        SpeedType SpeedTypeAttr
        {
            get;
            set;
        }

        RankType RankTypeAttr
        {
            get;
            set;
        }

        public abstract void Create();

        public abstract void ShootEnemy();

        public abstract void ShootbyEnemy();

        public abstract void Move();

        public abstract void Destroy();
    }
}
