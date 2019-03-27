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
    public partial class FormMain : Form
    {
        private string _lastKey = string.Empty;
        private long _lastEnterKeyTime = 0;
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void StartGame()
        {

        }

        private void SetDirection(DirectionType directionType)
        {

        }

        protected override void WndProc(ref Message m)
        {

            base.WndProc(ref m);
        }

       
    }
}
