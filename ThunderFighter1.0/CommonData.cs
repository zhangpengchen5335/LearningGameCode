using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderFighter
{
    public class Config
    {
        private Level _level = Level.Level1;
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

    public enum Level
    {
        Level1,
        Level2,
        Level3,
        Level4
    }

    public enum DirectionType
    {
        Left,
        Right,
        Top,
        bottom
    }

    public enum SpeedType
    {
        Level1,
        Level2
    }

    public enum RankType
    {
        Level1,
        Level2,
        Level3,
        Level4
    }

    public enum FighterType
    {
        MyFighter,
        EnemyFighter
    }

    public class DestroyEventArgs : EventArgs
    {
        public DestroyEventArgs(RankType rankType)
        {
            RankTypeAttr = rankType;
        }
        public RankType RankTypeAttr
        {
            get;
            set;
        }
    }
}
