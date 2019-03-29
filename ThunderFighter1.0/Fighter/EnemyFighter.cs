using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThunderFighter
{
    public class EnemyFighter : Fighter
    {
        public delegate void MyDestroyEventDel(object sender, DestroyEventArgs args);
        public event MyDestroyEventDel DestroyEvent;

        private Thread _thread = null;
        private bool _bStop = false;
        public override void Create()
        {
            _thread = new Thread(AutoThread);
            _thread.Start();
        }

        public override void ShootEnemy()
        {
            throw new NotImplementedException();
        }

        public override void ShootbyEnemy()
        {
            throw new NotImplementedException();
        }

        public override void Move(Point point)
        {
        }

        public override void Destroy()
        {
            Dispose();
            DestroyEventInvoke();
        }

        public override void Dispose()
        {
            if (_thread != null)
            {
                _bStop = true;
                if (_thread.Join(1000))
                {
                    _thread.Abort();
                    _thread = null;
                }
            }
            if (BackGroundImag != null)
            {
                BackGroundImag.Dispose();
                BackGroundImag = null;
            }
        }
        private void DestroyEventInvoke()
        {
            DestroyEvent?.Invoke(this, new DestroyEventArgs(RankTypeAttr));
        }

        private void AutoThread(object sender)
        {
            while(!_bStop)
            {

            }
        }
    }
}
