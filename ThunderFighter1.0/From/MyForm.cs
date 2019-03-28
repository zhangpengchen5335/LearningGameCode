using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderFighter
{
    public partial class MyForm : Form
    {
        private delegate void SetLayoutDel(Layout layout);
        private delegate void SetImageDel(string imagePath);
        public MyForm()
        {
            InitializeComponent();
            TransparencyKey = Color.Black;
        }

        public void SetImage(string imagePath)
        {
            if (!InvokeRequired)
            {
                Image image = CommonHelper.GetImageg(imagePath);//Image.FromFile(imagePath);
                BackgroundImage = image;
            }
            else
            {
                SetImageDel cs = new SetImageDel(SetImage);
                Invoke(cs, new object[] { imagePath });
            }
        }

        public void SetLayout(Layout layout)
        {
            if(!InvokeRequired)
            {
                Location = new Point(layout.X, layout.Y);
                Size = new Size(layout.Width, layout.Height);
            }
            else
            {
                SetLayoutDel cs = new SetLayoutDel(SetLayout);
                Invoke(cs, new object[] { layout });
            }
        }
    }
}
