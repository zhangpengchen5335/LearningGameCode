using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderFighter
{

    public class Common
    {
        public static string SUPER_FIGHTER_IMAGE = "超级战机.jpg";
        public static string NORMAL_FIGHTER_IMAGE = "普通战机.jpg";
        public static string NORMAL_ENEMY_FIGHTER_IMAGE = "敌人小型战机.jpg";
        public static string SUPER_ENEMY_FIGHTER_IMAGE = "敌人大型战机.jpg";
        public static string NORMAL_ENEMY_BULLET_IMAGE = "敌人小型战机子弹.jpg";
        public static string SUPER_ENEMY_BULLET_IMAGE= "敌人大型战机子弹.jpg";
        public static string NORMAL_BULLET_IMAGE = "普通战机子弹 .jpg";
        public static string SUPER_BULLET_IMAGE = "超级战机子弹.jpg";

        public static MyErrorBox MY_ERROR_BOX = new MyErrorBox();
    }

    public class Config
    {
        private Level _level = Level.Level1;

        public static string RESOURCEPATH = AppDomain.CurrentDomain.BaseDirectory + @"Resource\";
    }

    public class Layout
    {
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }

        private int _x;
        private int _y;
        private int _width;
        private int _height;
    }

    /// <summary>
    /// 游戏难度等级
    /// </summary>
    public enum Level
    {
        Level1,
        Level2,
        Level3,
        Level4
    }
    /// <summary>
    /// 方向
    /// </summary>
    public enum DirectionType
    {
        Left,
        Right,
        Top,
        bottom
    }
    /// <summary>
    /// 速度等级
    /// </summary>
    public enum SpeedType
    {
        Level1,
        Level2
    }
    /// <summary>
    /// 等级（战机血量，威力等等）
    /// </summary>
    public enum RankLevel
    {
        Level1,
        Level2,
        Level3,
        Level4
    }
    /// <summary>
    /// 战机类型
    /// </summary>
    public enum FighterType
    {
        MyFighter,
        EnemyFighter
    }
    /// <summary>
    /// 子弹类型
    /// </summary>
    public enum BulletType
    {
        MyBullet,
        EnemyBullet
    }
    /// <summary>
    /// 威力等级
    /// </summary>
    public enum PowerLevel
    {
        Level1,
        Level2,
        Level3,
        Level4
    }

    public class DestroyEventArgs : EventArgs
    {
        public DestroyEventArgs(RankLevel rankType)
        {
            RankTypeAttr = rankType;
        }
        public RankLevel RankTypeAttr
        {
            get;
            set;
        }
    }

    public class HitEnemyEventArgs : EventArgs
    {
        public HitEnemyEventArgs(PowerLevel powerLevel)
        {
            PowerLevelAttr = powerLevel;
        }
        public PowerLevel PowerLevelAttr
        {
            get;
            set;
        }
    }
}
