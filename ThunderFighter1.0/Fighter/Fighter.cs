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
        public Image BackGroundImag
        {
            get;
            set;
        }

        public Layout LayoutAttr
        {
            get;
            set;
        }

        public SpeedType SpeedTypeAttr
        {
            get;
            set;
        }

        public RankLevel RankTypeAttr
        {
            get;
            set;
        }

        public abstract void Create();

        public abstract void ShootEnemy();

        public abstract void ShootbyEnemy();

        public abstract void Move(Point point);

        public abstract void Destroy();

        public abstract void Dispose();
    }
}
