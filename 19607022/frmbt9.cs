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
    public partial class frmbt9 : Form
    {
        public frmbt9()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhap.Text.Trim());
            if (SNT(n))
                txtKetqua.Text = n.ToString() + " là số nguyên tố";
            else
                txtKetqua.Text = n.ToString() + " không là số nguyên tố";
            string nhohon = "";
            for(int i=1; i<n; i++)
            {
                if (SNT(i))
                    nhohon = nhohon + i.ToString() + " ";
            }
            txtKetqua.Text += "\r\nSố nguyên tố nhỏ hơn " + n.ToString() +" : "  + nhohon;
            int lonhon = n + 1;
            while(SNT(lonhon) ==false)
            {
                lonhon++;
            }
            txtKetqua.Text += "\r\nSố nguyên tố lớn hơn và gần " + n.ToString() + " nhất : " + lonhon;
        }
        bool SNT (int k)
        {
            int d = 0;
            for (int i = 1; i <= k; i++)
            {
                if (k % i == 0)
                    d++;
            }
            return (d == 2);

        }

        private void frmbt9_Load(object sender, EventArgs e)
        {
            txtKetqua.ReadOnly = true;
        }

   
    }
}
