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

        
    }
}
