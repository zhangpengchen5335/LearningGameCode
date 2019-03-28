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
                Image image = Image.FromFile(Config.RESOURCEPATH + Name);
                return image;
            }
            catch(Exception ex)
            {
                Common.MY_ERROR_BOX.SetMsg(ex.ToString());
                return null;
            }
        }
    }
}
