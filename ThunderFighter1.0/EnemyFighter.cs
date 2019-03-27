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
        public Image BackGroundImag
        {
            get
            {
                return _backGroundImag;
            }
            set
            {
                _backGroundImag = value;
            }
        }
        public Layout LayoutAttr
        {
            get
            {
                return _layoutAttr;
            }
            set
            {
                _layoutAttr = value;
            }
        }
        public SpeedType SpeedTypeAttr
        {
            get
            {
                return _speedTypeAttr;
            }
            set
            {
                _speedTypeAttr = value;
            }
        }
        public RankType RankTypeAttr
        {
            get
            {
                return _rankTypeAttr;
            }
            set
            {
                _rankTypeAttr = value;
            }
        }

        public delegate void MyDestroyEventDel(object sender, DestroyEventArgs args);
        public event MyDestroyEventDel DestroyEvent;


        private Image _backGroundImag = null;
        private Layout _layoutAttr = null;
        private SpeedType _speedTypeAttr = SpeedType.Level1;
        private RankType _rankTypeAttr = RankType.Level1;
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

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Destroy()
        {
            Dispose();
            DestroyEventInvoke();
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

        private void Dispose()
        {
            if(_thread != null)
            {
                _bStop = true;
                if (_thread.Join(1000))
                {
                    _thread.Abort();
                    _thread = null;
                }
            }
            if(_backGroundImag != null)
            {
                _backGroundImag.Dispose();
                _backGroundImag = null;
            }
        }
    }
}
