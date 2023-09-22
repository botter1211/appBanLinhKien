using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _19607022
{
    public partial class frmbt13 : Form
    {
        public frmbt13()
        {
            InitializeComponent();
            Hide();
        }

        ArrayList arr = new ArrayList();

        void Hide()
        {
            foreach(Control ctl in groupBox1.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.Visible = false;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Hide();
            int n = trackBar1.Value;
            int dem=0;
            lblTrackbar.Text = trackBar1.Value.ToString();
            Random rd = new Random();
            foreach(Control ctl in groupBox1.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.Visible = true;
                    ctl.Text = rd.Next(-50, 100).ToString();
                    dem++;
                }
                if (dem == n)
                    break;
            }
           
        }

        private void btnTongsoduong_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach (Control ctl in groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    if(ctl.Visible == true)
                        if (int.Parse(ctl.Text) > 0)
                            s += int.Parse(ctl.Text);
                }
            }
            txtKetqua.Text = s.ToString();
        }

        private void btnTongSNT_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach (Control ctl in groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    if (ctl.Visible == true)
                        if (SNT(int.Parse(ctl.Text)))
                            s += int.Parse(ctl.Text);
                }
            }
            txtKetqua.Text = s.ToString();
            
        }
        bool SNT (int k)
        {
            int d = 0;
            for(int i=1; i<=k; i++)
            {
                if (k % i == 0)
                    d++;
            }
            return d == 2;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTrungbinhcong_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach (Control ctl in groupBox1.Controls)
            {
                if (ctl is TextBox)
                {
                    if (ctl.Visible == true)
                         s += int.Parse(ctl.Text);
                        int Sopt = trackBar1.Value;
                        double TBCong = (double)s / Sopt;
                        txtKetqua.Text = TBCong.ToString();
                }
            }
        }
   
    }
}
