using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThunderFighter
{
    public class MyBullet : Bullet
    {
        private Thread _thread = null;
        public override void Create(Fighter fighter)
        {
            MyFighter myFighter = fighter as MyFighter;
            if(!myFighter.BSuperFight)
            {
                SpeedTypeAttr = SpeedType.Level2;
                PowerTypeAttr = PowerLevel.Level2;
            }
            else
            {
                SpeedTypeAttr = SpeedType.Level3;
                PowerTypeAttr = PowerLevel.Level4;
            }
            if (_thread == null)
            {
                _thread = new Thread(ThreadCallBakc);
                _thread.Start();
            }
        }

        public override void Destroy()
        {
            
        }

        public override void Dispose()
        {
            
        }

        public override void Move()
        {
            
        }

        public override void ShootEnemy()
        {
            
        }

        private void ThreadCallBakc(object sender)
        {

        }
    }
}
