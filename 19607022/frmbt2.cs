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
    public partial class frmbt2 : Form
    {
        public frmbt2()
        {
            InitializeComponent();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKQ.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát ?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmbt2_Load(object sender, EventArgs e)
        {
            txtKQ.ReadOnly = true;
        }

        public int USCLN (int a, int b)
        {
            return b == 0 ? a : USCLN(b, a % b);
        }

        public float BSCNN (int a, int b)
        {
            return a * b / USCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text.Trim());
            int b = int.Parse(txtB.Text.Trim());
            if(rbtUSCLN.Checked == true)
            {
                
                txtKQ.Text = USCLN(a,b).ToString();
            }
            if(rbtBSCNN.Checked == true)
            {
                txtKQ.Text = BSCNN(a, b).ToString();
            }


        }

    }
}
