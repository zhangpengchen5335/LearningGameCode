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

        public bool BTrackBullet = false;

        public delegate void HitEnemyEventDel(object sender, HitEnemyEventArgs args);
        public event HitEnemyEventDel HitEnemyEvent;

        public abstract void Create();

        public abstract void ShootEnemy();

        public abstract void Move();

        public abstract void Destroy();

        public abstract void Dispose();
    }
}
