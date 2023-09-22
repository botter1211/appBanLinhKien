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
    public partial class frmbt3 : Form
    {
        public frmbt3()
        {
            InitializeComponent();
        }


        private void btnLK_Click(object sender, EventArgs e)
        {
            int s = 0;
            int n = int.Parse(txtN.Text.Trim());
            for(int i=1; i<n; i++)
            {
                if(laSNT(i))
                {
                    txtKQ.Text += i.ToString() + ",";
                    s += i;
                }
            }
            txtTC.Text = s.ToString();
        }

        bool laSNT(int k)
        {
            int d = 0;
            for(int i=1; i<=k; i++)
            {
                if (k % i == 0)
                    d++;
            }
            return (d == 2);
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            txtN.Text = rd.Next(100).ToString();
        }

        private void frmbt3_Load(object sender, EventArgs e)
        {
            txtTC.ReadOnly = true;
        }

        private void btnBQ_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtKQ.Clear();
            txtTC.Clear();
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
