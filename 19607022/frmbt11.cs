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
    public partial class frmbt11 : Form
    {
        public frmbt11()
        {
            InitializeComponent();
        }
        string pheptoan, ketqua;
        bool kiemtra;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetqua.Clear();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + "0";
            kiemtra = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + "1";
            kiemtra = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + "2";
            kiemtra = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + "3";
            kiemtra = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + "4";
            kiemtra = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + "5";
            kiemtra = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + "6";
            kiemtra = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + "7";
            kiemtra = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + "8";
            kiemtra = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + "9";
            kiemtra = false;
        }

        private void btncham_Click(object sender, EventArgs e)
        {
            if (kiemtra) txtKetqua.Clear();
            txtKetqua.Text = txtKetqua.Text + ".";
            kiemtra = false;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            ketqua = txtKetqua.Text;
            kiemtra = true;
            pheptoan = "+";
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            ketqua = txtKetqua.Text;
            kiemtra = true;
            pheptoan = "-";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            ketqua = txtKetqua.Text;
            kiemtra = true;
            pheptoan = "*";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            ketqua = txtKetqua.Text;
            kiemtra = true;
            pheptoan = "/";
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            double a = double.Parse(ketqua);
            double b = double.Parse(txtKetqua.Text);
            if (pheptoan == "+")
                txtKetqua.Text = Convert.ToString(a + b);
            else if (pheptoan == "-")
                txtKetqua.Text = Convert.ToString(a - b);
            else if (pheptoan == "*")
                txtKetqua.Text = Convert.ToString(a * b);
            else if (pheptoan == "/")
                txtKetqua.Text = Convert.ToString(a / b);
        }

  
    }
}
