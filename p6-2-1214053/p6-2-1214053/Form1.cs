using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p6_2_1214053
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Visualbasic_TextChanged    (object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Corret");
        }

        private void Visualbasic_MouseMove(object sender, MouseEventArgs e)
        {
            Visualbasic.Top -= e.Y;
            Visualbasic.Left -= e.X;
            if (Visualbasic.Top < -16 || Visualbasic.Top > 160)
                Visualbasic.Top = 73;
            if (Visualbasic.Left < -64 || Visualbasic.Left > 384)
                Visualbasic.Left = 160;
        }
    }
}
