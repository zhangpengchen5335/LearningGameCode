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
        public MyForm()
        {
            InitializeComponent();
            TransparencyKey = Color.Black;
        }

        public void SetImage(string imagePath)
        {
            try
            {
                Image image = Image.FromFile(imagePath);
                BackgroundImage = image;
            }
            catch(Exception ex)
            {
                Common.MY_ERROR_BOX.SetMsg(ex.ToString());
            }
        }
    }
}
