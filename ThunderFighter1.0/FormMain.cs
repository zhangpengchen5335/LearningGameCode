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
        private long 
        public FormMain()
        {
            InitializeComponent();
        }

        private void StartGame()
        {
            Fighter myFighter = FighterFactory.GetFighter(FighterType.MyFighter);

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
