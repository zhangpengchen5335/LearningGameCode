using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderFighter
{
    public class CommonHelper
    {
        public static bool BShoot(EdgePoint edgePoint, Layout layout)
        {
            Rectangle rect = layout.ToRectangle();
            return rect.Contains(edgePoint.LeftPoint) || rect.Contains(edgePoint.RightPoint)|| rect.Contains(edgePoint.TopPoint)|| rect.Contains(edgePoint.ButtomPoint);
        }

        public static Image GetImageg(string Name)
        {
            try
            {
                Image image = Image.FromFile(Name);
                return image;
            }
            catch(Exception ex)
            {
                Common.MY_ERROR_BOX.SetMsg(ex.ToString());
                return null;
            }
        }

        public static Layout GetEnemyBulletLayout(Fighter fighter)
        {
            Layout layout = new Layout();
            switch(fighter.RankTypeAttr)
            {
                case RankLevel.Level1:
                    layout.X = fighter.LayoutAttr.X / 2 - Common.ENEMY_NORMAL_BULLET_SIZE.Width / 2;
                    layout.Y = fighter.LayoutAttr.EdgePointAttr.ButtomPoint.Y + 2;
                    layout.Width = Common.ENEMY_NORMAL_BULLET_SIZE.Width;
                    layout.Height = Common.ENEMY_NORMAL_BULLET_SIZE.Height;
                    break;
                case RankLevel.Level2:
                    layout.X = fighter.LayoutAttr.X / 2 - Common.ENEMY_SUPER_BULLET_SIZE.Width / 2;
                    layout.Y = fighter.LayoutAttr.EdgePointAttr.ButtomPoint.Y + 2;
                    layout.Width = Common.ENEMY_SUPER_BULLET_SIZE.Width;
                    layout.Height = Common.ENEMY_SUPER_BULLET_SIZE.Height;
                    break;
                case RankLevel.Level3:
                    break;
                case RankLevel.Level4:
                    break;
            }
            return layout;
        }

        public static Layout GetMyBulletLayout(Fighter fighter)
        {
            MyFighter myFighter = fighter as MyFighter;
            Layout layout = new Layout();
            switch (myFighter.BSuperFight)
            {
                case true:
                    layout.X = fighter.LayoutAttr.X / 2 - Common.MY_NORMAL_BULLET_SIZE.Width / 2;
                    layout.Y = fighter.LayoutAttr.EdgePointAttr.ButtomPoint.Y + 2;
                    layout.Width = Common.MY_NORMAL_BULLET_SIZE.Width;
                    layout.Height = Common.MY_NORMAL_BULLET_SIZE.Height;
                    break;
                case false:
                    layout.X = fighter.LayoutAttr.X / 2 - Common.MY_SUPER_BULLET_SIZE.Width / 2;
                    layout.Y = fighter.LayoutAttr.EdgePointAttr.ButtomPoint.Y + 2;
                    layout.Width = Common.MY_SUPER_BULLET_SIZE.Width;
                    layout.Height = Common.MY_SUPER_BULLET_SIZE.Height;
                    break;
            }
            return layout;
        }
    }
}
