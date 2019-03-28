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

        public int ResurrectionCount { get => _resurrectionCount; }
        public int Score { get => _score; set => _score = value; }

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

        public void Escalate()
        {
            if (BackGroundImag != null)
            {
                BackGroundImag.Dispose();
                BackGroundImag = null;
            }
            BackGroundImag = Image.FromFile(Config.RESOURCEPATH + "");
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

        public override void Dispose()
        {
            
        }
    }
}
