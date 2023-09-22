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
    public partial class frmbt10 : Form
    {
        public frmbt10()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        private int count = 0;
        private int giai2 = 0;
        private int giai1 = 0;
        private void btnQuayso_Click(object sender, EventArgs e)
        {
           
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            
            int a,b,c;
            a = rd.Next(1, 9);
            b = rd.Next(1, 9);
            c = rd.Next(1, 9);
            txt1.Text = a.ToString();
            txt2.Text = b.ToString();
            txt3.Text = c.ToString();
            count++;
            lblLanquay.Text = count + "";
            if (a == b || a == c || b == c)
                giai2++;
            lblGiai2.Text = giai2 + "";
            if (a == b && a == c)
                giai1++;
            lblGiai1.Text = giai1 + "";

        }

        private void btnQuaychu_Click(object sender, EventArgs e)
        {
            string textrd, textrd1, textrd2;
            textrd = Convert.ToString((char)rd.Next(65, 90));
            textrd1 = Convert.ToString((char)rd.Next(65, 90));
            textrd2 = Convert.ToString((char)rd.Next(65, 90));
            txt1.Text = textrd.ToString();
            txt2.Text = textrd1.ToString();
            txt3.Text = textrd2.ToString();
            count++;
            lblLanquay.Text = count + "";
            if (textrd == textrd1 || textrd == textrd2 || textrd1 == textrd2)
                giai2++;
            lblGiai2.Text = giai2 + "";
            if (textrd == textrd1 && textrd == textrd2)
                giai1++;
            lblGiai1.Text = giai1 + "";
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
