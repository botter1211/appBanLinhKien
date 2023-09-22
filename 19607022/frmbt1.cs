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
    public partial class frmbt1 : Form
    {
        public frmbt1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
    Double n, x1, x2;
    Double a = Double.Parse(txtA.Text.Trim());
    Double b = Double.Parse(txtB.Text.Trim());
    Double c = Double.Parse(txtC.Text.Trim());
    Double delta = (b * b) - (4 * a * c);
        if (delta < 0)
            {
                MessageBox.Show("Phương trình vô nghiệm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        else if (delta == 0)
        {
            n = -b / (2 * a);
            txtX1.Text = n.ToString();
        }
            
        else
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                txtX1.Text = x1.ToString();
                txtX2.Text = x2.ToString();
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtX1.Clear();
            txtX2.Clear();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmbt1_Load(object sender, EventArgs e)
        {
            txtX1.ReadOnly = true;
            txtX2.ReadOnly = true;
        }
    }
}
