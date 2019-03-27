using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderFighter
{
    public class MyFighter : Fighter
    {
        private MyFighter()
        {
            
        }

        static MyFighter()
        {
            _instance = new MyFighter();
        }
        public static MyFighter Instance
        {
            get => _instance;
        }
        private static MyFighter _instance;



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

        public int ResurrectionCount { get => _resurrectionCount; }
        public int Score { get => _score; set => _score = value; }

        private Image _backGroundImag = null;
        private Layout _layoutAttr = null;
        private SpeedType _speedTypeAttr = SpeedType.Level1;
        private RankType _rankTypeAttr = RankType.Level1;
        private int _resurrectionCount = 3;
        private int _score = 0;

        public override void Create()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void GetScore()
        {

        }
        public void UltimateSkill()
        {

        }

        public void EnemyDestroyEventCallBack(object sender, DestroyEventArgs args)
        {

        }
    }
}
