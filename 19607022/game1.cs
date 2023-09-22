using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19607022
{
    public partial class game1 : Form
    {
        public game1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            pic1.Left += rd.Next(0, 100);
            pic2.Left += rd.Next(0, 100);
            if(pic1.Left >=groupBox1.Width)
            {
                timer1.Stop();
                MessageBox.Show("1 win");
            }
            if (pic2.Left >= groupBox1.Width)
            {
                timer1.Stop();
                MessageBox.Show("2 win");
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            timer1.Interval = 400;
            timer1.Start();
        }
    }
}
