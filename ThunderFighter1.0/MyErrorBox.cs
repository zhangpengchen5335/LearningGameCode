using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderFighter
{
    public partial class MyErrorBox : UserControl
    {
        public MyErrorBox()
        {
            InitializeComponent();
        }

        public void SetMsg(string msg)
        {
            textBox1.Text = msg;
            Show();
            BringToFront();
        }
    }
    
}
