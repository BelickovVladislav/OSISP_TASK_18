using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSISP_TASK_18
{
    public partial class Form1 : Form
    {
        private bool moveable = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!moveable) return;
            var code = e.KeyCode;
            int distance = 20;
            switch (code)
            {
                case (Keys.Down):
                case (Keys.Up):
                    this.Top += distance * (code == Keys.Down ? 1 : -1);
                    break;
                case (Keys.Left):
                case (Keys.Right):
                    this.Left += distance * (code == Keys.Right ? 1 : -1);
                    break;
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            moveable = !moveable;
        }
    }
}
