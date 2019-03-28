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
        private bool _bStop = false;
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
                _thread = new Thread(ThreadCallBack);
                _thread.Start();
            }
        }

        public override void Destroy()
        {
            Dispose();
        }

        public override void Dispose()
        {
            if(_thread != null)
            {
                _bStop = true;
                if(_thread.Join(1000))
                {
                    _thread.Abort();
                    _thread = null;
                }
            }
            if(BackGroundImage != null)
            {
                BackGroundImage.Dispose();
                BackGroundImage = null;
            }
        }

        public override void Move()
        {
            
        }

        public override void ShootEnemy()
        {
            
        }

        private void ThreadCallBack(object sender)
        {
            while(!_bStop)
            {

            }
        }
    }
}
