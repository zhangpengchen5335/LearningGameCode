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
        public Layout LayoutAttr
        {
            get;
            set;
        }
        public Image BackGroundImage
        {
            get;
            set;
        }
        public SpeedType SpeedTypeAttr
        {
            get;
            set;
        }
        public PowerLevel PowerTypeAttr
        {
            get;
            set;
        }

        protected MyForm MyForm
        {
            get;
            set;
        }

        public bool BTrackBullet = false;

        public delegate void HitEnemyEventDel(object sender, HitEnemyEventArgs args);
        public event HitEnemyEventDel HitEnemyEvent;

        public abstract void Create(Fighter fighter);

        public abstract void ShootEnemy();

        public abstract void Move();

        public abstract void Destroy();

        public abstract void Dispose();
    }
}
