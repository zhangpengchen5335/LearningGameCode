using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ThunderFighter
{
    public class EnemyBullet : Bullet
    {
        public override void Create(Fighter fighter)
        {
            BTrackBullet = IsTrackBullet(fighter.RankTypeAttr);
            LayoutAttr = CommonHelper.GetEnemyBulletLayout(fighter);
            MyForm.SetLayout(LayoutAttr);
            switch (fighter.RankTypeAttr)
            {
                case RankLevel.Level1:
                    PowerTypeAttr = PowerLevel.Level1;
                    SpeedTypeAttr = SpeedType.Level1;
                    MyForm.SetImage(Common.NORMAL_ENEMY_BULLET_IMAGE);
                    break;
                case RankLevel.Level2:
                    PowerTypeAttr = PowerLevel.Level2;
                    SpeedTypeAttr = SpeedType.Level1;
                    MyForm.SetImage(Common.SUPER_ENEMY_BULLET_IMAGE);
                    break;
                case RankLevel.Level3:
                    PowerTypeAttr = PowerLevel.Level2;
                    SpeedTypeAttr = SpeedType.Level2;
                    break;
                case RankLevel.Level4:
                    PowerTypeAttr = PowerLevel.Level3;
                    SpeedTypeAttr = SpeedType.Level2;
                    break;
            }
        }

        public override void Destroy()
        {
        }

        public override void Dispose()
        {
        }

        public override void Move(Point point)
        {
        }

        public override void ShootEnemy()
        {
        }

        private bool IsTrackBullet(RankLevel rankLevel)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            bool res = false;
            switch(rankLevel)
            {
                case RankLevel.Level1:
                    if(randomNumber < 20)
                    {
                        res = true;
                    }
                    break;
                case RankLevel.Level2:
                    if (randomNumber < 30)
                    {
                        res = true;
                    }
                    break;
                case RankLevel.Level3:
                    if (randomNumber < 40)
                    {
                        res = true;
                    }
                    break;
                case RankLevel.Level4:
                    if (randomNumber < 50)
                    {
                        res = true;
                    }
                    break;
            }
            return res;
        }
    }
}
