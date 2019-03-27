using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThunderFighter
{
    public class FighterFactory
    {
        static public Fighter GetFighter(FighterType fighterType)
        {
            switch(fighterType)
            {
                case FighterType.MyFighter:
                    return MyFighter.Instance;
                case FighterType.EnemyFighter:
                    return new EnemyFighter();
                default:
                    return null;
            }

        }
    }
}
